using System;
using dominio;
using persistencia;

namespace consola
{
    class Program
    {
        private static IRepositorioClientes _repoClientes = new RepositorioClientes(new ApplicationContext());
        static void Main(string[] args)
        {
            var clientes = _repoClientes.GetAll();
            Console.WriteLine("Los datos de las personas son");
            if (clientes != null)
            {
                foreach (var cliente in clientes)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine(cliente.nombre);
                    Console.WriteLine(cliente.apellido);
                    Console.WriteLine(cliente.FK_idTipoDocumento);
                    Console.WriteLine("----------------------");
                    Console.WriteLine("");
                }
            }
        }
    }
}
