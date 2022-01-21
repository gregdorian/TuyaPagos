using System.ComponentModel.DataAnnotations;

namespace co.Tuya.Domain.Entities
{
    public class Cliente
    {
        [Key]
        public int clienteId { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0}, {1}", Apellidos, this.Nombres);
            }
            set { }

        }
        public string Telefono { get; set; }

        public string Direccion{ get; set; }

        public string Ciudad { get; set; }
    }
}
