using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using AgriEnergyConnect.Data;
using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Authorization;

namespace AgriEnergyConnect.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly PasswordHasher<User> _passwordHasher;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<User>();
        }

        // GET: User/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: User/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User model)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("Email", "Email already exists.");
                    return View(model);
                }

                // Hash the password
                model.Password = _passwordHasher.HashPassword(model, model.Password);

                _context.Users.Add(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("Login");
            }

            return View(model);
        }

        // GET: User/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: User/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == model.Email);

            if (user != null)
            {
                var result = _passwordHasher.VerifyHashedPassword(user, user.Password, model.Password);
                if (result == PasswordVerificationResult.Success)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Email),
                        new Claim("FullName", $"{user.FirstName} {user.LastName}"),
                        new Claim(ClaimTypes.Role, user.Role),
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()) // Add this claim

                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

                    if (user.Role == "Employee")
                        return RedirectToAction("EmployeeDashboard", "User");

                    else
                        return RedirectToAction("FarmerDashboard");
                }
            }

            ModelState.AddModelError("", "Invalid login attempt.");
            return View(model);
        }


        [Authorize(Roles = "Employee")]
        public async Task<IActionResult> EmployeeDashboard(
     string? category, string? farmerName, DateTime? startDate, DateTime? endDate)
        {
            var query = _context.Products
                .Include(p => p.User)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
                query = query.Where(p => p.Category.ToLower().Contains(category.ToLower()));

            if (!string.IsNullOrWhiteSpace(farmerName))
                query = query.Where(p =>
                    (p.User.FirstName + " " + p.User.LastName).ToLower().Contains(farmerName.ToLower()));

            if (startDate.HasValue)
                query = query.Where(p => p.ProductionDate >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(p => p.ProductionDate <= endDate.Value);

            var viewModel = new ProductFilterViewModel
            {
                Category = category,
                FarmerName = farmerName,
                StartDate = startDate,
                EndDate = endDate,
                Products = await query.ToListAsync()
            };

            return View(viewModel);
        }



        [Authorize(Roles = "Farmer")]
        public async Task<IActionResult> FarmerDashboard()
        {
            // Get the logged-in user's ID
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized(); // or redirect to login
            }

            // Filter products by the logged-in farmer's UserId
            var products = await _context.Products
                .Where(p => p.UserId == userId)
                .ToListAsync();

            return View(products);
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        // GET: User/RegisterFarmer
        [Authorize(Roles = "Employee")]
        public IActionResult RegisterFarmer()
        {
            return View();
        }

        // POST: User/RegisterFarmer
        [HttpPost]
        [Authorize(Roles = "Employee")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterFarmer(User model)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("Email", "Email already exists.");
                    return View(model);
                }

                // Hash the password
                model.Password = _passwordHasher.HashPassword(model, model.Password);

                // Set the role as "Farmer"
                model.Role = "Farmer";

                _context.Users.Add(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("EmployeeDashboard");
            }

            return View(model);
        }
    }
}


