using Microsoft.AspNetCore.Mvc;

namespace Holamundo.Views.MyController
{
    public class MyControllerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Captura()
        {
            return View();
        }
    }

}
