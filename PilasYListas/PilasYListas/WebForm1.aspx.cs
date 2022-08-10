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

        
        SolucionR ca = new SolucionR();
        Stack<int> pilaNum = new Stack<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ca"] != null)
            {
                ca = (SolucionR)Session["ca"];
                pilaNum = (Stack<int>)Session["ca"];
            }

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             
            pilaNum.Push(int.Parse(TextBox1.Text));

            Label2.Text = ca.agregarF(new NudoDoble(new Datos() {
                num = pilaNum,
                DaInf = TextBox2.Text
                }));

            TextBox1.Text = "";
            TextBox2.Text = "";

            Session["ca"] = ca;
            Session["ca"] = pilaNum;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int[] pilaM = new int[pilaNum.Count];
            pilaNum.CopyTo(pilaM, 0);

            ListBox1.Items.Clear();

            foreach (int a in pilaM)
            {
                ListBox1.Items.Add(a + "");
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            reBusqueda.Text = ca.buscar(Int16.Parse(TextBox3.Text));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}