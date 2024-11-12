using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosMediosPagos : IOperaciones<MedioPago>
    {
        private RepositorioMediosPago repositorioMediosPago;

        public ServiciosMediosPagos()
        {
            repositorioMediosPago = new RepositorioMediosPago();
        }

        public MedioPago BuscarPorId(string id)
        {
            return repositorioMediosPago.BuscarPorId(id);
        }

        public string Eliminar(string id)
        {
            return repositorioMediosPago.Eliminar(id);
        }

        public string Guardar(MedioPago entidad)
        {
            return repositorioMediosPago.Registrar(entidad);
        }

        public string Modificar(MedioPago entidad)
        {
            return repositorioMediosPago.Modificar(entidad);
        }

        public List<MedioPago> ObtenerTodo()
        {
            return repositorioMediosPago.ObtenerTodo();
        }
    }
}
