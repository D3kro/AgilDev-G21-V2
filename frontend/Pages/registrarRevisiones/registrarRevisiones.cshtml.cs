using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace frontend.Pages.registrarRevisiones
{
    public class registrarRevisiones : PageModel
    {
        private readonly ILogger<registrarRevisiones> _logger;

        public registrarRevisiones(ILogger<registrarRevisiones> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}