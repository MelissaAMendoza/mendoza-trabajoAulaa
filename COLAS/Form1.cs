using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLAS
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

        private void btnINSERTAR_Click(object sender, EventArgs e)
        {
            //Generamos numeros aleatorios
            Random numero = new Random();
            int n = numero.Next(1, 99);

            //Adjunta el num generado al listbox
            ListaColas.Items.Add(n.ToString());

        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            //Eliminamos los numeros del listbox empezando por el primer que entro
            ListaColas.Items.RemoveAt(0);
        }
    }
}
