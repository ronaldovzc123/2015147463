using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var venta = new Venta();

         //   cliente.Agregar("Ronaldo", "Zelada","955337622", 01);



            venta.Agregar("Ronaldo", "Zelada", "955337622", 1); //pasajero
            venta.Agregar("Hernan", "Zelada", "999234423", 2); //pasajero2
            venta.Agregar("Leoncio", "Zelada", "998827473", 3); //pasajero3

            venta.Agregar("Martha", "Cabezudo", "9553425", 04); //encomienda1
            venta.Agregar("Ñato", "Zelada", "234533453", 05); //encomienda2

            var tipoBus = new Bus();
            var tipoViaje = new TipoViaje();

            tipoViaje.Tipo_viaje();
            tipoBus.TipoBuss();
           
            
            


            
        }
    }
}
