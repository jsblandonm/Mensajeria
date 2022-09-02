using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DroneOfTheFuture.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpresaMensajerias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drieccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drones = table.Column<int>(type: "int", nullable: false),
                    NitEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaMensajerias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliente_TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasLaboradas = table.Column<int>(type: "int", nullable: true),
                    EmpresaMensajeriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_EmpresaMensajerias_EmpresaMensajeriaId",
                        column: x => x.EmpresaMensajeriaId,
                        principalTable: "EmpresaMensajerias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePaquete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadosId = table.Column<int>(type: "int", nullable: true),
                    ClientesId = table.Column<int>(type: "int", nullable: true),
                    EmpresaMensajeriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_EmpresaMensajerias_EmpresaMensajeriaId",
                        column: x => x.EmpresaMensajeriaId,
                        principalTable: "EmpresaMensajerias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Personas_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_Personas_EmpleadosId",
                        column: x => x.EmpleadosId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reporte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperatura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoDrone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoPaquete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feha = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    ReportesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_Reporte_ReportesId",
                        column: x => x.ReportesId,
                        principalTable: "Reporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_ReportesId",
                table: "Historicos",
                column: "ReportesId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClientesId",
                table: "Pedido",
                column: "ClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_EmpleadosId",
                table: "Pedido",
                column: "EmpleadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_EmpresaMensajeriaId",
                table: "Pedido",
                column: "EmpresaMensajeriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EmpresaMensajeriaId",
                table: "Personas",
                column: "EmpresaMensajeriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reporte_pedidosId",
                table: "Reporte",
                column: "pedidosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "Reporte");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "EmpresaMensajerias");
        }
    }
}
