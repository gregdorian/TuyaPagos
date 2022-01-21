
using co.Tuya.Domain.Core.Repositories;
using co.Tuya.Domain.Core.Services;
using co.Tuya.Domain.Entities;

namespace co.Tuya.Domain.Core
{
    public class ClientesService : BaseService<Cliente>, IClientesService
    {
        private readonly IClientesRepository ClientesRepository;


        public ClientesService(IClientesRepository clientesRepository) : base(clientesRepository)
        {
            this.ClientesRepository = clientesRepository;
        }
    }
}