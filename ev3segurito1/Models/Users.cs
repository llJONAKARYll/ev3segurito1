namespace ev3segurito1.Models
{
    public class Users
    {
        private int idUsuario;
        public int IDUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string contraseña;
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        private string rol;
        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        private int idTipoUsuario;
        public int IDTipoUsuario
        {
            get { return idTipoUsuario; }
            set { idTipoUsuario = value; }
        }
    }


}
