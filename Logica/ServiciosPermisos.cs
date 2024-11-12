using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosPermisos : IOperaciones<Permiso>
    {
        private RepositorioPermisos repositorioPermisos;

        public ServiciosPermisos()
        {
            repositorioPermisos = new RepositorioPermisos();
        }

        public Permiso BuscarPorId(string id)
        {
            return repositorioPermisos.BuscarPorId(id);
        }

        public string Eliminar(string id)
        {
            return repositorioPermisos.Eliminar(id);
        }

        public string Guardar(Permiso entidad)
        {
            return repositorioPermisos.Registrar(entidad);
        }

        public string Modificar(Permiso entidad)
        {
            return repositorioPermisos.Modificar(entidad);
        }

        public List<Permiso> ObtenerTodo()
        {
            return repositorioPermisos.ObtenerTodo();
        }
    }
}
