using System.ComponentModel.DataAnnotations;

namespace ev3segurito1.Models
{
    public class Respaldo
    {
        private int idRespaldo;
        public int IDRespaldo
        {
            get { return idRespaldo; }
            set { idRespaldo = value; }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string rutaArchivo;
        public string RutaArchivo
        {
            get { return rutaArchivo; }
            set { rutaArchivo = value; }
        }
    }

}
