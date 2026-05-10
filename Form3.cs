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
using System.IO;
using Newtonsoft.Json;

namespace ProyectoPuntodeVenta
{
    public partial class Form3 : Form
    {
        private List<Cliente> listaClientes = DatosSistema.listaClientes;
        private List<DetalleFactura> listaVenta = new List<DetalleFactura>();
        private int numeroFactura = 1;
        private decimal precioCompraProducto;
        private decimal precioVentaProducto;

        public Form3()
        {
            InitializeComponent();
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            bool encontrado = false;

            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].NIT == textNIT.Text)
                {
                    textNombreCliente.Text = listaClientes[i].Nombre;
                    textApellidoCliente.Text = listaClientes[i].Apellido;
                    textDireccionCliente.Text = listaClientes[i].Direccion;
                    textTelefonoCliente.Text = listaClientes[i].Telefono;

                    MessageBox.Show("Cliente encontrado");
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                MessageBox.Show("Cliente no encontrado, puede registrarlo");
            }
        }

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente();

            nuevo.NIT = textNIT.Text;
            nuevo.Nombre = textNombreCliente.Text;
            nuevo.Apellido = textApellidoCliente.Text;
            nuevo.Direccion = textDireccionCliente.Text;
            nuevo.Telefono = textTelefonoCliente.Text;

            DatosSistema.listaClientes.Add(nuevo);

            MessageBox.Show("Cliente guardado correctamente");
        }

        private void dataGridViewVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            string codigo = textCodigoProducto.Text;
            int cantidad = Convert.ToInt32(textCantidadVenta.Text);

            for (int i = 0; i < DatosSistema.listaProductos.Count; i++)
            {
                if (DatosSistema.listaProductos[i].Codigo == codigo)
                {
                    DetalleFactura nuevo = new DetalleFactura();

                    nuevo.CodigoProducto = codigo;
                    nuevo.Cantidad = cantidad;

                    nuevo.PrecioVenta = DatosSistema.listaProductos[i].PrecioVenta;
                    nuevo.PrecioCompra = DatosSistema.listaProductos[i].PrecioCompra;

                    listaVenta.Add(nuevo);

                    dataGridViewVenta.DataSource = null;
                    dataGridViewVenta.DataSource = listaVenta;

                    MessageBox.Show("Producto agregado");
                    return;
                }
            }

            MessageBox.Show("Producto no encontrado");
        }

        private void buttonGenerarFactura_Click(object sender, EventArgs e)
        {
            if (listaVenta.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta");
                return;
            }

            Factura nueva = new Factura();

            nueva.NumeroFactura = numeroFactura;
            nueva.NITCliente = textNIT.Text;
            nueva.FechaVenta = DateTime.Now;
            nueva.EstadoVenta = "Pendiente";

            for (int i = 0; i < listaVenta.Count; i++)
            {
                nueva.Detalles.Add(listaVenta[i]);
            }

            for (int i = 0; i < listaVenta.Count; i++)
            {
                for (int j = 0; j < DatosSistema.listaProductos.Count; j++)
                {
                    if (listaVenta[i].CodigoProducto == DatosSistema.listaProductos[j].Codigo)
                    {
                        DatosSistema.listaProductos[j].CantidadExistencia -= listaVenta[i].Cantidad;
                        break;
                    }
                }
            }

            DatosSistema.listaFacturas.Add(nueva);

            DatosSistema.GuardarFacturas();

            numeroFactura++;

            listaVenta.Clear();
            dataGridViewVenta.DataSource = null;

            textNIT.Clear();

            MessageBox.Show("Factura generada correctamente");
                }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
        }






