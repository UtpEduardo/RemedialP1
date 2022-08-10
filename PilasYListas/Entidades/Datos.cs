using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Datos
    {
        public Stack<int> num { set; get; }
        public string DaInf { set; get; }
        public string MostrarInfo()
        {
            return "Numero " + this.num +
                " //Dato Generales: " + this.DaInf;
        }
    }
}
