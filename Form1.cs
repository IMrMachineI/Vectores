using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tamaño = 0;
        Vector nuevoVector;

        private void btnCrear_Click(object sender, EventArgs e)
        {
            tamaño = Convert.ToInt32(txtCrear.Text);
            nuevoVector = new Vector(tamaño);
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            int numInicial = Convert.ToInt32(txtnumInicial.Text);
            nuevoVector.llenarVector(numInicial);
        }
        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = nuevoVector.ToString();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            nuevoVector.invertir();
        }

        private void btnGirarAbajo_Click(object sender, EventArgs e)
        {
            nuevoVector.girarAbajo();
        }

        private void btnGirarArriba_Click(object sender, EventArgs e)
        {
            nuevoVector.girarArriba();
        }
    }
}
