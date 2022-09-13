using System;
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
                    TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroDeTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasLaboradas = table.Column<int>(type: "int", nullable: false),
                    SuEmpresaId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroDeTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleados_EmpresaDeMensajeria_SuEmpresaId",
                        column: x => x.SuEmpresaId,
                        principalTable: "EmpresaDeMensajeria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClienteEmpleado",
                columns: table => new
                {
                    LosClientesId = table.Column<int>(type: "int", nullable: false),
                    empleadosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteEmpleado", x => new { x.LosClientesId, x.empleadosId });
                    table.ForeignKey(
                        name: "FK_ClienteEmpleado_Clientes_LosClientesId",
                        column: x => x.LosClientesId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteEmpleado_Empleados_empleadosId",
                        column: x => x.empleadosId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Pedido_Empleados_SuEncargadoId",
                        column: x => x.SuEncargadoId,
                        principalTable: "Empleados",
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
                    SusReportesId = table.Column<int>(type: "int", nullable: true),
                    SusEmpleadosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_Empleados_SusEmpleadosId",
                        column: x => x.SusEmpleadosId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Historicos_Reporte_SusReportesId",
                        column: x => x.SusReportesId,
                        principalTable: "Reporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteEmpleado_empleadosId",
                table: "ClienteEmpleado",
                column: "empleadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteId",
                table: "Clientes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_EmpleadoId",
                table: "Empleados",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SuEmpresaId",
                table: "Empleados",
                column: "SuEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_SusEmpleadosId",
                table: "Historicos",
                column: "SusEmpleadosId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteEmpleado");

            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "Reporte");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "EmpresaDeMensajeria");
        }
    }
}
