using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public class Transporte : Servicio
    {
        public int CantPasajes;
        private List<LugarViaje> _LugarViaje;
        private List<cliente> _Cliente;
        private List<TipoViaje> _tipoViaje;

        // la cantidad de pasajes que pide el enunciado
        public int Cantidad 
        {
            get { return CantPasajes; }
            set { CantPasajes = 3; }
        }


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

        

        public Transporte(int lugar, int cliente, int tipo, int id_ser, List<Bus> buss, int CP) : base(id_ser) 
        {
            _LugarViaje = new List<LugarViaje>(lugar);
            _Cliente = new List<cliente>(cliente);
            _tipoViaje = new List<TipoViaje>(tipo);
            Bus = buss;
            id_ser = IDser;
            CantPasajes = CP;
        }

    }
}
