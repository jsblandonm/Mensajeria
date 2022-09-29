using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;

namespace DroneOfTheFuture.App.FrontEnd.Pages.EmpleadosPage
{
    public class EmpleadosDetalles : PageModel
    {
        public readonly IRepositorioEmpleado repositorioEmpleado;
        public readonly IRepositorioPedido repositorioPedido;
        public Empleado elEmpleado;
        public EmpleadosDetalles()
        {
            repositorioPedido = new RepositorioPedidos();
            repositorioEmpleado = new RepositorioEmpleado();
            
        }
        public IActionResult OnGet(int EmpleadoId)
        {
            elEmpleado = repositorioEmpleado.GetEmpleado(EmpleadoId);
            if (elEmpleado == null)
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