using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorioClientes
    {
        // operaciones basicas
        IEnumerable<Clientes> GetAll();
        Clientes Add(Clientes cliente);
        Clientes Update(Clientes cliente);
        bool Delete(int idCliente);
        Clientes Get(int idCliente);
    }
}