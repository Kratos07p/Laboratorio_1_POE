using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Utilizamos el metodo keypress para agregar una condicional al textbox para evitar que se ingrese otra cosa que no sean palabra
        private void palabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))//Condicional para evitar que se pongan caracteres que no sean palabras
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten ingresar Letras");
            }
            
        }
        //Aqui mandamos a llamar a la caja de texto de palabras para convertir en mayuscula las letras ingresadas
        private void Accion_Click(object sender, EventArgs e)
        {
            string texto, todomayus;

            texto = palabra.Text;
            todomayus = texto.ToUpper(); //Se utiliza ToUpper para convertir las palabras en mayusculas

            MessageBox.Show(todomayus);
            

        }
    }
}
