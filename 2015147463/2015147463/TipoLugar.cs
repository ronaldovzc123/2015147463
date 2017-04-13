using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public class TipoLugar
    {
        public int idtipolugar{set; get;}
        private string comentarios {set; get;}
        private string direccion { set; get; }

        public TipoLugar(int tpl, string comn, string dire) 
        {
            tpl = idtipolugar;
            comn = comentarios;
            dire = direccion;
        }

    }
}
