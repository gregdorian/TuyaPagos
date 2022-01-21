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
    public class ProductosController : ControllerBase
    {
        private readonly IProductosAppService ProductFactory;

        private readonly ILogger<ProductosController> _logger;
        public ProductosController(IProductosAppService productFactory,
                                  ILogger<ProductosController> logger)
        {
            this.ProductFactory = productFactory;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        // GET: api/<ProductosController>
        [HttpGet]
        //[Authorize(Roles = "Administrator, RegularUser")]
        public IEnumerable<Producto> GetAll()
        {
            //if (User.Identity.IsAuthenticated)
            //{

            var lstProducts = ProductFactory.GetAll();

            _logger.LogInformation($"Productos Listados: ");

            return lstProducts;
            //}
            //else
            //   return null;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        //[Authorize(Roles = "Administrator, RegularUser")]
        public ActionResult<Producto> Get(int id)
        {
            var product = ProductFactory.GetById(id);

            if (product == null)
            {
                _logger.LogError("No se encontro Datos");
                return NotFound();
            }
            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Administrator")]
        public void Post([FromBody] Producto value)
        {
            if (value != null)
            {
                ProductFactory.Add(value);
                _logger.LogInformation("Datos Guardados!!!");
            }
            else
            {
                _logger.LogError("No se encontro Datos");
            }
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Administrator")]
        public void Put(int id, [FromBody] Producto value)
        {
            var prod = ProductFactory.GetById(id);
            if (prod != null)
            {
                ProductFactory.Modify(value);
                _logger.LogInformation("Datos Modificados y Guardados!!!");
            }
            else
            {
                _logger.LogError("No Data found");
            }
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        //[Authorize(Roles = "Administrator")]
        public void Delete(int id)
        {
            ProductFactory.Delete(id);
            _logger.LogInformation("Data Deleted");
        }
    }
}
