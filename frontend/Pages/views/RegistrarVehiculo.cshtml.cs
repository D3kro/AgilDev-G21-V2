using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TallerAutos.Frontend.Pages
{
    public class RegistrarVehiculo : PageModel
    {
        private readonly ILogger<RegistrarVehiculo> _logger;

        public RegistrarVehiculo(ILogger<RegistrarVehiculo> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}