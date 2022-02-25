using Microsoft.AspNetCore.Mvc;
using TwentySix.Data;
using TwentySix.Models;

namespace TwentySix.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Users()
        {
            IEnumerable<User> users = _context.Users;
            return View(users);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Users");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var user = _context.Users.Find(id);
            return View(user);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Users");
        }
    }
}
