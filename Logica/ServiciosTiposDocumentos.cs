using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosTiposDocumentos : IOperaciones<TipoDocumento>
    {
        private RepositorioTiposDocumentos RepositorioTiposDocumentos;

        public ServiciosTiposDocumentos()
        {
            RepositorioTiposDocumentos = new RepositorioTiposDocumentos();
        }
        public TipoDocumento BuscarPorId(string id)
        {
            return RepositorioTiposDocumentos.BuscarPorId(id);
        }

        public string Eliminar(string id)
        {
            return RepositorioTiposDocumentos.Eliminar(id);
        }

        public string Guardar(TipoDocumento entidad)
        {
            return RepositorioTiposDocumentos.Registrar(entidad);
        }

        public string Modificar(TipoDocumento entidad)
        {
            return RepositorioTiposDocumentos.Modificar(entidad);
        }

        public List<TipoDocumento> ObtenerTodo()
        {
            return RepositorioTiposDocumentos.ObtenerTodo();
        }

        public string GenerarId()
        {
            List<TipoDocumento> tiposDocumentos = ObtenerTodo();
            var idsNumericos = tiposDocumentos.Select(c => int.Parse(c.Id)).ToList();
            int maxId = idsNumericos.Count > 0 ? idsNumericos.Max() : 0;
            int nuevoId = maxId + 1;
            return nuevoId.ToString("D2");
        }

    }
}
