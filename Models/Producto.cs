using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuntodeVenta.Models
{
     public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int CantidadExistencia { get; set; }
    }
}
