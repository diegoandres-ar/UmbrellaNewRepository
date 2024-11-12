using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juego
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Formato { get; set; }
        public byte[] Portada {  get; set; }
        public int AnioLanzamiento { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public Categoria Categoria { get; set; }
        public Plataforma Plataforma { get; set; }

        public Juego(string id, string titulo, string formato, byte[] portada, 
            int anioLanzamiento, double precio, int stock, Categoria categoria, Plataforma plataforma)
        {
            Id = id;
            Titulo = titulo;
            Formato = formato;
            Portada = portada;
            AnioLanzamiento = anioLanzamiento;
            Precio = precio;
            Stock = stock;
            Categoria = categoria;
            Plataforma = plataforma;
        }
    }
}
