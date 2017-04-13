using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public  class TipoViaje : Bus 
    {
        string tipo_viaje { set; get; }
        int _tipobus {set; get;}

        public TipoViaje(int tipobus) : base(tipobus)
        {
            _tipobus = tipobus;

        }
         

        public void Tipo_viaje() 
        {
            //if (_Servicio.Count == 3)
              //  return;

            if (_tipobus == 1) { tipo_viaje = "Viaje Normal"; } else { tipo_viaje = "Viaje Cama"; }

            Console.WriteLine("el tipo de Viaje es: " + tipo_viaje);

        }

        public TipoViaje() 
        { }
    }

    

}
