using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5_poe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cal_Click(object sender, EventArgs e)
        {
                double numero = double.Parse(num.Text);

                double respuesta = Math.Sqrt(numero);

                res.Text = $"La raiz cuadrada del numero ingresado es de : {respuesta}";
        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)  //Se utilizo el keypress para que solo se puedan ingresar numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Condicional para que solo permita ingresar numeros
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten ingresar Números");
            }
        }
    }
}
