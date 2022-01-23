using co.Tuya.Domain.Core.Repositories;
using co.Tuya.Domain.Entities;
using co.Tuya.Infrastructure.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace co.Tuya.Infrastructure.Data.Repositories
{


    public class OrdenCompraRepository : BaseRepository<OrdenCompra>, IOrdenCompraRepository
    {


        public static IEnumerable<Cliente> GetAllClientes()
        {
            try
            {
                using (var context = new TuyaContext())
                {
                    return context.Set<Cliente>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron recuperar los registros", ex);
            }
        }


        public static IEnumerable<Producto> GetAllProductos()
        {
            try
            {
                using (var context = new TuyaContext())
                {
                    return context.Set<Producto>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron recuperar los registros", ex);
            }
        }
    }
}
