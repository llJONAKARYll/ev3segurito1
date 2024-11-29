using Microsoft.AspNetCore.Mvc;


namespace ev3segurito1.Controllers
{
    public class HomeController : Controller
    {
        // Acción que maneja la vista principal (Index)
        public IActionResult Index()
        {
            return View();
        }

        // Otras acciones, si es necesario
        public IActionResult Privacy()
        {
            return View();
        }
    }

}
