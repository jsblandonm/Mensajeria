using System;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DroneOfTheFuture.App.Consola
{
    class Program
    {
        // private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContexto());
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContexto());
        private static IRepositorioEmpleado _repoEmpleado = new RepositorioEmpleado(new Persistencia.AppContexto());
        private static IRepositorioPedido _repoPedido = new RepositorioPedidos(new Persistencia.AppContexto());
        private static IRepositorioHistorico _repoHistorico = new RepositorioHistorico(new Persistencia.AppContexto());
        private static IRepositorioReporte _repoReporte = new RepositorioReporte(new Persistencia.AppContexto());
        private static IRepositorioMensajeria _repoMensajeria = new RepositorioMensajeria(new Persistencia.AppContexto());


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddPersona();
            // AddCliente();
            // AddEmpleado();
            // AddMensajeria();
            // AddHistorico();
            // AddPedido();
            // AddReporte();
        }
        private static void AddPersona()
        {
            Collection<Cliente> losclientes = new Collection<Cliente>();
            // losclientes.Add(Cliente);
            Collection<Pedidos> lospedidos = new Collection<Pedidos>();
            // lospedidos.Add();
            var cliente = new Cliente
            {
                Nombre = "Sebas",
                Apellidos = "Blandon",
                FechaNacimiento = new DateTime(1997, 07, 21),
                NumeroDeTelefono = "320589485",
                Identificacion = "1053858423",
                TipoPersona = "Cliente",
                Direccion = "Calle Wallaby P.Sherman",
                Compras = lospedidos,
                // clientes = Cliente,
            };

            var mensajeria = new Mensajeria
            {
                NombreEmpresa = "Las Montañas del Ruis",
                Drieccion = "Cerca a las colinas",
                Drones = 69,
                NitEmpresa = "515415L",
                EstadoDrone = "En Servicio"
                // Empleados = SusEmpleados
            };
            var empleado = new Empleado
            {
                Nombre = "Robert",
                Apellidos = "Andres",
                FechaNacimiento = new DateTime(2000, 06, 01),
                NumeroDeTelefono = "3127592134",
                Identificacion = "1053823290",
                TipoPersona = "Empleado",
                HorasLaboradas = 8,
                SuEmpresa = mensajeria
            };
            Collection<Empleado> SusEmpleados = new Collection<Empleado>();
            SusEmpleados.Add(empleado);

            var compras = new Pedidos
            {
                NombreDelPaquete = "EL Delicius",
                Peso = 12,
                FechaCreacion = new DateTime(2022, 09, 03),
                EstadoDelPedido = "En Reparto",
                SuEncargado = empleado,
                SuComprador = cliente,
                SuEmpresaDeMensajeria = mensajeria
            };

            var reporte = new Reportes
            {
                NombreDelReporte = "Arroz Polludo",
                TemperaturaDelaZona = "25°C",
                EstadoDrone = "En Recarga",
                EstadoPaquete = "Entregado",
                Fecha = new DateTime(2022, 06, 09),
                pedidos = compras
            };

            var historico = new Historico
            {
                Satisfacioncliente = "Regular",
                SusReportes = reporte,
                SusEmpleados = empleado
            };
            _repoHistorico.AddHistorico(historico);
            _repoReporte.AddReportes(reporte);
            _repoMensajeria.AddMensajeria(mensajeria);
            _repoEmpleado.AddEmpleado(empleado);
            _repoPedido.AddPedido(compras);
            _repoCliente.AddCliente(cliente);
        }
        // private static void AddPersona()
        // {
        //     var persona = new Persona
        //     {
        //         Nombre = "lucas",
        //         Apellidos = "Rodriguez",
        //         NumeroTelefono = "1",
        //         Identificacion = "25",
        //         FechaNacimiento = new DateTime(1800, 02, 04),
        //     };
        //     _repoPersona.AddPersona(persona);
        // }

        // private static void AddPedido()
        // {
        //     var compras = new Pedidos
        //     {
        //         NombreDelPaquete = "EL Delicius",
        //         Peso = 12,
        //         FechaCreacion = new DateTime(2022, 09, 03),
        //         EstadoDelPedido = "Revisando",
        //     };
        // }
        // private static void AddEmpleado()
        // {
        //     var empleado = new Empleado
        //     {
        //         Nombre = "Robert",
        //         Apellidos = "Andres",
        //         NumeroTelefono = "25",
        //         Identificacion = "454",
        //         FechaNacimiento = new DateTime(2000, 06, 01),
        //         TipoPersona = "Empleado",
        //         HorasLaboradas = 8
        //     };
        //     _repoEmpleado.AddEmpleado(empleado);
        // }

        // private static void AddHistorico()
        // {

        // }
        // private static void AddReporte()
        // {

        // }
        // private static void obtenerCliente(int idCliente)
        // {
        //     var clienteEncontrado = _repoCliente.GetCliente(idCliente);
        //     Console.WriteLine(clienteEncontrado.Nombre + " " + clienteEncontrado.Apellidos + " " + clienteEncontrado.NumeroTelefono);
        // }
        // private static void obtenerEmpleado(int idEmpleado)
        // {
        //     var obtenerEmpleado = _repoEmpleado.GetEmpleado(idEmpleado);
        //     Console.WriteLine(obtenerEmpleado.Nombre + " " + obtenerEmpleado.Apellidos + " " + obtenerEmpleado.NumeroTelefono);
    }
}

