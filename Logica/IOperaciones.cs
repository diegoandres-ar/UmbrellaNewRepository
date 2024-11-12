using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal interface IOperaciones<T>
    {
        string Guardar(T entidad);
        T BuscarPorId(string id);
        List<T> ObtenerTodo();
        string Modificar(T entidad);
        string Eliminar(string id);
    }
}
