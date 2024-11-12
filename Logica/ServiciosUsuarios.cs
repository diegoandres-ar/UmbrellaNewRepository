using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosUsuarios : IOperaciones<Usuario>
    {
        private RepositorioUsuarios repositorioUsuarios;

        public ServiciosUsuarios()
        {
            repositorioUsuarios = new RepositorioUsuarios();
        }

        public Usuario BuscarPorId(string id)
        {
            return repositorioUsuarios.BuscarPorId(id);
        }

        public string Eliminar(string id)
        {
            return repositorioUsuarios.Eliminar(id);
        }

        public string Guardar(Usuario usuario)
        {
            return repositorioUsuarios.Registrar(usuario);
        }

        public string Modificar(Usuario entidad)
        {
            return repositorioUsuarios.Modificar(entidad);
        }

        public List<Usuario> ObtenerTodo()
        {
            return repositorioUsuarios.ObtenerTodo();
        }
    }
}
