using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TallerAutos.App.Frontend.Pages
{
    public class ConsultarRevisiones : PageModel
    {
        private readonly ILogger<ConsultarRevisiones> _logger;

        public ConsultarRevisiones(ILogger<ConsultarRevisiones> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}