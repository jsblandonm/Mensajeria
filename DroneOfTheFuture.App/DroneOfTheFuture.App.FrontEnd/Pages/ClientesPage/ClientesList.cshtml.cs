using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Persistencia;
using DroneOfTheFuture.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace DroneOfTheFuture.App.FrontEnd.Pages
{
    [Authorize]
    public class ClientesModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;

        [BindProperty]
        public IEnumerable<Cliente> Clientes { get; set; }
        public bool crear {get;set;}
        public bool editar {get;set;}


        public ClientesModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public void OnGet()
        {
            Clientes = repositorioCliente.GetAllCliente();
            crear = true;
            editar = false;
        }

    }
}
