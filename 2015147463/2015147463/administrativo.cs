using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    class administrativo : Empleado
    {
        private int IDadmin { set; get; }

        public administrativo(int idadmin, int idemp) : base(idemp) 
        {
            idadmin = IDadmin;
            idemp = IDemp;
        }

    }
}
