using System.ComponentModel.DataAnnotations;

namespace co.Tuya.Domain.Entities
{
    public class Logistica
    {
        [Key]
        public int LogisticaId { get; set; }

        public string NombreCompañia { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }
    }
}
