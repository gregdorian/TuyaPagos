

using co.Tuya.Domain.Core.Repositories;
using co.Tuya.Domain.Core.Services;
using co.Tuya.Domain.Entities;

namespace co.Tuya.Domain.Core
{
    public class ProductosService : BaseService<Producto>, IProductosService
    {
        private readonly IProductosRepository productsRepository;

        public ProductosService(IProductosRepository productsRepository) : base(productsRepository)
        {
            this.productsRepository = productsRepository;
        }
    }
}
