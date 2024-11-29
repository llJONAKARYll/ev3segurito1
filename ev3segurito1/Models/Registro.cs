using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ev3segurito1.Models
{
    public class Registro
    {
        private int idRegistro;
        public int IDRegistro
        {
            get { return idRegistro; }
            set { idRegistro = value; }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string datos;
        public string Datos
        {
            get { return datos; }
            set { datos = value; }
        }

        private int idUsuario;
        public int IDUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
    }

}


