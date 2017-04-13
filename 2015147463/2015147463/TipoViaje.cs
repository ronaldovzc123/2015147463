using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public  class TipoViaje : Bus 
    {
        string tipo_viaje;
        int _tipobus {set; get;}

        public TipoViaje(int tipobus) : base(tipobus)
        {
            _tipobus = tipobus;
        }

        // jalamos la variable de tipo de bus int de la clase bus y de acuerdo a la descripcion nominamos que tipo de viaje es

        public string Tipo
        {
            get { return tipo_viaje; }
            set { if (_tipobus == 1) { tipo_viaje = "Viaje Normal"; } else { tipo_viaje = "Viaje Cama"; } }
        }
        



    }
}
