using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace ev3segurito1.Controllers
{


public class AdminController : Controller
    {
        private readonly IConfiguration _configuration;

        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: CrearTabla
        [HttpGet]
        public IActionResult CrearTabla() => View();

        // POST: CrearTabla
        [HttpPost]
        public IActionResult CrearTabla(string nombreTabla)
        {
            var query = $"CREATE TABLE {nombreTabla} (Id INT PRIMARY KEY IDENTITY, Nombre NVARCHAR(100), FechaCreacion DATETIME)";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }

            ViewBag.Message = $"Tabla {nombreTabla} creada exitosamente.";
            return View();
        }

        // GET: EliminarRegistro
        [HttpGet]
        public IActionResult EliminarRegistro() => View();

        // POST: EliminarRegistro
        [HttpPost]
        public IActionResult EliminarRegistro(string tabla, int id)
        {
            var query = $"DELETE FROM {tabla} WHERE Id = @Id";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }

            ViewBag.Message = $"Registro con ID {id} eliminado de la tabla {tabla}.";
            return View();
        }
    }

}
