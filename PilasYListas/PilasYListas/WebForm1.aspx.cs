using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using LogicaN;

namespace PilasYListas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SolucionR LN = null;
        Stack<int> idNum = new Stack<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            LN = new SolucionR();
            if(Session["LN"] != null)
            {
                LN = (SolucionR)Session["LN"];
            }

            if(Session["pila"] != null)
            {
                idNum = (Stack<int>)Session["pila"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            idNum.Push(Int16.Parse(TextBox1.Text));

            Label2.Text = LN.agregarF(new NudoDoble(new Datos()
            {
                num = idNum
            }));

            TextBox1.Text = "";

            Session["pila"] = idNum;
            Session["LN"] = LN;
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int[] copia = new int[idNum.Count];
            idNum.CopyTo(copia, 0);

            ListBox1.Items.Clear();
            
            foreach (int a in copia)
            {
                ListBox1.Items.Add(a + "");
            }

            Session["pila"] = idNum;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label4.Text = LN.buscar(Int16.Parse(TextBox2.Text));

            Session["LN"] = LN;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
            Label4.Text = LN.eliminatr(Int16.Parse(TextBox2.Text));
            Session["LN"] = LN;
        }
    }
}