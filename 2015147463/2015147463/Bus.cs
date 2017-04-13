using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
   public class Bus
    {
       private List<tripulacion> _tripulacion;
       public int NumBuses;
       private int id_bus;
       private string descripcion;
       private int tipo;
       private string tipoo;
       private DateTime fecha;

       public int Tipo
       {
           get { return tipo; }

           set
           {
               Random rnd = new Random();
               int tipo = rnd.Next(0, 2);
           }

           //set { if (value == 1) { tipoo = "bus normal"; } else { tipoo = "bus cama"; } }

       }
       public void TipoBuss()
       {
           if (tipo == 1) { tipoo = "bus normal"; } else { tipoo = "bus cama"; }
           Console.Write("el tipo de bus es: " + tipoo);
       }
       

         

       public int NumBus
       {
           get { return NumBuses; }
           set { if (value > 0) { NumBuses = value; } }
       }

       public int IdBus
       {
           get { return id_bus; }
           set { if (value > 0) { id_bus = value; } }
       }
       public string Descrip
       {
           get { return descripcion; }
           set { if (value != null) { descripcion = value; } }
       }
       public DateTime Fecha
       {
           get { return fecha; }
           set { fecha = DateTime.Now ; }
       }
       // contar la tripulacion

       public List<tripulacion> Tripulacion
       {
           get { return _tripulacion; }

           set
           {
               if (value.Count > 0)
                   _tripulacion = value;
           }
       }

       public Bus(string descrip, int idBus, DateTime Fec, int numB, List<tripulacion> trip, string tipooo) 
          {
              descrip = descripcion;
              idBus = id_bus;
              Fec = fecha;
              numB = NumBus;
              trip = Tripulacion;
              tipoo = tipooo;
            
          }

        public Bus(int tipo) 
        {
            tipo = this.tipo;
        }
        public Bus()
        { }

    }
}
