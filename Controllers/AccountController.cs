using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDBContext _db;

        public AccountController(AppDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel obj)
        {
            var user=_db.Users.FirstOrDefault(x=>x.Email==obj.Email);
            if(user!=null && user.Password == obj.Password)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid Email or Password forr the given field");
            }
            return View(obj);
        }

        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel obj)
        {
            if(ModelState.IsValid)
            {
                _db.Users.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            return View(obj);
        }
    }
}
