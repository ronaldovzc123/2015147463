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
        private List<cliente> _Cliente;
        private List<Servicio> _Servicio;
        private DateTime fecha;


        public Venta(int pago, int comprobante, int administrativo, int cliente, int servicio, DateTime fec)
        {
            _tipoPago = new List<TipoPago>(pago);
            _TipoComprobante = new List<TipoComprobante>(comprobante);
            _administrativo = new List<administrativo>(administrativo);
            _Cliente = new List<cliente> (cliente);
            _Servicio = new List<Servicio> (servicio);
            fec = fecha;
        }

        
    }
}
