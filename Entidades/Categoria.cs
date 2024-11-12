using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }

        public Categoria(string id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
