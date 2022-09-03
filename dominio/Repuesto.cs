using System;

namespace dominio
{
    public class Repuesto
    {
          public string idRepuesto {get; set;}
        public string descripcionRepuesto {get; set;}
        public int cantidad {get; set;}
        public string FK_idOd {get; set;}
    }
}
