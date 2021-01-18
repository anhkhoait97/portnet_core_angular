using Microsoft.AspNetCore.Mvc;

namespace Web.BackendServer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}