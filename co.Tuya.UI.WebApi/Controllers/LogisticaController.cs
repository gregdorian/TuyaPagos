using co.Tuya.Aplication.Interfaces;
using co.Tuya.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co.Tuya.UI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogisticaController : ControllerBase
    {
        private readonly ILogisticaAppService LogisticaFactory;

        private readonly ILogger<LogisticaController> _logger;

        public LogisticaController(ILogisticaAppService logisticaFactory,
                                  ILogger<LogisticaController> logger)
        {
            this.LogisticaFactory = logisticaFactory;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: api/<LogisticaController>
        [HttpGet]
        public IEnumerable<Logistica> GetAll()
        {
            var lstLogistica = LogisticaFactory.GetAll();

            _logger.LogInformation($"Logistica Listados: ");

            return lstLogistica;
        }

        // GET api/<LogisticaController>/5
        [HttpGet("{id}")]
        public ActionResult<Logistica> Get(int id)
        {
            var Logistica = LogisticaFactory.GetById(id);

            if (Logistica == null)
            {
                _logger.LogError("No se encontro Datos");
                return NotFound();
            }
            return Ok(Logistica);
        }
    }
}
