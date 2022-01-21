using System.ComponentModel.DataAnnotations;

namespace co.Tuya.Domain.Entities
{
    public class Producto
    {
        [Key]
        public int produtoId { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }
    }
}
