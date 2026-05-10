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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonProductosVendidos_Click(object sender, EventArgs e)
        {
            List<ReporteProducto> reporte = new List<ReporteProducto>();

            for (int i = 0; i < DatosSistema.listaFacturas.Count; i++)
            {
                for (int j = 0; j < DatosSistema.listaFacturas[i].Detalles.Count; j++)
                {
                    string codigo = DatosSistema.listaFacturas[i].Detalles[j].CodigoProducto;
                    int cantidad = DatosSistema.listaFacturas[i].Detalles[j].Cantidad;

                    bool existe = false;

                    for (int k = 0; k < reporte.Count; k++)
                    {
                        if (reporte[k].CodigoProducto == codigo)
                        {
                            reporte[k].TotalVendido += cantidad;
                            existe = true;
                            break;
                        }
                    }

                    if (existe == false)
                    {
                        ReporteProducto nuevo = new ReporteProducto();
                        nuevo.CodigoProducto = codigo;
                        nuevo.TotalVendido = cantidad;

                        reporte.Add(nuevo);
                    }
                }
            }

            dataGridViewReportes.DataSource = null;
            dataGridViewReportes.DataSource = reporte;
        }

        private void buttonTotalVentas_Click(object sender, EventArgs e)
        {
            decimal totalVentas = 0;

            for (int i = 0; i < DatosSistema.listaFacturas.Count; i++)
            {
                DateTime fecha = DatosSistema.listaFacturas[i].FechaVenta;

                if (fecha >= dateTimeInicio.Value && fecha <= dateTimeFinal.Value)
                {
                    for (int j = 0; j < DatosSistema.listaFacturas[i].Detalles.Count; j++)
                    {
                        string codigo = DatosSistema.listaFacturas[i].Detalles[j].CodigoProducto;
                        int cantidad = DatosSistema.listaFacturas[i].Detalles[j].Cantidad;

                        for (int k = 0; k < DatosSistema.listaProductos.Count; k++)
                        {
                            if (DatosSistema.listaProductos[k].Codigo == codigo)
                            {
                                totalVentas += DatosSistema.listaProductos[k].PrecioVenta * cantidad;
                                break;
                            }
                        }
                    }
                }
            }

            MessageBox.Show("Total de ventas: Q " + totalVentas);
        }
    }
}
