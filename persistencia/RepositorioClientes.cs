using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;


namespace persistencia
{
    public class RepositorioClientes : IRepositorioClientes
    {
        private readonly ApplicationContext _applicationContext;
        public RepositorioClientes(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public RepositorioClientes(){}

        // sobreescribir metodo de conseguir todos los clientes
         IEnumerable<Clientes> IRepositorioClientes.GetAll(){
           return _applicationContext.clientes;
        }    

         Clientes IRepositorioClientes.Add(Clientes cliente){
            return null;
        }

        Clientes IRepositorioClientes.Update(Clientes cliente){
            return null;
        }

        bool IRepositorioClientes.Delete(int IdPersona){
            return false;
        }

        Clientes IRepositorioClientes.Get(int idCliente){
            return null;
        }

    }
}