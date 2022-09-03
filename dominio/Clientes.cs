using System;
using System.Data;
using System.ComponentModel;

namespace dominio
{
    public class Clientes 
    {   
        public int Id {get; set;}
        public string numeroDocumento {get; set;}
        public string correo {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string telefono {get; set;}
        public string contrasena {get; set;}
        public int FK_idTipoDocumento {get; set;}
    }
}