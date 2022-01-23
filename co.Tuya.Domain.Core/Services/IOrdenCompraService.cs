using co.Tuya.Domain.Entities;
using System.Collections.Generic;

namespace co.Tuya.Domain.Core.Services
{

    public interface IOrdenCompraService : IBaseService<OrdenCompra>
    {

        public IEnumerable<Cliente> GetAllClientes();

        public IEnumerable<Producto> GetAllProductos();
    }
}
