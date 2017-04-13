using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public  class Empleado
    {      
        private string nomEmp;
        private string apeEmp;
        public int id_Emp;
        private string labor;

         public string NomEmp
        {
            get { return nomEmp;}
            set { if(value != null) { nomEmp = value; } }
        }
         public string ApeEmp
         {
             get { return apeEmp; }
             set { if (value != null) { apeEmp = value; } }
         }

         public string Labor
         {
             get { return labor; }
             set { if (value != null) { labor = value; } }
         }

         public int IDemp
         {
             get { return id_Emp; }
             set { if (value > 0) { id_Emp = value; } }
         }

         public Empleado()
         { }

        
          public Empleado(string _nomEmp, string _apeEmp, string _labor) 
          {
              _nomEmp = nomEmp;
              _apeEmp = apeEmp;
              _labor = labor;
              
          }

          public Empleado(int _idEmp)
          { _idEmp = id_Emp; }

       
    }
}
