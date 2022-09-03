using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using persistencia;
using dominio;

namespace TallerAutos.App.Frontend.Pages
{

    public class ConsultarCliente : PageModel
    {
        private readonly IRepositorioClientes repoClientes;

        public IEnumerable<Clientes> clientes { get; set; }
        public ConsultarCliente(IRepositorioClientes repoClientes) {
            repoClientes = new RepositorioClientes(new ApplicationContext());
            this.repoClientes = repoClientes;
        }

        public IActionResult OnGet()
        {
            clientes = repoClientes.GetAll();
            return Page();
        }
    }
}