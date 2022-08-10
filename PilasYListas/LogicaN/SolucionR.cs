using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using ClaseDAL;

namespace LogicaN
{
    public class SolucionR
    {
        AccesoDatos AD = new AccesoDatos();

        public string agregarF(NudoDoble nuevo)
        {
            try {
                return AD.AgregrarDatosFinal(nuevo);
            }catch(Exception e)
            {
                return "Error" + e;
            }
            
        }

        public string[] motrar()
        {
            return AD.mostrar();
        }

        public string buscar(int id)
        {
            string rasBusqueda = "";
            NudoDoble piedrita = null;

            piedrita = AD.Buscar(id);

            if(piedrita == null)
            {
                return "No se encontro nada";
            }
            else
            {
                rasBusqueda = "Resultado de la Busqueda \n" + piedrita.DatoG.MostrarInfo();
            }

            return rasBusqueda;
        }

        public string eliminatr(int id)
        {
            try {
                return AD.Eliminar(id);
            }
            catch(Exception e)
            {
                return "Error a la Eliminacion " + e;
            }
            
        }
    }
}
