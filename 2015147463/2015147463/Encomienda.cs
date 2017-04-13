using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public class Encomienda : Servicio
    {
        private string nom;
        private string ape;
        private string dni;


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

        public string Nom
        {
            get { return nom; }
            set { if (value != null) { nom = value; } }
        }
        public string Ape
        {
            get { return ape; }
            set { if (value != null) { ape = value; } }
        }
        public string DNI
        {
            get { return dni; }
            set { if (value != null) { dni = value; } }
        }


        public Encomienda(int econ, string des, int id_ser, int lugar, int Cant) :base( id_ser)
        {
            id_ecom = econ;
            descripcion = des;
            id_ser = IDser;
            _Lugar = new List<LugarViaje>(lugar);
            CantEnco = Cant;
        }

        public void AgregarEncomienda(string _nom, string _ape, string _dni) 
          {
            this.Nom  = _nom ;
             this.Ape = _ape;
             this.DNI = _dni;

             Console.WriteLine("Los datos  del cliente de ecomienda son: " + _nom + " " + _ape + " " + _dni);
             Console.ReadLine();
          }

        public Encomienda() { }

      


    }
}
