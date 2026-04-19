using Assignment_dot_net.EF;
using Assignment_dot_net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Assignment_dot_net.Controllers
{
    public class DashboardController : Controller
    {
        private readonly RegistrationDbContext _context;

        public DashboardController(RegistrationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if (email == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var user = _context.Users.FirstOrDefault(u => u.Email == email);

            return View(user);
        }
    }
}
