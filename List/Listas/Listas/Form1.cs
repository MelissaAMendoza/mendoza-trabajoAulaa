using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                //Generamos numeros aleatorios
                Random numero = new Random();
                int n = numero.Next(1, 100);

                //Adjunta el num generado al listbox
                listas.Items.Add(n.ToString());
            }
        }


        /*public void sumaElementos()
        {
            int suma;
            suma = 0;
            for (int i=0; i<25; i++)
            {
                suma = suma + 
            }
        }*/
    }
}
