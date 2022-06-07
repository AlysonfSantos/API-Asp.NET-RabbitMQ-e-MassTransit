using Microsoft.AspNetCore.Mvc;

namespace CadVeicular.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
