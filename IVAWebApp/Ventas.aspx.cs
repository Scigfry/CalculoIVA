using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculoIVA;

namespace IVAWebApp
{
    public partial class Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte tipo = 0;
            Byte.TryParse(RadioButtonList1.SelectedValue, out tipo);
            double numero;
            if (double.TryParse(TextBox1.Text, out numero))
            {
                Calculadora cal = new Calculadora(numero, tipo);
                Label1.Text = cal.totalSinIVA().ToString();
            }
            else
            {
                Label1.Text = "No has introducido un número";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            byte tipo = 0;
            Byte.TryParse(RadioButtonList1.SelectedValue, out tipo);
            double numero;
            if (double.TryParse(TextBox1.Text, out numero))
            {
                Calculadora cal = new Calculadora(numero, tipo);
                Label1.Text = cal.IVA().ToString();
            }
            else
            {
                Label1.Text = "No has introducido un número";
            }

        }

    }
}