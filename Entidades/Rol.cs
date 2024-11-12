using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rol
    {
        public string Id {  get; set; }
        public string Descripcion { get; set; }
        public List<Permiso> Permisos { get; set; }

        public Rol(string id, string descripcion, List<Permiso> permisos)
        {
            Id = id;
            Descripcion = descripcion;
            Permisos = permisos;
        }
    }
}