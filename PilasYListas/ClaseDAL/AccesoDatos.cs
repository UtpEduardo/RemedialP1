using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace ClaseDAL
{
    public class AccesoDatos
    {
        NudoDoble Ancla = null;
        private int cuentaNumero = 0;

       public string AgregrarDatosFinal(NudoDoble nuevo)
        {
            string msj = "";
            NudoDoble fin = null;

            if(Ancla == null)
            {
                Ancla = nuevo;
                msj = "Se agrego el Ancla correctamente";
            }
            else
            {
                fin = Ancla;
                while(fin.siguiente!= null)
                {
                    fin = fin.siguiente;
                }
                fin.siguiente = nuevo;
                nuevo.anterior = fin;
                msj = "Se agrego el nudo correctamente";
            }
            return msj;
        }

        public string[] mostrar()
        {
            string[] resultados = new string[cuentaNumero];
            NudoDoble t = null;
            int x = 0;
            t = Ancla;

            while(t != null)
            {
                resultados[x] = t.DatoG.MostrarInfo();
                x++;
                t = t.siguiente;
            }
            return resultados;
        }

        public NudoDoble Buscar(int id)
        {
            NudoDoble r1 = null;
            NudoDoble piedrita = null;
            r1 = Ancla;
            while(r1 != null)
            {
                if(r1.DatoG.num != null)
                {
                    piedrita = r1;
                }
                r1 = r1.siguiente;
            }
            return piedrita;
        }

        public string Eliminar(int id)
        {
            NudoDoble Encontrado = null;
            NudoDoble anterioE = null;
            string salida = "";

            Encontrado = Buscar(id);

            if(Encontrado != null)
            {
                if(Encontrado == Ancla)
                {
                    Ancla = Encontrado.siguiente;
                    Encontrado.siguiente = null;
                }
                else
                {
                    anterioE = Buscar(id);
                    anterioE.siguiente = Encontrado.siguiente;
                    Encontrado.siguiente = null;
                    Encontrado = null;
                    salida = "Elimado correctamente";
                }
            }
            else
            {
                salida = "No se encontro nada Y no hubo ninguna eliminacion";
            }
            return salida;
        }
    }
}
