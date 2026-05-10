using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPuntodeVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTrastienda_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();
        }

        private void buttonPuntodeVenta_Click(object sender, EventArgs e)
        {
            Form3 ventana = new Form3();
            ventana.Show();

        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            Reportes ventana = new Reportes();
            ventana.Show();
        }
    }
}
