using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Logica
{
    public class ServiciosJuegos : IOperaciones<Juego>
    {
        private RepositorioJuegos repositorioJuegos;
        private List<Juego> juegos;

        public ServiciosJuegos()
        {
            repositorioJuegos = new RepositorioJuegos();
        }
        public Juego BuscarPorId(string id)
        {
            return repositorioJuegos.BuscarPorId(id);
        }

        public string Eliminar(string id)
        {
            return repositorioJuegos.Eliminar(id);
        }

        public string Guardar(Juego entidad)
        {
            return repositorioJuegos.Registrar(entidad);
        }

        public string Modificar(Juego entidad)
        {
            return repositorioJuegos.Modificar(entidad);
        }

        public List<Juego> ObtenerTodo()
        {
            return repositorioJuegos.ObtenerTodo();
        }

        public List<Juego> FiltrarPorAnios(int anioInicio, int anioFin)
        {
            juegos = repositorioJuegos.FiltrarPorAnioLanzamiento(anioInicio, anioFin);
            return juegos;
        }

        public string GenerarId()
        {
            juegos = ObtenerTodo();
            var idsNumericos = juegos.Select(c => int.Parse(c.Id)).ToList();
            int maxId = idsNumericos.Count > 0 ? idsNumericos.Max() : 0;
            int nuevoId = maxId + 1;
            return nuevoId.ToString("D4");
        }

    }
}
