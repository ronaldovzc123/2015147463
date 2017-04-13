using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public class cliente
    {
        private string nom;
        private string ape;
        private string dni;
        private int clien_id; 

        public string Nom
        {
            get { return nom;}
            set { if(value != null { nom = value; } }
        }
         public string Ape
        {
            get { return ape;}
            set { if(value != null { ape = value; } }
        }
         public string DNI
        {
            get { return dni;}
            set { if(value != null { dni = value; } }
        }
          public int IDClien
        {
            get { return clien_id;}
            set { if(value != null { clien_id = value; } }
        }

          public cliente(string _nom, string _ape, string _dni, int _idclient) 
          {
              _nom = nom;
              _ape = ape;
              _dni = dni;
              _idclient = clien_id;
          }
       
    }
}
