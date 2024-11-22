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
        // GET: Registro/Create
        public IActionResult Create()
        {
            return View(); // Esto busca la vista "Create.cshtml" en la carpeta "Views/Registro"
        }

        // POST: Registro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Registro registro)
        {
            if (ModelState.IsValid)
            {
                _context.Registro.Add(registro);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index)); // Redirige al listado
            }
            return View(registro); // Retorna la vista con los datos en caso de error
        }

    }

}
