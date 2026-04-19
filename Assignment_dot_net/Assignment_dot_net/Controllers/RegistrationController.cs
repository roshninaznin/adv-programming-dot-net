using Assignment_dot_net.EF;
using Assignment_dot_net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Assignment_dot_net.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly RegistrationDbContext _context;

        public RegistrationController(RegistrationDbContext context)
        {
            _context = context;
        }

        // Show form
        public IActionResult Index()
        {
            return View();
        }

        // Handle form submit
        [HttpPost]
        public IActionResult Index(User user)
        {
            // Check if email already exists
            var exists = _context.Users.Any(u => u.Email == user.Email);

            if (exists)
            {
                ViewBag.Error = "Email already exists!";
                return View();
            }

            // Save user
            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Index", "Login");
        }
    }
}
