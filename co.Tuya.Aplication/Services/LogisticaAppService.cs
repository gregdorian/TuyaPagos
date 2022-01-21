using co.Tuya.Aplication.Interfaces;
using co.Tuya.Domain.Core.Services;
using co.Tuya.Domain.Entities;


namespace co.Tuya.Aplication.Services
{
    public class LogisticaAppService : BaseAppService<Logistica>, ILogisticaAppService
    {
        private readonly ILogisticaService LogisticaService;


        public LogisticaAppService(ILogisticaService logisticaService) : base(logisticaService)
        {
            this.LogisticaService = logisticaService;
        }
    }
}