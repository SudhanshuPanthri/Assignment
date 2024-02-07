using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            //if (true)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
