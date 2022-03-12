using Microsoft.AspNetCore.Mvc;

namespace Holamundo.Controllers
{
    public class MyHomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
