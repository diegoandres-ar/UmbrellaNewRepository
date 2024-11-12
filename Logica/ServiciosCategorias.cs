using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosCategorias : IOperaciones<Categoria>
    {
        private RepositorioCategorias repositorioCategorias;

        public ServiciosCategorias()
        {
            repositorioCategorias = new RepositorioCategorias();
        }
        public Categoria BuscarPorId(string id)
        {
            return repositorioCategorias.BuscarPorId(id);
        }

        public string Eliminar(string id)
        {
            return repositorioCategorias.Eliminar(id);
        }

        public string Guardar(Categoria entidad)
        {
            return repositorioCategorias.Registrar(entidad);
        }

        public string Modificar(Categoria entidad)
        {
            return repositorioCategorias.Modificar(entidad);
        }

        public List<Categoria> ObtenerTodo()
        {
            return repositorioCategorias.ObtenerTodo();
        }

        public string GenerarId()
        {
            List<Categoria> categorias = ObtenerTodo();
            var idsNumericos = categorias.Select(c => int.Parse(c.Id)).ToList();
            int maxId = idsNumericos.Count > 0 ? idsNumericos.Max() : 0;
            int nuevoId = maxId + 1;
            return nuevoId.ToString("D2");
        }

    }
}
