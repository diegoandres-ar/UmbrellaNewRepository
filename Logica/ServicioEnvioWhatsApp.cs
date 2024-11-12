using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Logica
{
    public class ServicioEnvioWhatsApp
    {
        private const string ApiUrl = "https://graph.facebook.com/v21.0/495998163590229/messages";
        private readonly string token = "EAA1KCHrpQZAcBO8mLLNlL1JOju0xgJU8dcJAJdEePaOpZCtkreL6XZBT" +
            "CboL6yGUuAVwkmbsFfIrqnniZBDH1DZBqS2u50E9FodecXhk3DBBtqS9GK1qaNzNvyFCLFZCAy6N2nCQZAIutDh" +
            "8RElOmGMo1gPbbziGjLBFbO2bcukYJGuFz9WaAdaK18T6HWmsFrbWwZDZD";

        public async Task<string> EnviarFacturaWhatsApp(Factura factura, string direccionFactura)
        {
            string numeroTelefono = "57" + factura.Cliente.Telefono;

            if (string.IsNullOrEmpty(direccionFactura))
            {
                return "El enlace de la factura no es válido.";
            }

            var headerParameters = new[]
            {
                new Parameter
                {
                    type = "document",
                    document = new DocumentWhatsApp
                    {
                        link = direccionFactura,
                        filename = $"Factura_{factura.Id}.pdf"
                    }
                }
            };

            var bodyParameters = new[]
            {
                new Parameter { type = "text", text = factura.Cliente.PrimerNombre },
                new Parameter { type = "text", text = factura.Id.ToString() },
                new Parameter { type = "text", text = factura.Total.ToString("N2") + " $" }
            };

            var body = new
            {
                messaging_product = "whatsapp",
                to = numeroTelefono,
                type = "template",
                template = new
                {
                    name = "factura",
                    language = new
                    {
                        code = "es"
                    },
                    components = new[]
                    {
                        new
                        {
                            type = "header",
                            parameters = headerParameters
                        },
                        new
                        {
                            type = "body",
                            parameters = bodyParameters
                        }
                    }
                }
            };

            var jsonBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(ApiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    return "Factura enviada correctamente.";
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    return $"Error al enviar la factura: {response.StatusCode} - {errorResponse}";
                }
            }
        }

    }
}