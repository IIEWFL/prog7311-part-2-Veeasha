using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgriEnergyConnect.Data;
using AgriEnergyConnect.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AgriEnergyConnect.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Category,ProductionDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                // Get the user ID of the logged-in user (from the claims)
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // If there's no user ID, redirect to the login page
                if (userIdString == null)
                {
                    return RedirectToAction("Login", "User");
                }

                // Try to parse the userIdString into an integer (UserId)
                if (int.TryParse(userIdString, out int userId))
                {
                    // Set the UserId for the product (to associate it with the logged-in user)
                    product.UserId = userId;
                }
                else
                {
                    // Handle the case where the user ID cannot be parsed correctly
                    ModelState.AddModelError("", "User ID is invalid.");
                    return View(product);
                }

                // Ensure that the User navigation property is not required, so don't assign it manually
                product.User = null; // Explicitly nullify the User navigation property if set

                // Add the product to the database
                _context.Add(product);
                await _context.SaveChangesAsync();

                // Set a success message to be displayed on the next page
                TempData["SuccessMessage"] = "Product added successfully!";
                return RedirectToAction("FarmerDashboard", "User"); // Redirect to the FarmerDashboard after success
            }

            // If ModelState is not valid, return the same view to display validation errors
            return View(product);
        }
    }
}
