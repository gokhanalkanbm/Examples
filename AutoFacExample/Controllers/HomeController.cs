using AutoFacService.Abstract;
using System.Web.Mvc;

namespace AutoFacExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        public HomeController(IUserService userService) { _userService = userService; }
        public ActionResult Index()
        {
            var users = _userService.GetAll();
            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}