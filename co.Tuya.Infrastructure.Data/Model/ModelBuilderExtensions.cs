using Microsoft.EntityFrameworkCore;
using co.Tuya.Domain.Entities;

namespace co.Tuya.Infrastructure.Data.Model
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder model)
        {

            model.Entity<Producto>().HasData(
                   new Producto { Descripcion = "Mouse", Precio = 3500 },
                   new Producto { Descripcion = "Teclado", Precio = 50500 },
                   new Producto { Descripcion = "Pantalla", Precio = 605000 },
                   new Producto { Descripcion = "Tablet", Precio = 32500 });

            model.Entity<Cliente>().HasData(
                   new Cliente { Nombres = "Carlos", Apellidos="Muñoz", Telefono="34654612", Ciudad ="Barbosa", Direccion = "cra 35 #100-00" },
                   new Cliente { Nombres = "Andres",  Apellidos="Lara", Telefono = "4657712", Ciudad = "Itagui", Direccion = " clle 54 #40-00" },
                   new Cliente { Nombres = "Pablo", Apellidos="Lopez", Telefono = "35488820", Ciudad = "Envigado", Direccion = " cra 34 #50-00" },
                   new Cliente { Nombres = "Ana",   Apellidos = "Ruiz", Telefono = "65444777", Ciudad = "Medellin", Direccion = " cra 25 #84-00" });

            model.Entity<Logistica>().HasData(
                  new Logistica { NombreCompañia = "Carlos", Telefono = "46134652", Direccion = "cra 50 #100-00" },
                  new Logistica { NombreCompañia = "Andres", Telefono = "5746712", Direccion = " clle 4 #40-00" },
                  new Logistica { NombreCompañia = "Pablo", Telefono = "35884820", Direccion = " cra 45 #50-00" },
                  new Logistica { NombreCompañia = "Ana", Telefono = "44765477", Direccion = " cra 25 #84-00" });

        }
    }
}
