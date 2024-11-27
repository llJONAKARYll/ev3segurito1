    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace ev3segurito1.Models
    {
        public class Registro
        {
            [Key]
            public int IDRegistro { get; set; }

            [Required]
            public DateTime Fecha { get; set; } = DateTime.Now;

            [Required]
            [StringLength(255)]
            public string Descripcion { get; set; }

            [ForeignKey("Usuario")]
            public int IDUsuario { get; set; } // Relación con la tabla Usuarios

            public Users Usuario { get; set; } // Propiedad de navegación
        }
    }


