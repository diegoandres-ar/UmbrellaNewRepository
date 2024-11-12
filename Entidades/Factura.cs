using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public string Id {  get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public List<Item> Items { get; set; }
        public double IVA { get; set; }
        public MedioPago MedioPago { get; set; }
        public string Observaciones { get; set; }
        public byte[] CodigoQR { get; set; }
        public double Total { get; set; }

        public Factura(string id, Cliente cliente, Usuario usuario, DateTime fecha, DateTime hora, 
            List<Item> items, double iVA, MedioPago medioPago, string observaciones, byte[] codigoQR, double total)
        {
            Id = id;
            Cliente = cliente;
            Usuario = usuario;
            Fecha = fecha;
            Hora = hora;
            Items = items;
            IVA = iVA;
            MedioPago = medioPago;
            Observaciones = observaciones;
            CodigoQR = codigoQR;
            Total = total;
        }
    }
}
