// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;

namespace gomokuLiveGame.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
