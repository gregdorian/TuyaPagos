using co.Tuya.Domain.Entities;
using System.Collections.Generic;

namespace co.Tuya.Aplication.Interfaces
{
    public interface IOrdenCompraAppService : IBaseAppService<OrdenCompra>
    {
        public IEnumerable<Cliente> GetAllClientes();

        public IEnumerable<Producto> GetAllProductos();
    }
}
