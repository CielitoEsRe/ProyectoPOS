using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuntodeVenta.Models
{
    public class Factura
    {
        public int NumeroFactura { get; set; }
        public string NITCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public string EstadoVenta { get; set; }
      
        public List<DetalleFactura> Detalles { get; set; }

        public Factura()
        {
            Detalles = new List<DetalleFactura>();
        }
    }
}
