using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosInventario
    {
        RepositorioJuegos repositorioJuegos;
        public ServiciosInventario()
        {
            repositorioJuegos = new RepositorioJuegos();
        }

        public string DisminuirCantidadJuegos(Factura factura)
        {
            foreach (Item item in factura.Items)
            {
                Juego juego = repositorioJuegos.BuscarPorId(item.Juego.Id);
                juego.Stock -= item.Cantidad;
                repositorioJuegos.Modificar(juego);
            }
            return "Inventario actualizado";
        }
    }
}
