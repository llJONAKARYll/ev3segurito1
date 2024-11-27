using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ev3segurito1.Models
{
    public class Registro
    {
        [Key]
        public int IDRegistro { get; set; } // Corregido de 'Id'

        [Required]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; } // Propiedad agregada

        [ForeignKey("Usuario")]
        public int IDUsuario { get; set; }

        public Users Usuario { get; set; } // Propiedad de navegación
    }
}


