using Microsoft.AspNetCore.Mvc;
using ev3segurito1.DataBase;

 
    namespace ev3segurito1.Controllers{


    public class RegistroController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Asegúrate de que esta acción exista
        public IActionResult Index()
        {
            var registros = _context.Registro.ToList();
            return View(registros);
        }

        // Otra acción (por ejemplo, Eliminar)
        public IActionResult Eliminar(int id)
        {
            var registro = _context.Registro.FirstOrDefault(r => r.IDRegistro == id);
            if (registro != null)
            {
                _context.Registro.Remove(registro);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }


}
