using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Poe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try   //Se utilizo try catch para controlar errores 
            {
                double MontoInvertir = int.Parse(invertir.Text);

                double TasaInteres = int.Parse(Tasa.Text);

                int PeriodoA = int.Parse(Periodo.Text);


                double PeriodoDeci = (TasaInteres / 100) + 1;

                double interC = Math.Pow(PeriodoDeci, PeriodoA);

                double ValorFinal = MontoInvertir * interC;

                Rcalculo.Text = $" Su interes Compuesto es de :{ValorFinal}$";
            }

            catch (FormatException formatException)
            {
               MessageBox.Show ("Error:" + formatException.Message);
            }

            catch (Exception ex)
            {
               MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void invertir_KeyPress(object sender, KeyPressEventArgs e)//Se utilizo el keypress para que solo se puedan ingresar numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten ingresar Números");
            } 
            
        }

        private void Tasa_KeyPress(object sender, KeyPressEventArgs e)//Se utilizo el keypress para que solo se puedan ingresar numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten ingresar Números");
            }
        }

        private void Periodo_KeyPress(object sender, KeyPressEventArgs e)//Se utilizo el keypress para que solo se puedan ingresar numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten ingresar Números");
            }
        }

        private void invertir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
