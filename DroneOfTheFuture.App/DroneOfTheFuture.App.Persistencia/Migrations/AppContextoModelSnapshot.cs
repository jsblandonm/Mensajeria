﻿// <auto-generated />
using System;
using DroneOfTheFuture.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DroneOfTheFuture.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContexto))]
    partial class AppContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDeTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("HorasLaboradas")
                        .HasColumnType("int");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MensajeriaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDeTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("historicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MensajeriaId");

                    b.HasIndex("historicoId");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Historico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Satisfacioncliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SusReportesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SusReportesId");

                    b.ToTable("Historicos");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Mensajeria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Drieccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Drones")
                        .HasColumnType("int");

                    b.Property<string>("EstadoDrone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NitEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mensajeria");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Pedidos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EstadoDelPedido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MensajeriaId")
                        .HasColumnType("int");

                    b.Property<string>("NombreDelPaquete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<int?>("SuCompradorId")
                        .HasColumnType("int");

                    b.Property<int?>("SuEncargadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MensajeriaId");

                    b.HasIndex("SuCompradorId");

                    b.HasIndex("SuEncargadoId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Reportes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EstadoDrone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoPaquete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreDelReporte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemperaturaDelaZona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("pedidosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("pedidosId");

                    b.ToTable("Reporte");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Empleado", b =>
                {
                    b.HasOne("DroneOfTheFuture.App.Dominio.Mensajeria", "SuEmpresa")
                        .WithMany("Empleados")
                        .HasForeignKey("MensajeriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DroneOfTheFuture.App.Dominio.Historico", "historico")
                        .WithMany()
                        .HasForeignKey("historicoId");

                    b.Navigation("historico");

                    b.Navigation("SuEmpresa");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Historico", b =>
                {
                    b.HasOne("DroneOfTheFuture.App.Dominio.Reportes", "SusReportes")
                        .WithMany()
                        .HasForeignKey("SusReportesId");

                    b.Navigation("SusReportes");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Pedidos", b =>
                {
                    b.HasOne("DroneOfTheFuture.App.Dominio.Mensajeria", "Mensajeria")
                        .WithMany()
                        .HasForeignKey("MensajeriaId");

                    b.HasOne("DroneOfTheFuture.App.Dominio.Cliente", "SuComprador")
                        .WithMany("Compras")
                        .HasForeignKey("SuCompradorId");

                    b.HasOne("DroneOfTheFuture.App.Dominio.Empleado", "SuEncargado")
                        .WithMany("losPedidos")
                        .HasForeignKey("SuEncargadoId");

                    b.Navigation("Mensajeria");

                    b.Navigation("SuComprador");

                    b.Navigation("SuEncargado");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Reportes", b =>
                {
                    b.HasOne("DroneOfTheFuture.App.Dominio.Pedidos", "pedidos")
                        .WithMany()
                        .HasForeignKey("pedidosId");

                    b.Navigation("pedidos");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Cliente", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Empleado", b =>
                {
                    b.Navigation("losPedidos");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Mensajeria", b =>
                {
                    b.Navigation("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
