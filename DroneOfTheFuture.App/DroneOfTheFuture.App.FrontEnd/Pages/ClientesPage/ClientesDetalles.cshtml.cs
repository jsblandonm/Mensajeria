using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Persistencia;
using DroneOfTheFuture.App.Dominio;

namespace DroneOfTheFuture.App.FrontEnd.Pages.ClientesPage
{
    public class ClientesDetalles : PageModel
    {
        private readonly IRepositorioCliente _repoCliente;

        public Cliente elCliente;

        public ClientesDetalles()
        {
            _repoCliente = new RepositorioCliente();
        }

        public void OnGet(int clienteId)
        {
            Cliente elCliente = _repoCliente.GetCliente(clienteId);
        }
    }
}