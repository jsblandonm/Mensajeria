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
    public class EmpleadosList : PageModel
    {
        public readonly IRepositorioEmpleado repositorioEmpleado;
        [BindProperty]
        public IEnumerable<Empleado> listaEmpleados {get;set;}
        public bool crear { get; set; }
        public bool editar { get; set; }

        public EmpleadosList(IRepositorioEmpleado repositorioEmpleado)
        {
            this.repositorioEmpleado = repositorioEmpleado;
        }

        public void OnGet()
        {
            listaEmpleados = repositorioEmpleado.GetAllEmpleado();
            crear = true;
            editar = false;
        }
    }
}