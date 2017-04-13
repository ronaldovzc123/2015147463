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

           

            var tipoBus = new Bus();
            var tipoViaje = new TipoViaje();
            var encomienda = new Encomienda();

            tipoViaje.Tipo_viaje();
            tipoBus.TipoBuss();

            encomienda.AgregarEncomienda("Martha", "Cabezudo", "1098128");//encomienda1
            encomienda.AgregarEncomienda("Ñato", "Zelada", "234533453");//encomienda2


  
            


            
        }
    }
}
