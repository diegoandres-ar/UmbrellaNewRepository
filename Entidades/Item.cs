using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Item
    {
        public string Id { get; set; }
        public Juego Juego { get; set; }
        public int Cantidad { get; set; }
        public double Subtotal { get; set; }

        public Item(string id, Juego juego, int cantidad)
        {
            Id = id;
            Juego = juego;
            Cantidad = cantidad;
            Subtotal = juego.Precio * cantidad;
        }

        public Item(Juego juego, int cantidad)
        {
            Juego = juego;
            Cantidad = cantidad;
            Subtotal = juego.Precio * cantidad;
        }

    }
}
