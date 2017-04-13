using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public  class Servicio
    {
        public int idServicio;
        private string tipo;
        DateTime fecha;

        public int  IDser  
        {
            get { return idServicio; }
            set { if (value > 0) { idServicio = value; } }
        }

        public string Tipo
        {
            get { return tipo; }
            set { if (value != null) { tipo = value; } }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = DateTime.Now; }
        }

        public Servicio( string tip, DateTime fec)
        {
            tip = tipo;
            fec = fecha;
        }

        public Servicio(int id)
        {
            id = idServicio;
        }


    }
}
