using System;

namespace dominio
{
    public class Vehiculo
    {
        public string placa {get; set;}
        public string modelo {get; set;}
        public string marca {get; set;}
        public string color {get; set;}
        public string FK_idCliente {get; set;}
        public string FK_idTipoVehiculo {get; set;}
    }
}
