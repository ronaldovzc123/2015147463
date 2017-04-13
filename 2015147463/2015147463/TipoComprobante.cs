using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
   public  class TipoComprobante
    {
       private int nrcomprobante;
       private string descripcion;
   

       public TipoComprobante(int comprobante, string des)
       {
           nrcomprobante = comprobante;
           descripcion = des;
       }
    }
}
