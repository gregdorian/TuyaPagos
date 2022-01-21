using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using co.Tuya.Domain.Entities;
using System;
using System.IO;

namespace co.Tuya.Infrastructure.Data.Model
{
    public partial class TuyaContext : DbContext
    {
        public TuyaContext()
        {

        }

        public TuyaContext(DbContextOptions<TuyaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<CarritoCompra> CarritoCompras { get; set; }
        public virtual DbSet<Logistica> Logisticas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //**** Solo para Realizarel Primer Initial-Migration  ****
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=tuyaDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }
    }
}
