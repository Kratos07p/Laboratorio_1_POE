using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Utilizamo el metodo char.IsDigit para que ejecute el if si la tecla seleccionada era un numero
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Se presionó un número: " + e.KeyChar, "Número Presionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Utilizamo el metodo char.IsLetter para que ejecute el else if si la tecla seleccionada era una letra
            else if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Se presionó una letra: " + e.KeyChar, "Letra Presionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //El else se utiliza para evitar manda un mensaje si la letra seleccionada no era ni una letra ni un numero
            else
            {

            }

        }
    }
    } 

