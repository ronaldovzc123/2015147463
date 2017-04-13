using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public class TipoPago
    {
       private int tipo_pago;
       private int idpago;
       private string descripcion;
       public int tipoPago
       {
         get 
         {
             return tipo_pago;
         }
           set
           {
               if (value > 0)
                   tipo_pago = value;
           }
       }

       public TipoPago(int tipoPago, int tp, string desc)
       {
           tipoPago = this.tipoPago;
           idpago = tp;
           descripcion = desc;
       }
    }
}
