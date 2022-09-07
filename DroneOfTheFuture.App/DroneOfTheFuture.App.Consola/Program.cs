using System;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;
using DroneOfTheFuture.App.Persitencia;

namespace DroneOfTheFuture.App.Consola
{
    class Program
    {
        // private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persitencia.APPCT());

        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persitencia.APPCT());
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persitencia.APPCT());
        private static IRepositorioEmpleado _repoEmpleado = new RepositorioEmpleado(new Persitencia.APPCT());
        private static IRepositorioPedido _repoPedido = new RepositorioPedidos(new Persitencia.APPCT());
        private static IRepositorioHistorico _repoHistorico = new RepositorioHistorico(new Persitencia.APPCT());
        private static IRepositorioReporte _repoReporte = new RepositorioReporte(new Persitencia.APPCT());
        private static IRepositorioEmpresaMensajeria _repoEmpresaMensajeria = new RepositorioEmpresaMensajeria(new Persitencia.APPCT());


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // AddPersona();
            AddCliente();
            AddEmpleado();
            AddEmpresaMensajeria();
            AddHistorico();
            AddPedido();
            AddReporte();

            // obtenerPersona(1);
            // obtenerCliente(1);
            // obtenerEmpleado(2);
            // obtenerPersona(1);
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
        private static void AddCliente()
        {
            var cliente = new Cliente
            {
                Nombre = "Sebas",
                Apellidos = "Blandon",
                NumeroTelefono = "1053858423",
                Identificacion = "2555414",
                FechaNacimiento = new DateTime(1997, 07, 21),

                TipoPersona = "Cliente",
                Direccion = "Calle Wallaby P.Sherman"
            };
            _repoCliente.AddCliente(cliente);
        }
        private static void AddEmpleado()
        {
            var empleado = new Empleado
            {
                Nombre = "Robert",
                Apellidos = "Andres",
                NumeroTelefono = "25",
                Identificacion = "454",
                FechaNacimiento = new DateTime(2000, 06, 01),
                TipoPersona = "Empleado",
                HorasLaboradas = 8
            };
            _repoEmpleado.AddEmpleado(empleado);
        }

        private static void AddHistorico()
        {
            var historico = new Historico
            {
                Satisfacioncliente = "Mala"
            };
            _repoHistorico.AddHistorico(historico);
        }
        private static void AddEmpresaMensajeria()
        {
            var empresaMesajeria = new EmpresaMensajeria
            {
                NombreEmpresa = "Las Montañas del Ruis",
                Drieccion = "Cerca a las colinas",
                Drones = 69,
                NitEmpresa = "515415L",
            };
            _repoEmpresaMensajeria.AddEmpresaMensajeria(empresaMesajeria);
        }
        private static void AddPedido()
        {
            var pedido = new Pedidos
            {
                NombrePaquete = "EL Delicius",
                Peso = 12,
                FechaCreacion = new DateTime(2022, 09, 03),
                EstadoEmpleado = "Revisando"
            };
            _repoPedido.AddPedido(pedido);
        }

        private static void AddReporte()
        {
            var reporte = new Reportes
            {
                Nombre = "Arroz Polludo",
                Temperatura = "25°C",
                EstadoDrone = "En Servicio",
                EstadoPaquete = "En Reparto",
                Fecha = new DateTime(2022, 06, 09)
            };
            _repoReporte.AddReportes(reporte);
        }
        private static void obtenerCliente(int idCliente)
        {
            var clienteEncontrado = _repoCliente.GetCliente(idCliente);
            Console.WriteLine(clienteEncontrado.Nombre + " " + clienteEncontrado.Apellidos + " " + clienteEncontrado.NumeroTelefono);
        }
        private static void obtenerEmpleado(int idEmpleado)
        {
            var obtenerEmpleado = _repoEmpleado.GetEmpleado(idEmpleado);
            Console.WriteLine(obtenerEmpleado.Nombre + " " + obtenerEmpleado.Apellidos + " " + obtenerEmpleado.NumeroTelefono);
        }

        // public static void SearchEnvio()
        // {
        //     Random rand = new Random();
        //     int idPedido = rand.Next(0, 10);
        //     Pedidos pedidos = _repoPedido.ReadPedidos(idPedido);
        // }
    }
}
