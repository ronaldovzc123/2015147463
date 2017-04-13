using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public class Transporte : Servicio
    {
        private List<LugarViaje> _LugarViaje;
        private List<cliente> _Cliente;
        private List<TipoViaje> _tipoViaje;
        //  agregacion bus
        private List<Bus> _bus;
        public List<Bus> Bus
        {
            get { return _bus; }

            set
            {
                if (value.Count > 0)
                    _bus = value;
            }
 
        }

    }
}
