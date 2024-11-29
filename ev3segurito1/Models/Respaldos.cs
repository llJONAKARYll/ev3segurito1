using System.ComponentModel.DataAnnotations;

namespace ev3segurito1.Models
{
    public class Respaldos
    {
        [Key]
        public int Id { get; set; } // Clave primaria
        public string FileName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
