using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Plataforma
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }

        public Plataforma(string id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

    }
}
