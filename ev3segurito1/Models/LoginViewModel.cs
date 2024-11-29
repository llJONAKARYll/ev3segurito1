    using System.ComponentModel.DataAnnotations;
    
    namespace ev3segurito1.Models
    {
    

       public class LoginViewModel
        {
        // Campo privado para el correo
        private string _correo;

        // Propiedad pública con validación de correo
        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        [MaxLength(100, ErrorMessage = "El correo electrónico no puede tener más de 100 caracteres.")]
        public string Correo
        {
            get { return _correo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El correo electrónico no puede estar vacío.");
                }
                _correo = value;
            }
        }

        // Campo privado para la contraseña
        private string _contraseña;

        // Propiedad pública con validación de contraseña
        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres.")]
        [MaxLength(255, ErrorMessage = "La contraseña no puede tener más de 255 caracteres.")]
        public string Contraseña
        {
            get { return _contraseña; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La contraseña no puede estar vacía.");
                }
                _contraseña = value;
            }
        }
    }

}


