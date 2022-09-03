using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dominio
{
    public class Tecnicos 
    {
           public string idTecnico {get; set;}
        public string numeroDocumento {get; set;}
        public string correo {get; set;}
        public string titulo { get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string telefono {get; set;}
        public string contrasena {get; set;}
        public string FK_idTipoDocumento {get; set;}
    }
}