using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosRoles : IOperaciones<Rol>
    {
        RepositorioRoles repositorioRoles;

        public ServiciosRoles()
        {
            repositorioRoles = new RepositorioRoles();
        }

        public Rol BuscarPorId(string id)
        {
            return repositorioRoles.BuscarPorId(id);
        }

        public string Eliminar(string id)
        {
            return repositorioRoles.Eliminar(id);
        }

        public string Guardar(Rol entidad)
        {
            return repositorioRoles.Registrar(entidad);
        }

        public string Modificar(Rol entidad)
        {
            return repositorioRoles.Modificar(entidad);
        }

        public List<Rol> ObtenerTodo()
        {
            return repositorioRoles.ObtenerTodo();
        }
    }
}
