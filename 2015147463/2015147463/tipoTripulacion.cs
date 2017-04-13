using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public  class tipoTripulacion
    {
        private int idTripulacion { set; get; }
        private string descripcion { set; get; }

        public tipoTripulacion(int idtri, string desc)
        {
            idTripulacion = idtri;
            descripcion = desc;
        }



    }
}
