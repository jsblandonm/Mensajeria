using System;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;
using DroneOfTheFuture.App.Persitencia;

namespace DroneOfTheFuture.App.Consola
{
    class Program
    {
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
            // AddCliente();
            // AddEmpleado();
            // AddEmpresaMensajeria();
            // AddHistorico();
            // AddPedido();
            // AddReporte();
            obtenerPersona(1);
        }

        private static void AddPersona()
        {
            var persona = new Persona
            {
                Nombre = "Sebas",
                Apellidos = "Blandon",
                NumeroTelefono = "1053858423",
                Identificacion = "2555414",
                FechaNacimiento = new DateTime(1997, 07, 21),
            };
            _repoPersona.AddPersona(persona);
        }
        private static void AddCliente()
        {
            var cliente = new Cliente
            {
                TipoPersona = "Cliente",
                Direccion = "Calle Wallaby P.Sherman"
            };
            _repoCliente.AddCliente(cliente);
        }
        private static void AddEmpleado()
        {
            var empleado = new Empleado
            {
                TipoPersona = "Cliente",
                HorasLaboradas = 8
            };
            _repoEmpleado.AddEmpleado(empleado);
        }

        private static void AddEmpresaMensajeria()
        {
            var empresaMesajeria = new EmpresaMensajeria
            {
                NombreEmpresa = "Las Montañas del Ruis",
            };
            _repoEmpresaMensajeria.AddEmpresaMensajeria(empresaMesajeria);
        }

        private static void AddPedido()
        {
            var pedido = new Pedidos
            {
                Peso = 12,
            };
            _repoPedido.AddPedido(pedido);
        }

        private static void AddHistorico()
        {
            var historico = new Historico
            {
                Satisfacioncliente = "Mala"
            };
            _repoHistorico.AddHistorico(historico);
        }

        private static void AddReporte()
        {
            var reporte = new Reportes
            {
                Nombre = "Arroz Polludo",
            };
            _repoReporte.AddReportes(reporte);
        }
        private static void obtenerPersona(int idPersona)
        {
            var personaEncontrada = _repoPersona.GetPersona(idPersona);
            Console.WriteLine(personaEncontrada.Nombre + " " + personaEncontrada.Apellidos + " " + personaEncontrada.NumeroTelefono);
        }

        private static void obtenerCliente(int idCliente)
        {
            Console.WriteLine();
        }
    }
}
