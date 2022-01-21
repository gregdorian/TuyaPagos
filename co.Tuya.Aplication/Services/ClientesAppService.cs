using co.Tuya.Aplication.Interfaces;
using co.Tuya.Domain.Core.Services;
using co.Tuya.Domain.Entities;


namespace co.Tuya.Aplication.Services
{
    public class ClientesAppService : BaseAppService<Cliente>, IClientesAppService
    {
        private readonly IClientesService ClientesService;

        public ClientesAppService(IClientesService clientesService) : base(clientesService)
        {
            this.ClientesService = clientesService;
        }
    }
}