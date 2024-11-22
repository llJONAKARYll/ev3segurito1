using Microsoft.AspNetCore.Mvc;
using ev3segurito1.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ev3segurito1.DataBase;

 
    namespace ev3segurito1.Controllers{
   

    public class RegistroController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Index
        public IActionResult Index()
        {
            var registros = _context.Registro.ToList();
            return View(registros);
        }

        // GET: Crear
        [HttpGet]
        public IActionResult Crear() => View();

        // POST: Crear
        [HttpPost]
        public IActionResult Crear(Registro registro)
        {
            if (ModelState.IsValid)
            {
                registro.FechaCreacion = DateTime.Now;
                _context.Registro.Add(registro);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registro);
        }
    }

}
