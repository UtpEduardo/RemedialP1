using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NudoDoble
    {
        public Datos DatoG = new Datos();
        public NudoDoble siguiente = null;
        public NudoDoble anterior = null;

        public NudoDoble(Datos obj)
        {
            DatoG = obj;
            siguiente = null;
            anterior = null;
        }
    }
}
