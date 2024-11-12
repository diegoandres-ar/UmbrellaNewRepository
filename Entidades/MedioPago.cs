using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MedioPago
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }

        public MedioPago(string id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
