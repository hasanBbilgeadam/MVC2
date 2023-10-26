using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost()]
        public IActionResult Login(Userİnformation userİnformation)
        {

            if (userİnformation.UserName == "hasan" && userİnformation.Password=="123")
            {
            return RedirectToAction("index");
            }
                return Redirect("/home/error");
        }

    }
}
