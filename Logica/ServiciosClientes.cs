using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosClientes : IOperaciones<Cliente>
    {
        private RepositorioClientes repositorioClientes;

        public ServiciosClientes()
        {
            repositorioClientes = new RepositorioClientes();
        }

        public Cliente BuscarPorId(string id)
        {
            return repositorioClientes.BuscarPorId(id);
        }

        public string Eliminar(string id)
        {
            return repositorioClientes.Eliminar(id);
        }

        public string Guardar(Cliente entidad)
        {
            return repositorioClientes.Registrar(entidad);
        }

        public string Modificar(Cliente entidad)
        {
            return repositorioClientes.Modificar(entidad);
        }

        public List<Cliente> ObtenerTodo()
        {
            return repositorioClientes.ObtenerTodo();
        }
    }
}
