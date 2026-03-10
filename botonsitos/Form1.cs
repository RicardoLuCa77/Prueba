using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botonsitos
{
    public partial class Form1 : Form
    {
        // Variable para llevar la cuenta
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Manejador de evento para el botón "Sumar"
        private void button2_Click(object sender, EventArgs e)
        {
            contador++; // Aumentamos el número
            labelContador.Text = "Contador: " + contador; // Actualizamos el texto
        }
    }
}

