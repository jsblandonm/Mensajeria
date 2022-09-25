﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DroneOfTheFuture.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroDeTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaDeMensajeria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drieccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drones = table.Column<int>(type: "int", nullable: false),
                    NitEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoDrone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaDeMensajeria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDelPaquete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoDelPedido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuEncargadoId = table.Column<int>(type: "int", nullable: true),
                    SuCompradorId = table.Column<int>(type: "int", nullable: true),
                    SuEmpresaDeMensajeriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_Clientes_SuCompradorId",
                        column: x => x.SuCompradorId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_EmpresaDeMensajeria_SuEmpresaDeMensajeriaId",
                        column: x => x.SuEmpresaDeMensajeriaId,
                        principalTable: "EmpresaDeMensajeria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reporte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDelReporte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemperaturaDelaZona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoDrone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoPaquete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pedidosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reporte_Pedido_pedidosId",
                        column: x => x.pedidosId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Satisfacioncliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SusReportesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_Reporte_SusReportesId",
                        column: x => x.SusReportesId,
                        principalTable: "Reporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasLaboradas = table.Column<int>(type: "int", nullable: false),
                    SuEmpresaId = table.Column<int>(type: "int", nullable: true),
                    historicoId = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroDeTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleado_EmpresaDeMensajeria_SuEmpresaId",
                        column: x => x.SuEmpresaId,
                        principalTable: "EmpresaDeMensajeria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleado_Historicos_historicoId",
                        column: x => x.historicoId,
                        principalTable: "Historicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_historicoId",
                table: "Empleado",
                column: "historicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_SuEmpresaId",
                table: "Empleado",
                column: "SuEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_SusReportesId",
                table: "Historicos",
                column: "SusReportesId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_SuCompradorId",
                table: "Pedido",
                column: "SuCompradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_SuEmpresaDeMensajeriaId",
                table: "Pedido",
                column: "SuEmpresaDeMensajeriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_SuEncargadoId",
                table: "Pedido",
                column: "SuEncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reporte_pedidosId",
                table: "Reporte",
                column: "pedidosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Empleado_SuEncargadoId",
                table: "Pedido",
                column: "SuEncargadoId",
                principalTable: "Empleado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_EmpresaDeMensajeria_SuEmpresaId",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_EmpresaDeMensajeria_SuEmpresaDeMensajeriaId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Historicos_historicoId",
                table: "Empleado");

            migrationBuilder.DropTable(
                name: "EmpresaDeMensajeria");

            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "Reporte");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleado");
        }
    }
}
