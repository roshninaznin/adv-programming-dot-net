using Assignment_dot_net.EF;
using Assignment_dot_net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Assignment_dot_net.Controllers
{
    public class LoginController : Controller
    {
        private readonly RegistrationDbContext _context;

        public LoginController(RegistrationDbContext context)
        {
            _context = context;
        }

        // Show login form
        public IActionResult Index()
        {
            return View();
        }

        // Handle login
        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                // Save session
                HttpContext.Session.SetString("UserEmail", user.Email);

                return RedirectToAction("Index", "Dashboard");
            }

            ViewBag.Error = "Invalid email or password";
            return View();
        }
    }
}
