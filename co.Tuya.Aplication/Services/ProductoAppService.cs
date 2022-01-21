using co.Tuya.Aplication.Interfaces;
using co.Tuya.Domain.Core.Services;
using co.Tuya.Domain.Entities;


namespace co.Tuya.Aplication.Services
{
    public class ProductAppService : BaseAppService<Producto>, IProductosAppService
    {
        private readonly IProductosService ProductsService;

        public ProductAppService(IProductosService productosService) : base(productosService)
        {
            this.ProductsService = productosService;
        }
    }
}
