
using ev3segurito1.DataBase;
using ev3segurito1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ev3segurito1.Controllers
{
    public class RespaldoController : Controller
    {
        private readonly ApplicationDbContext _context;

        
        public RespaldoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Respaldo
        public async Task<IActionResult> Index()
        {
            var respaldo = await _context.Respaldos.ToListAsync();
            return View(respaldo);
        }

        // GET: Respaldo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Respaldo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RutaArchivo,UsuarioRealizo")] Respaldo respaldo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(respaldo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respaldo);
        }

        // GET: Respaldo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respaldo = await _context.Respaldos.FirstOrDefaultAsync(m => m.IDRespaldo == id);
            if (respaldo == null)
            {
                return NotFound();
            }

            return View(respaldo);
        }

        // POST: Respaldo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var respaldo = await _context.Respaldos.FindAsync(id);
            _context.Respaldos.Remove(respaldo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
