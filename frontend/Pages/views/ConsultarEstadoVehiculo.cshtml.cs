using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TallerAutos.App.Frontend.Pages
{
    public class ConsultarEstadoVehiculo : PageModel
    {
        private readonly ILogger<ConsultarEstadoVehiculo> _logger;

        public ConsultarEstadoVehiculo(ILogger<ConsultarEstadoVehiculo> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}