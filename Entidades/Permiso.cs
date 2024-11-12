using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permiso
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }

        public Permiso(string id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
