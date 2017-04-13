using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public class Venta
    {
        private List<TipoPago> _tipoPago;
        private List<TipoComprobante> _TipoComprobante;
        private List<administrativo> _administrativo;
       
      
        private List<Servicio> _Servicio;
        private DateTime fecha;

        List<cliente> _Cliente = new List<cliente>();

        public Venta()
        { }

        public Venta(int pago, int comprobante, int administrativo, int cliente, int servicio, DateTime fec)
        {
            //_tipoPago = new List<TipoPago>(pago);
            //_TipoComprobante = new List<TipoComprobante>(comprobante);
            //_administrativo = new List<administrativo>(administrativo);
        
            //_Servicio = new List<Servicio> (servicio);
            //fec = fecha;

           
        }

        public void Agregar(string nom, string ape, string dni, int id)
        {

            _Cliente.Add(new cliente(nom, ape,dni, id));

            Console.WriteLine("El nombre del cliente y sus datos son: " + nom + " " + ape + " " + dni + " " + id);

        }

     
  
        
    }
}
