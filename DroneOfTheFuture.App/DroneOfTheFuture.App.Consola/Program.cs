using System;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DroneOfTheFuture.App.Consola
{
    class Program
    {
<<<<<<< HEAD
        // private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContexto());
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContexto());
        private static IRepositorioEmpleado _repoEmpleado = new RepositorioEmpleado(new Persistencia.AppContexto());
        private static IRepositorioPedido _repoPedido = new RepositorioPedidos(new Persistencia.AppContexto());
        private static IRepositorioHistorico _repoHistorico = new RepositorioHistorico(new Persistencia.AppContexto());
        private static IRepositorioReporte _repoReporte = new RepositorioReporte(new Persistencia.AppContexto());
        private static IRepositorioMensajeria _repoMensajeria = new RepositorioMensajeria(new Persistencia.AppContexto());
=======
        // private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persitencia.APPCT());
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persitencia.APPCT());
        private static IRepositorioEmpleado _repoEmpleado = new RepositorioEmpleado(new Persitencia.APPCT());
        private static IRepositorioPedido _repoPedido = new RepositorioPedidos(new Persitencia.APPCT());
        private static IRepositorioHistorico _repoHistorico = new RepositorioHistorico(new Persitencia.APPCT());
        private static IRepositorioReporte _repoReporte = new RepositorioReporte(new Persitencia.APPCT());
        private static IRepositorioEmpresaMensajeria _repoEmpresaMensajeria = new RepositorioEmpresaMensajeria(new Persitencia.APPCT());
>>>>>>> 18b9cac3539ee569ac6073039bbabfd5195364ee


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // AddPersona();
            // AddPersonaNueva();
            // AddCliente();
            // AddEmpleado();
            // AddMensajeria();
            // AddHistorico();
            // AddPedido();
            // AddReporte();
<<<<<<< HEAD
        }
        private static void AddPersona()
        {
            Collection<Pedidos> lospedidos = new Collection<Pedidos>();
            var cliente = new Cliente
            {
                Nombre = "Alison",
                Apellidos = "Sandino",
                FechaNacimiento = new DateTime(1997, 07, 21, 12, 25, 0),
                NumeroDeTelefono = "31515325",
                Identificacion = "10584354",
                TipoPersona = "Compradora compulsiva",
                Direccion = "Guanuajato",
                Compras = lospedidos,
                // Compras = new Collection<Pedidos> {
                //     new Pedidos{
                //         NombreDelPaquete = "Ropa",
                //         Peso = 15,
                //         FechaCreacion = new DateTime(2022, 09, 03,12,24,25),
                //         EstadoDelPedido = "En ditribucion",
                //         // SuEncargado = empleado,
                //         // SuComprador = cliente,
                //         // SuEmpresaDeMensajeria = mensajeria
                //     }
                // },
                
=======
            // obtenerPersona(1);
            // obtenerCliente(1);
            // obtenerEmpleado(2);

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
>>>>>>> 18b9cac3539ee569ac6073039bbabfd5195364ee
            };

            _repoCliente.AddCliente(cliente);

            var empleado = new Empleado
            {
<<<<<<< HEAD
                Nombre = "Robinson",
                Apellidos = "Roberto",
                FechaNacimiento = new DateTime(2000, 06, 01, 08, 22, 29),
                NumeroDeTelefono = "14514",
                Identificacion = "10",
                TipoPersona = "Empleado",
                HorasLaboradas = 19,
=======
                Nombre = "Robert",
                Apellidos = "Andres",
                NumeroTelefono = "25",
                Identificacion = "454",
                FechaNacimiento = new DateTime(2000, 06, 01),
                TipoPersona = "Empleado",
                HorasLaboradas = 8
>>>>>>> 18b9cac3539ee569ac6073039bbabfd5195364ee
            };
            // _repoEmpleado.AddEmpleado(empleado);

            Collection<Empleado> SusEmpleados = new Collection<Empleado>();
            SusEmpleados.Add(empleado);

            var mensajeria = new Mensajeria
            {
<<<<<<< HEAD
                NombreEmpresa = "Instatime",
                Drieccion = "Cerca a als nubes",
                Drones = 69,
                NitEmpresa = "5151A",
                EstadoDrone = "En Servicio",
                Empleados = SusEmpleados
=======
                NombreEmpresa = "Las Montañas del Ruis",
                Drieccion = "Cerca a las colinas",
                Drones = 69,
                NitEmpresa = "515415L",
>>>>>>> 18b9cac3539ee569ac6073039bbabfd5195364ee
            };
            _repoMensajeria.AddMensajeria(mensajeria);

            var compras = new Pedidos
            {
<<<<<<< HEAD
                NombreDelPaquete = "Maquillaje",
                Peso = 12,
                FechaCreacion = new DateTime(2022, 09, 03, 12, 24, 25),
                EstadoDelPedido = "En Reparto",
                SuEncargado = empleado,
                SuComprador = cliente,
                SuEmpresaDeMensajeria = mensajeria
=======
                NombrePaquete = "EL Delicius",
                Peso = 12,
                FechaCreacion = new DateTime(2022, 09, 03),
                EstadoEmpleado = "Revisando"
>>>>>>> 18b9cac3539ee569ac6073039bbabfd5195364ee
            };

            var clienteactualizar = _repoCliente.GetCliente(cliente.Id);
            clienteactualizar.Compras.Add(compras);
            _repoCliente.UpdateCliente(clienteactualizar);

            var reporte = new Reportes
            {
<<<<<<< HEAD
                NombreDelReporte = "El bonito",
                TemperaturaDelaZona = "25°C",
                EstadoDrone = "En Servicio",
                EstadoPaquete = "en Reparto",
                Fecha = new DateTime(2022, 06, 09),
                // pedidos = compras
            };

            var historico = new Historico
            {
                Satisfacioncliente = "Buena",
                SusReportes = reporte,
            };
            _repoHistorico.AddHistorico(historico);

            var reporteactualizado = _repoReporte.GetReportes(reporte.Id);
            reporteactualizado.pedidos = compras;
            _repoReporte.UpdateReportes(reporteactualizado);

            var empeleadoActualizar = _repoEmpleado.GetEmpleado(empleado.Id);
            empeleadoActualizar.historico = historico;
            _repoEmpleado.UpdateEmpleado(empeleadoActualizar);

            // _repoReporte.AddReportes(reporte);
            // _repoPedido.AddPedido(compras);
        }
        // private static void AddPersonaNueva()
        // {
        //     var empleado = new Empleado
        //     {
        //         Nombre = "Robert",
        //         Apellidos = "Andres",
        //         FechaNacimiento = new DateTime(2000, 06, 01, 07, 24, 5),
        //         NumeroDeTelefono = "3127592134",
        //         Identificacion = "1053823290",
        //         TipoPersona = "El encargado",
        //         HorasLaboradas = 8,
        //     };

        //     _repoEmpleado.AddEmpleado(empleado);

        //     var mensajeria = new Mensajeria
        //     {
        //         NombreEmpresa = "Las Montañas del Ruis",
        //         Drieccion = "Cerca a las colinas",
        //         Drones = 69,
        //         NitEmpresa = "515415L",
        //         EstadoDrone = "En Servicio",
        //         Empleados = new Collection<Empleado>{
        //             empleado
        //         }
        //     };
        //     _repoMensajeria.AddMensajeria(mensajeria);

        //     var compras = new Pedidos
        //     {
        //         NombreDelPaquete = "EL Delicius",
        //         Peso = 12,
        //         FechaCreacion = new DateTime(2022, 09, 03),
        //         EstadoDelPedido = "En Reparto",
        //         SuEncargado = empleado,
        //         // SuComprador = cliente,
        //         SuEmpresaDeMensajeria = mensajeria
        //     };


        //     var cliente = new Cliente
        //     {
        //         Nombre = "Sebas",
        //         Apellidos = "Blandon",
        //         FechaNacimiento = new DateTime(1997, 07, 21),
        //         NumeroDeTelefono = "320589485",
        //         Identificacion = "1053858423",
        //         TipoPersona = "Cliente",
        //         Direccion = "Calle Wallaby P.Sherman",
        //         Compras = new Collection<Pedidos> {
        //             compras,
        //             // new Pedidos {
        //             //     NombreDelPaquete = "Los Morosos",
        //             //     Peso = 3,
        //             //     FechaCreacion = new DateTime (2022,08,32,25,26,55),
        //             //     EstadoDelPedido = "En zona de reparto",
        //             //     SuEncargado = empleado,
        //             //     SuEmpresaDeMensajeria = mensajeria
        //             //     // SuComprador = cliente,
        //             // }
        //         }
        //     };

        //     var clienteactualizar = _repoCliente.GetCliente(cliente.Id);
        //     clienteactualizar.Compras.Add(compras);
        //     _repoCliente.UpdateCliente(clienteactualizar);

        //     _repoCliente.AddCliente(cliente);

        //     var reporte = new Reportes
        //     {
        //         NombreDelReporte = "Reporte Primario",
        //         TemperaturaDelaZona = "25°C",
        //         EstadoDrone = "En Recarga",
        //         EstadoPaquete = "Entregado",
        //         Fecha = new DateTime(2022, 06, 09),
        //         pedidos = compras,
        //         // pedidos = compras
        //     };

        //     var historico = new Historico
        //     {
        //         Satisfacioncliente = "Regular",
        //         SusReportes = reporte,
        //     };
        //     _repoHistorico.AddHistorico(historico);

        //         var reporteactualizado = _repoReporte.GetReportes(reporte.Id);
        //         reporteactualizado.pedidos = compras;
        //         _repoReporte.UpdateReportes(reporteactualizado);

        //         var empeleadoActualizar = _repoEmpleado.GetEmpleado(empleado.Id);
        //         empeleadoActualizar.historico = historico;
        //         _repoEmpleado.UpdateEmpleado(empeleadoActualizar);

=======
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
>>>>>>> 18b9cac3539ee569ac6073039bbabfd5195364ee
        // }
    }
}

