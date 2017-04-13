using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463
{
    public class LugarViaje
    {
        private int cod;
        private string provincia;
        private List<TipoLugar> _tipoLugar;

        public LugarViaje(int tpl, int encom, int codigo, string pro) 
        {
           _tipoLugar = new List<TipoLugar>(tpl);
           cod = codigo;
           provincia = pro;
        }

    }
}
