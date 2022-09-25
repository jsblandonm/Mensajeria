using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;

namespace DroneOfTheFuture.App.FrontEnd.Pages.PedidosPage
{
    public class PedidosList : PageModel
    {
        public readonly IRepositorioPedido _repoPedido;

        public IEnumerable<Pedidos> listaPedidos;

        public PedidosList()
        {
            _repoPedido = new RepositorioPedidos();
        }

        public void OnGet(int pedidosId)
        {
            listaPedidos = _repoPedido.GetAllPedido();
        }
    }
}