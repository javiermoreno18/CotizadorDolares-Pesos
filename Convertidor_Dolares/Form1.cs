using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor_Dolares
{
    public partial class Form1 : Form

        
    {
        double dolar, peso;
        double dolarConvertido, pesoConvertido;
        public Form1()
        {
            InitializeComponent();
        }

        public void getDolaroPeso()
        {
            if (rbDolaresPesos.Checked)
            {
                dolar = Convert.ToDouble(tbMonto.Text);
                dolarConvertido = dolar * 21.10;
                tbResultado.Text = dolarConvertido.ToString();
            }
            else
            {
                peso = Convert.ToDouble(tbMonto.Text);
                pesoConvertido = peso / 21.10;
                tbResultado.Text = pesoConvertido.ToString();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form calculadora = new Form2();
            calculadora.Show();
        }

        private void rbPesosDolares_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tbMonto.Text = " ";
            tbResultado.Text= " ";

        }

        private void rbDolaresPesos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {

            getDolaroPeso();
            if (rbDolaresPesos.Checked)
            {
                tbResultado.Text = dolarConvertido.ToString();
            }
            else
            {
                tbResultado.Text = pesoConvertido.ToString();
            }
        }
    }
}
