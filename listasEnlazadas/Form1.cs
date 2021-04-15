using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listasEnlazadas
{
    public partial class Form1 : Form
    {
        List<string> listaPalabras = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            string palab;

            palab = txtPalabras.Text;

            listaPalabras.Add(palab);

            listPalabras.DataSource = null;
            listPalabras.DataSource = listaPalabras;
        }

        private void btnElim_Click(object sender, EventArgs e)
        {

            listaPalabras.Remove(txtPalabras.Text);

            listPalabras.DataSource = null;
            listPalabras.DataSource = listaPalabras;


        }
    }
}
