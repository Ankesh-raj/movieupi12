using BookShowEntity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MovieCoreMvcUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            if (admin.Name == "Ankesh@123" && admin.Password == "123")
            {
                ViewBag.status = "Ok";
                ViewBag.message = "Admin Logged succesfully";
                return RedirectToAction("Index", "Movie");
            }
            else
            {
                ViewBag.status = "Error";
                ViewBag.message = "Wrong Credentials";
            }
            return View();
        }
    }
}
