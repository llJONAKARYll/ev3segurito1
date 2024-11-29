using System.ComponentModel.DataAnnotations;

namespace ev3segurito1.Models
{
    public class Respaldo
    {
        [Key]
        public int IDRespaldo { get; set; }

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required]
        [StringLength(255)]
        public string RutaArchivo { get; set; } // Ruta donde se guarda el respaldo

        public string UsuarioRealizo { get; set; }
      
    }
}
