using System.ComponentModel.DataAnnotations;

namespace co.Tuya.Domain.Entities
{
    public class CarritoCompra
    {
        [Key]
        public int CarritoCompraId { get; set; }

        public int ProductoId { get; set; }

        public int Cantidad { get; set; }

        public decimal Total { get; set; }
    }
}
