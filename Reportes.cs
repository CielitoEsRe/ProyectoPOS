using ProyectoPuntodeVenta.Models;
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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

      
        private void buttonPendientes_Click(object sender, EventArgs e)
        {
            RefrescarPendientes();
        }

       
        private void buttonEntregada_Click(object sender, EventArgs e)
        {
            if (dataGridViewReportes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una factura");
                return;
            }

            string numero = dataGridViewReportes.CurrentRow.Cells["NumeroFactura"].Value.ToString();

            for (int i = 0; i < DatosSistema.listaFacturas.Count; i++)
            {
                if (DatosSistema.listaFacturas[i].NumeroFactura.ToString() == numero)
                {
                    DatosSistema.listaFacturas[i].EstadoVenta = "Entregada";
                    break;
                }
            }

            MessageBox.Show("Estado actualizado");

            RefrescarPendientes(); 
        }

        private void buttonTotalVentas_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (var factura in DatosSistema.listaFacturas)
            {
                if (factura.FechaVenta.Date >= dateTimeInicio.Value.Date &&
                    factura.FechaVenta.Date <= dateTimeFinal.Value.Date)
                {
                    foreach (var d in factura.Detalles)
                    {
                        total += d.Cantidad * d.PrecioVenta;
                    }
                }
            }

            MessageBox.Show("Total ventas: Q " + total);
        }

        private void buttonGanancia_Click(object sender, EventArgs e)
        {
            decimal ganancia = 0;

            foreach (var factura in DatosSistema.listaFacturas)
            {
                if (factura.FechaVenta.Date >= dateTimeInicio.Value.Date &&
                    factura.FechaVenta.Date <= dateTimeFinal.Value.Date)
                {
                    foreach (var d in factura.Detalles)
                    {
                        ganancia += d.Cantidad * (d.PrecioVenta - d.PrecioCompra);
                    }
                }
            }

            MessageBox.Show("Ganancia: Q " + ganancia);
        }

    
        private void RefrescarPendientes()
        {
            var pendientes = DatosSistema.listaFacturas
                .Where(f => f.EstadoVenta == "Pendiente")
                .ToList();

            dataGridViewReportes.DataSource = null;
            dataGridViewReportes.DataSource = pendientes;
        }
    }
}