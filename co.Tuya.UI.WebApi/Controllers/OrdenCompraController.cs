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
    public class OrdenCompraController : ControllerBase
    {

        private readonly IOrdenCompraAppService OrdencompraFactory;

        private readonly ILogger<ClientesController> _logger;

        public OrdenCompraController(IOrdenCompraAppService OrdenCompraFactory,
                                   ILogger<ClientesController> logger)
        { 
             this.OrdencompraFactory = OrdenCompraFactory;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: api/<OrdenCompraController>
        [HttpGet]
        public IEnumerable<OrdenCompra> GetAll()
        {
            var lstOrdenesCompra = OrdencompraFactory.GetAll();

            _logger.LogInformation($"OrdenesCompra Listados: ");

            return lstOrdenesCompra;
        }

        // GET api/<OrdenCompraController>/5
        [HttpGet("{id}")]
        public ActionResult<OrdenCompra> Get(int id)
        {
            var ordenCompra = OrdencompraFactory.GetById(id);

            if (ordenCompra == null)
            {
                _logger.LogError("No se encontro Datos");
                return NotFound();
            }
            return Ok(ordenCompra);
        }

        // POST api/<OrdenCompraController>
        [HttpPost]
        public void Post([FromBody] OrdenCompra value)
        {
            if (value != null)
            {
                OrdencompraFactory.Add(value);
                _logger.LogInformation("Datos Guardados!!!");
            }
            else
            {
                _logger.LogError("No se encontro Datos");
            }
        }

        // PUT api/<OrdenCompraController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrdenCompra value)
        {
            var prod = OrdencompraFactory.GetById(id);
            if (prod != null)
            {
                OrdencompraFactory.Modify(value);
                _logger.LogInformation("Datos Modificados y Guardados!!!");
            }
            else
            {
                _logger.LogError("No Data found");
            }
        }

        // DELETE api/<OrdenCompraController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            OrdencompraFactory.Delete(id);// TODO If id not null Validations!! todos los controllers
            _logger.LogInformation("Data Deleted");
        }
    }
}
