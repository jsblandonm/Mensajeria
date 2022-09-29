using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Persistencia;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.FrontEnd.Pages.PedidosPage;


namespace DroneOfTheFuture.App.FrontEnd.Pages.ClientesPage
{
    public class ClientesDetalles : PageModel
    {
        public readonly IRepositorioCliente repositorioCliente;
        // public readonly IRepositorioPedido repositorioPedido;
        public Cliente elCliente;

        public ClientesDetalles()
        {
            // repositorioPedido = new RepositorioPedidos();
            repositorioCliente = new RepositorioCliente();

        }
        public IActionResult OnGet(int idCliente)
        {
            elCliente = repositorioCliente.GetCliente(idCliente);
            // elCliente.Compras = _repoPedidos.GetPedidos(idCliente);
            if (elCliente == null)
            {
                return RedirectToPage("./ErrorBusqueda");
            }
            else
            {
                return Page();
            }
        }
    }
}