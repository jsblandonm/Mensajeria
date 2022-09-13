using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;

namespace DroneOfTheFuture.App.Persistencia
{
    public class AppContexto : DbContext
    {
        // public DbSet<Persona> Personas {get;set;}
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Empleado> Empleados {get;set;}
        public DbSet<Mensajeria> EmpresaDeMensajeria {get;set;}
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
        // protected override void OnModelCreating(ModelBuilder modeloBuilder)
        // {
        //     // modeloBuilder.Entity<Nombre>()
        //     // .HasKey(b=>b.Id);
        //     //relacion uno a muchos
        //     // modeloBuilder.Entity<Mensajeria>()
        //     // .HasMany(b=>b.Empleados);
        //     // .WithOne(b=>b.Empleados);
        //     // modeloBuilder.Entity<Personas>()
        //     // .HasMany(b=>b.Empleado)
        //     // .WithMany(b=>b.Cliente);
        // }
    }
}