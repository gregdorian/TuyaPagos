using co.Tuya.Aplication.Interfaces;
using co.Tuya.Domain.Core.Services;
using co.Tuya.Domain.Entities;
using System.Collections.Generic;

namespace co.Tuya.Aplication.Services
{

    public class OrdenCompraAppService : BaseAppService<OrdenCompra>, IOrdenCompraAppService
    {
        private readonly IOrdenCompraAppService OrdenCompraService;

        public OrdenCompraAppService(IOrdenCompraService ordenCompraService) : base(ordenCompraService)
        {
            //this.OrdenCompraService = ordenCompraService;

        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Producto> GetAllProductos()
        {
            throw new System.NotImplementedException();
        }
    }
}