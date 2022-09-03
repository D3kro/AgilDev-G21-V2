using System;

namespace dominio
{
    public class OrdenesTrabajo
    {
        public string idOd  { get; set;}
        public string fecha {get; set;}
        public string estado {get; set;}
        public string FK_idTecnico {get; set;}
        public string FK_placaVehiculo {get; set;}
    }
}
