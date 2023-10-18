using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeControllerTest : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
