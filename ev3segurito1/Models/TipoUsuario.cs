namespace ev3segurito1.Models
{
    public class TipoUsuario
    {
        // Propiedad privada para IDTipoUsuario
        private int idTipoUsuario;

        // Propiedad pública para acceder al IDTipoUsuario
        public int IDTipoUsuario
        {
            get { return idTipoUsuario; }
            set { idTipoUsuario = value; }
        }

        // Propiedad privada para Descripcion
        private string descripcion;

        // Propiedad pública para acceder a la Descripcion
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }

}
