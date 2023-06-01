using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculoIVA;

namespace IVAWindowsCliente
{
    public partial class Form1 : Form
    {

        private byte rbselected = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double numero;
            if (double.TryParse(textBox1.Text, out numero))
            {
                Calculadora cal = new Calculadora(numero, rbselected); 
                label1.Text = cal.totalSinIVA().ToString();
            }
            else
            {
                label1.Text = "No has introducido un número"; 
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.Checked = true;
            /*radioButton2.Checked = false;
            radioButton3.Checked = false;*/
            rbselected = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.Checked = false;
            //radioButton2.Checked = true;
           // radioButton3.Checked = false;
            rbselected = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            /*radioButton2.Checked = false;
            radioButton1.Checked = false;*/
            //radioButton3.Checked = true;
            rbselected = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numero;
            if (double.TryParse(textBox1.Text, out numero))
            {
                Calculadora cal = new Calculadora(numero, rbselected);
                label1.Text = cal.IVA().ToString();
            }
            else
            {
                label1.Text = "No has introducido un número";
            }
        }
    }
}
