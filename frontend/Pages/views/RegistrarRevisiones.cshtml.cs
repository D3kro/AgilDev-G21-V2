using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TallerAutos.Frontend.Pages
{
    public class RegistrarRevisiones : PageModel
    {
        private readonly ILogger<RegistrarRevisiones> _logger;

        public RegistrarRevisiones(ILogger<RegistrarRevisiones> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}