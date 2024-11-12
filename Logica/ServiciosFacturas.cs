using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosFacturas : IOperacionesConsultas<Factura>
    {
        RepositorioFacturas repositorioFacturas;

        public ServiciosFacturas()
        {
            repositorioFacturas = new RepositorioFacturas();
        }

        public Factura BuscarPorId(string id)
        {
            return repositorioFacturas.BuscarPorId(id);
        }

        public List<Factura> ObtenerTodo()
        {
            return repositorioFacturas.ObtenerTodo();
        }

        public string Guardar(Factura factura)
        {
            return repositorioFacturas.Registrar(factura);
        }

        public double CalcularTotalFactura(List<Item> items)
        {
            double total = 0;
            foreach (Item item in items)
            {
                total += item.Juego.Precio * item.Cantidad;
            }
            return total;
        }

        public double TotalIVA(double total, double iva)
        {
            return (total * iva) / 100;
        }

        public double AplicarIVA(double total, double IVA)
        {
            return total + TotalIVA(total, IVA);
        }

        public double CalcularCambio(double total, double efectivo)
        {
            return efectivo - total;
        }

        public Dictionary<DateTime, int> ObtenerFacturasPorDia(DateTime fechaInicio, DateTime fechaFin)
        {
            return repositorioFacturas.ObtenerFacturasPorDia(fechaInicio, fechaFin);
        }

        public string GenerarId()
        {
            List<Factura> facturas = ObtenerTodo();
            var idsNumericos = facturas.Select(c => int.Parse(c.Id)).ToList();
            int maxId = idsNumericos.Count > 0 ? idsNumericos.Max() : 0;
            int nuevoId = maxId + 1;
            return nuevoId.ToString("D6");
        }

    }
}
