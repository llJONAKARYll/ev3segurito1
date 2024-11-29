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

        // GET: Registro
        public async Task<IActionResult> Index()
        {
            var registros = await _context.Registro.Include(r => r.IDUsuario).ToListAsync();
            return View(registros);
        }

        // GET: Registro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Registro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descripcion,IDUsuario")] Registro registro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registro);
        }

        // GET: Registro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro = await _context.Registro
                .Include(r => r.IDUsuario)
                .FirstOrDefaultAsync(m => m.IDRegistro == id); // Cambiado IDRegistro
            if (registro == null)
            {
                return NotFound();
            }

            return View(registro);
        }
    }

}
