using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace co.Tuya.Domain.Entities
{
    public class OrdenCompra
    {
        [Key]
        public int OrdenCompraId { get; set; }

        public int ProductoId { get; set; }

        public int ClienteId { get; set; }

        public int Cantidad { get; set; }

        public decimal Total { get; set; }

        public List<Producto> Productos { get; set; }

        public List<Cliente> Clientes { get; set; }
    }
}
