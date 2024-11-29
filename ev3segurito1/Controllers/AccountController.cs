using Microsoft.AspNetCore.Mvc;
using ev3segurito1.Models;
using Microsoft.AspNetCore.Identity;

namespace ev3segurito1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Users> _userManager;
        private readonly SignInManager<Users> _signInManager;

        public AccountController(UserManager<Users> userManager, SignInManager<Users> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // Método GET para mostrar el formulario de inicio de sesión
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Método POST para procesar el inicio de sesión
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Buscar al usuario por correo
                var usuario = await _userManager.FindByEmailAsync(model.Correo);
                if (usuario != null)
                {
                    // Verificar la contraseña
                    var result = await _signInManager.PasswordSignInAsync(usuario, model.Contraseña, false, false);
                    if (result.Succeeded)
                    {
                        // Redirigir según el rol
                        if (usuario.Rol == "Admin")
                        {
                            return RedirectToAction("Index", "Admin"); // Redirige al panel de administración
                        }
                        else
                        {
                            return RedirectToAction("Index", "User"); // Redirige al panel de usuario regular
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Intento de inicio de sesión fallido.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Usuario no encontrado.");
                }
            }

            return View(model);
        }
    }

}
