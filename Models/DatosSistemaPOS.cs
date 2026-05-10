using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoPuntodeVenta.Models
{
    public static class DatosSistema
    {
        public static List<Producto> listaProductos = new List<Producto>();
        public static List<Factura> listaFacturas = new List<Factura>();
        public static List<Cliente> listaClientes = new List<Cliente>();

        public static void GuardarFacturas()
        {
            string json = JsonConvert.SerializeObject(listaFacturas, Formatting.Indented);
            File.WriteAllText("facturas.json", json);
        }
    }
}

