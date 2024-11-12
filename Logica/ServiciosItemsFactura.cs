using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosItemsFactura : IOperacionesConsultas<Item>
    {
        RepositorioItems repositorioItems;

        public ServiciosItemsFactura()
        {
            repositorioItems = new RepositorioItems();
        }

        public Item BuscarPorId(string id)
        {
            return repositorioItems.BuscarPorId(id);
        }

        public string Guardar(Item entidad, string idFactura)
        {
            return repositorioItems.Registrar(entidad, idFactura);
        }

        public List<Item> ObtenerTodo()
        {
            return repositorioItems.ObtenerTodo();
        }

        public double CalcularSubTotal(Juego juego, int cantidad)
        {
            return juego.Precio * cantidad;
        }

        public string GenerarId()
        {
            List<Item> items = ObtenerTodo();
            var idsNumericos = items.Select(i => int.Parse(i.Id)).ToList();
            int maxId = idsNumericos.Count > 0 ? idsNumericos.Max() : 0;
            int nuevoId = maxId + 1;
            return nuevoId.ToString("D6");
        }

    }
}
