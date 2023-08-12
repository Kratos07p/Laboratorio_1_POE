using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Aqui solo tenemos las cajas de textos con el evento de keypress con una condicional para evitar que ingrese letras y carecteres especiales y que permita ingresar numeros
        private void N1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten ingresar Números");
            }
        }

        private void N2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten ingresar Números");
            }
        }
        //En esta parte iniciamos el proceso de la division usando el evento mouseleave ya que con el podemos activar los resultados cuando el cursor abandona el boton
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            double Numero1, Numero2, resultado;
            //aqui llamamos a las dos cajas de texto para que brinden el dato ingresado por el usuario
            Numero1 = Convert.ToDouble(N1.Text);
            Numero2 = Convert.ToDouble(N2.Text);

            resultado = Numero1 / Numero2;
            //aqui se imprime el resultado
            MessageBox.Show("el resultado es: " + resultado);
        }
    }
}
