using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public class cliente
    {
       public cliente()
        { }

        private string nom;
        private string ape;
        private string dni;
        private int clien_id; 

        public string Nom
        {
            get { return nom;}
            set { if(value != null) { nom = value; } }
        }
         public string Ape
        {
            get { return ape;}
            set { if(value != null ){ ape = value; } }
        }
         public string DNI
        {
            get { return dni;}
            set { if(value != null ){ dni = value; } }
        }
          public int IDClien
        {
            get { return clien_id;}
            set { if (value > 0) { clien_id = value; } }
        }

          public cliente(string _nom, string _ape, string _dni, int _idclient) 
          {
           this.Nom  = _nom ;
             this.Ape = _ape;
             this.DNI = _dni;
             this.IDClien = _idclient;
          }


        //  public void Agregar(string nombre, string apell, string dNi, int id)
         // {
           //   nom = nombre;
             // ape = apell;
             // dni = dNi;
            //  clien_id = id;
         // }


    }
}
