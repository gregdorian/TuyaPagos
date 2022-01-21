using Microsoft.EntityFrameworkCore;
using co.Tuya.Domain.Entities;

namespace co.Tuya.Infrastructure.Data.Model
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder model)
        {

            model.Entity<Producto>().HasData(
                   new Producto { produtoId=1,Descripcion = "Mouse", Precio = 3500 },
                   new Producto { produtoId=2,Descripcion = "Teclado", Precio = 50500 },
                   new Producto { produtoId=3, Descripcion = "Pantalla", Precio = 605000 },
                   new Producto { produtoId=4, Descripcion = "Tablet", Precio = 32500 });

            model.Entity<Cliente>().HasData(
                   new Cliente { clienteId = 1, Nombres = "Carlos", Apellidos = "Muñoz", Telefono = "34654612", Ciudad = "Barbosa", Direccion = "cra 35 #100-00" },
                   new Cliente { clienteId = 2, Nombres = "Andres", Apellidos = "Lara", Telefono = "4657712", Ciudad = "Itagui", Direccion = " clle 54 #40-00" },
                   new Cliente { clienteId = 3, Nombres = "Pablo", Apellidos = "Lopez", Telefono = "35488820", Ciudad = "Envigado", Direccion = " cra 34 #50-00" },
                   new Cliente { clienteId = 4, Nombres = "Ana", Apellidos = "Ruiz", Telefono = "65444777", Ciudad = "Medellin", Direccion = " cra 25 #84-00" });

            model.Entity<Logistica>().HasData(
                  new Logistica { LogisticaId=1,  NombreCompañia = "Carlos", Telefono = "46134652", Direccion = "cra 50 #100-00" },
                  new Logistica { LogisticaId=2, NombreCompañia = "Andres", Telefono = "5746712", Direccion = " clle 4 #40-00" },
                  new Logistica { LogisticaId=3, NombreCompañia = "Pablo", Telefono = "35884820", Direccion = " cra 45 #50-00" },
                  new Logistica { LogisticaId=4, NombreCompañia = "Ana", Telefono = "44765477", Direccion = " cra 25 #84-00" });

        }
    }
}
