using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosReportes
    {
        private ServiciosFacturas serviciosFacturas;
        private ServiciosItemsFactura serviciosItemsFactura;
        private ServiciosJuegos serviciosJuegos;

        public ServiciosReportes()
        {
            serviciosFacturas = new ServiciosFacturas();
            serviciosItemsFactura = new ServiciosItemsFactura();
            serviciosJuegos = new ServiciosJuegos();
        }

        public double ObtenerGananciaTotal()
        {
            double gananciaTotal = 0;
            List<Factura> facturas = serviciosFacturas.ObtenerTodo();
            foreach (Factura factura in facturas)
            {
                gananciaTotal += factura.Total;
            }
            return gananciaTotal;
        }

        public Dictionary<string, double> ObtenerGananciaPorJuego()
        {
            Dictionary<string, double> gananciaPorJuego = new Dictionary<string, double>();
            List<Item> itemsFactura = serviciosItemsFactura.ObtenerTodo();

            foreach (Item item in itemsFactura)
            {
                string juegoId = item.Juego.Id;
                double gananciaItem = item.Juego.Precio * item.Cantidad;

                if (gananciaPorJuego.ContainsKey(juegoId))
                {
                    gananciaPorJuego[juegoId] += gananciaItem;
                }
                else
                {
                    gananciaPorJuego[juegoId] = gananciaItem;
                }
            }

            return gananciaPorJuego;
        }

        public double ObtenerRestantePorVender()
        {
            double restantePorVender = 0;
            List<Juego> juegos = serviciosJuegos.ObtenerTodo();
            foreach (Juego juego in juegos)
            {
                restantePorVender += juego.Precio * juego.Stock;
            }
            return restantePorVender;
        }

        public int ObtenerCantidadEnStock()
        {
            int cantidadEnStock = 0;
            List<Juego> juegos = serviciosJuegos.ObtenerTodo();
            foreach (Juego juego in juegos)
            {
                cantidadEnStock += juego.Stock;
            }
            return cantidadEnStock;
        }

        public double ObtenerGananciasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            double ganancia = 0;
            List<Factura> facturas = serviciosFacturas.ObtenerTodo();
            foreach (Factura factura in facturas)
            {
                if (factura.Fecha >= fechaInicio && factura.Fecha <= fechaFin)
                {
                    ganancia += factura.Total;
                }
            }
            return ganancia;
        }

        public Dictionary<string, double> ObtenerGananciaPorJuegosEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            Dictionary<string, double> gananciaPorJuego = new Dictionary<string, double>();
            List<Factura> facturas = serviciosFacturas.ObtenerTodo();
            foreach (Factura factura in facturas)
            {
                if (factura.Fecha >= fechaInicio && factura.Fecha <= fechaFin)
                {
                    foreach (Item item in factura.Items)
                    {
                        string juegoId = item.Juego.Id;
                        double gananciaItem = item.Juego.Precio * item.Cantidad;

                        if (gananciaPorJuego.ContainsKey(juegoId))
                        {
                            gananciaPorJuego[juegoId] += gananciaItem;
                        }
                        else
                        {
                            gananciaPorJuego[juegoId] = gananciaItem;
                        }
                    }
                }
            }
            return gananciaPorJuego;
        }

    }
}
