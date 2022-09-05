using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;

namespace DroneOfTheFuture.App.Persitencia
{
    public class APPCT : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Empleado> Empleados {get;set;}
        public DbSet<EmpresaMensajeria> EmpresaMensajerias {get;set;}
        public DbSet<Historico> Historicos {get;set;}
        public DbSet<Reportes> Reporte {get;set;}
        public DbSet<Pedidos> Pedido {get;set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DroneOfTheFuture-2");
            }
        }
    }
}