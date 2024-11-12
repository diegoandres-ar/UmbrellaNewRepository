using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosPlataformas : IOperaciones<Plataforma>
    {
        private RepositorioPlataformas repositorioPlataformas;

        public ServiciosPlataformas()
        {
            repositorioPlataformas = new RepositorioPlataformas();
        }
        public Plataforma BuscarPorId(string id)
        {
            return repositorioPlataformas.BuscarPorId(id);
        }

        public string Eliminar(string id)
        {
            return repositorioPlataformas.Eliminar(id);
        }

        public string Guardar(Plataforma entidad)
        {
            return repositorioPlataformas.Registrar(entidad);
        }

        public string Modificar(Plataforma entidad)
        {
            return repositorioPlataformas.Modificar(entidad);
        }

        public List<Plataforma> ObtenerTodo()
        {
            return repositorioPlataformas.ObtenerTodo();
        }

        public string GenerarId()
        {
            List<Plataforma> plataformas = ObtenerTodo();
            var idsNumericos = plataformas.Select(c => int.Parse(c.Id)).ToList();
            int maxId = idsNumericos.Count > 0 ? idsNumericos.Max() : 0;
            int nuevoId = maxId + 1;
            return nuevoId.ToString("D3");
        }

    }
}
