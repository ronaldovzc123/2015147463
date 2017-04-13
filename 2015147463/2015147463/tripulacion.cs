using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public class tripulacion : Empleado
    {
        private List<tipoTripulacion> _tipoTripulacion;
        public int NumPasajeros { get; set; }

        public tripulacion(int numb, int tipo, int idemp) : base(idemp)
        {
            numb = NumPasajeros;
            _tipoTripulacion = new List<tipoTripulacion>(tipo);
            idemp = IDemp;                  
        }

        

    }
}
