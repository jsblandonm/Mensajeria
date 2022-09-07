﻿// <auto-generated />
using System;
using DroneOfTheFuture.App.Persitencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DroneOfTheFuture.App.Persistencia.Migrations
{
    [DbContext(typeof(APPCT))]
<<<<<<<< HEAD:DroneOfTheFuture.App/DroneOfTheFuture.App.Persistencia/Migrations/20220906011831_Inicial.Designer.cs
    [Migration("20220906011831_Inicial")]
========
    [Migration("20220905175005_Inicial")]
>>>>>>>> 82f0319ae87c0f74a52d72163b39d34fa0894bc7:DroneOfTheFuture.App/DroneOfTheFuture.App.Persistencia/Migrations/20220905175005_Inicial.Designer.cs
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.EmpresaMensajeria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Drieccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Drones")
                        .HasColumnType("int");

                    b.Property<string>("NitEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmpresaMensajerias");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Historico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EmpleadosId")
                        .HasColumnType("int");

                    b.Property<int?>("ReportesId")
                        .HasColumnType("int");

                    b.Property<string>("Satisfacioncliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadosId");

                    b.HasIndex("ReportesId");

                    b.ToTable("Historicos");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Pedidos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadosId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpresaMensajeriaId")
                        .HasColumnType("int");

                    b.Property<string>("EstadoEmpleado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombrePaquete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EmpleadosId");

                    b.HasIndex("EmpresaMensajeriaId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
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

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("pedidosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("pedidosId");

                    b.ToTable("Reporte");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Cliente", b =>
                {
                    b.HasBaseType("DroneOfTheFuture.App.Dominio.Persona");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoPersona")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cliente_TipoPersona");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Empleado", b =>
                {
                    b.HasBaseType("DroneOfTheFuture.App.Dominio.Persona");

                    b.Property<int?>("EmpresaMensajeriaId")
                        .HasColumnType("int");

                    b.Property<int>("HorasLaboradas")
                        .HasColumnType("int");

                    b.Property<string>("TipoPersona")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("EmpresaMensajeriaId");

                    b.HasDiscriminator().HasValue("Empleado");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Historico", b =>
                {
                    b.HasOne("DroneOfTheFuture.App.Dominio.Empleado", "Empleados")
                        .WithMany()
                        .HasForeignKey("EmpleadosId");

                    b.HasOne("DroneOfTheFuture.App.Dominio.Reportes", "Reportes")
                        .WithMany()
                        .HasForeignKey("ReportesId");

                    b.Navigation("Empleados");

                    b.Navigation("Reportes");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Pedidos", b =>
                {
                    b.HasOne("DroneOfTheFuture.App.Dominio.Cliente", "Cliente")
                        .WithMany("Compras")
                        .HasForeignKey("ClienteId");

                    b.HasOne("DroneOfTheFuture.App.Dominio.Empleado", "Empleados")
                        .WithMany()
                        .HasForeignKey("EmpleadosId");

                    b.HasOne("DroneOfTheFuture.App.Dominio.EmpresaMensajeria", "EmpresaMensajeria")
                        .WithMany()
                        .HasForeignKey("EmpresaMensajeriaId");

                    b.Navigation("Cliente");

                    b.Navigation("Empleados");

                    b.Navigation("EmpresaMensajeria");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Reportes", b =>
                {
                    b.HasOne("DroneOfTheFuture.App.Dominio.Pedidos", "pedidos")
                        .WithMany()
                        .HasForeignKey("pedidosId");

                    b.Navigation("pedidos");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Empleado", b =>
                {
                    b.HasOne("DroneOfTheFuture.App.Dominio.EmpresaMensajeria", null)
                        .WithMany("Empleados")
                        .HasForeignKey("EmpresaMensajeriaId");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.EmpresaMensajeria", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("DroneOfTheFuture.App.Dominio.Cliente", b =>
                {
                    b.Navigation("Compras");
                });
#pragma warning restore 612, 618
        }
    }
}
