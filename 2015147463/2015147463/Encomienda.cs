using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public class Encomienda : Servicio
    {
        public int CantEnco;
        private int id_ecom;
        private string descripcion;
        private List<LugarViaje> _Lugar;
        
        //Cantidad de ecomiendas vendidas 
        public int CantidadEco
        {
            get { return CantEnco; }
            set { CantEnco = 2; }
        }
          


        public Encomienda(int econ, string des, int id_ser, int lugar, int Cant) :base( id_ser)
        {
            id_ecom = econ;
            descripcion = des;
            id_ser = IDser;
            _Lugar = new List<LugarViaje>(lugar);
            CantEnco = Cant;
        }

      


    }
}
