using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPuntodeVenta.Models;

namespace ProyectoPuntodeVenta

{
    public partial class Form2 : Form
    {
        private List<Producto> listaProductos = DatosSistema.listaProductos;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardarProducto_Click(object sender, EventArgs e)
        {
            Producto nuevo = new Producto();

            nuevo.Codigo = textNombre.Text;
            nuevo.Nombre = textCodigo.Text;
            nuevo.Marca = textMarca.Text;
            nuevo.PrecioCompra = Convert.ToDecimal(textPrecioCompra.Text);
            nuevo.PrecioVenta = Convert.ToDecimal(textPrecioVenta.Text);
            nuevo.CantidadExistencia = Convert.ToInt32(textCantidad.Text);

            listaProductos.Add(nuevo);

            dataGridViewProductos.DataSource = null;
            dataGridViewProductos.DataSource = listaProductos;
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textCodigo.Text = dataGridViewProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                textNombre.Text = dataGridViewProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                textMarca.Text = dataGridViewProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                textPrecioCompra.Text = dataGridViewProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                textPrecioVenta.Text = dataGridViewProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                textCantidad.Text = dataGridViewProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void buttonActualizarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                int fila = dataGridViewProductos.CurrentRow.Index;

                listaProductos[fila].Codigo = textCodigo.Text;
                listaProductos[fila].Nombre = textNombre.Text;
                listaProductos[fila].Marca = textMarca.Text;
                listaProductos[fila].PrecioCompra = Convert.ToDecimal(textPrecioCompra.Text);
                listaProductos[fila].PrecioVenta = Convert.ToDecimal(textPrecioVenta.Text);
                listaProductos[fila].CantidadExistencia = Convert.ToInt32(textCantidad.Text);

                dataGridViewProductos.DataSource = null;
                dataGridViewProductos.DataSource = listaProductos;

                MessageBox.Show("Producto actualizado");
            }
            else
            {
                MessageBox.Show("Seleccione un producto primero");
            }
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
