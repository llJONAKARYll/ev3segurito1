using Microsoft.AspNetCore.Mvc;
using ev3segurito1.Models;

namespace ev3segurito1.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Simulación de lógica de autenticación
            bool isAuthenticated = model.Username == "admin" && model.Password == "password"; // Temporal
            if (isAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Credenciales incorrectas.");
            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
