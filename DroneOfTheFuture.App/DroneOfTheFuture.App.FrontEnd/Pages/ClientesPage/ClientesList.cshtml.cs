using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Persistencia;
using DroneOfTheFuture.App.Dominio;

namespace DroneOfTheFuture.App.FrontEnd.Pages
{
    public class ClientesModel : PageModel
    {
        public readonly IRepositorioCliente _repoClientes;
        public IEnumerable<Cliente> listaClientes;
        public ClientesModel(ILogger<IndexModel> logger)
        {
            _repoClientes = new RepositorioCliente();
        }

        public void OnGet()
        {
            listaClientes = _repoClientes.GetAllCliente();
        }
    }
}
