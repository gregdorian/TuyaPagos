
using co.Tuya.Domain.Core.Repositories;
using co.Tuya.Domain.Core.Services;
using co.Tuya.Domain.Entities;

namespace co.Tuya.Domain.Core
{
    public class LogisticaService : BaseService<Logistica>, ILogisticaService
    {
        private readonly ILogisticaRepository LogisticaRepository;


        public LogisticaService(ILogisticaRepository logisticaRepository) : base(logisticaRepository)
        {
            this.LogisticaRepository = logisticaRepository;
        }
    }
}