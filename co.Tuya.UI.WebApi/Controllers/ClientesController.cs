using co.Tuya.Aplication.Interfaces;
using co.Tuya.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace co.Tuya.UI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        private readonly IClientesAppService ClientesFactory;

        private readonly ILogger<ClientesController> _logger;


        public ClientesController(IClientesAppService clientesFactory,
                                  ILogger<ClientesController> logger)
        {
            this.ClientesFactory = clientesFactory;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: api/<ClientesController>
        [HttpGet]
        public IEnumerable<Cliente> GetAll()
        {
            var lstClientes = ClientesFactory.GetAll();

            _logger.LogInformation($"Clientes Listados: ");

            return lstClientes;
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(int id)
        {
            var cliente = ClientesFactory.GetById(id);

            if (cliente == null)
            {
                _logger.LogError("No se encontro Datos");
                return NotFound();
            }
            return Ok(cliente);
        }

        // POST api/<ClientesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
