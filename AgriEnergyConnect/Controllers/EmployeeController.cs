
using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AgriEnergyConnect.Data;
namespace AgriEnergyConnect.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult EmployeeDashboard()
        {
            var model = new ProductFilterViewModel();
            // You can fetch necessary data for the dashboard view, e.g., products
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateFarmer(CreateFarmerViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Hash password before storing it
                var hashedPassword = new PasswordHasher<string>().HashPassword(null, model.Password);

                // Create a new farmer
                var farmer = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Password = model.Password // Store the hashed password
                };

                // Add farmer to the database
                _context.Users.Add(farmer);
                _context.SaveChanges();

                // Redirect to dashboard or another page
                return RedirectToAction("EmployeeDashboard", "User");
            }

            // If validation fails, re-render the dashboard with the same model
            return View("EmployeeDashboard", model);
        }

    }
}
