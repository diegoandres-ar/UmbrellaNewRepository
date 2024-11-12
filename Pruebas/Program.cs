using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ServicioEnvioWhatsApp servicioEnvioWhatsApp = new ServicioEnvioWhatsApp();
            Factura factura = new ServiciosFacturas().BuscarPorId("000028");
            factura.Cliente.Telefono = "3016325713";
            string filePath = @"C:\Users\DIEGO ARIZA\Documents\Factura_000025.pdf";
            //var url = await ServiciosDropBox.UploadFileToDropboxAsync(filePath);
            string url2 = "https://dl.dropboxusercontent.com/scl/fi/ln0s9ysmf8pozbnczq3nr/Factura_000025.pdf?rlkey=wtetxddxcebf7fccvownv6rsw&dl=0";
            var mensaje = await servicioEnvioWhatsApp.EnviarFacturaWhatsApp(factura.Cliente, factura, url2);
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
    }
}
