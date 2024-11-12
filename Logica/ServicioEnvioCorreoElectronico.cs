using Entidades;
using System;
using System.Net;
using System.Net.Mail;

namespace Logica
{
    public class ServicioEnvioCorreoElectronico
    {
        private string correoEmisor = "storeumbrella551@gmail.com";
        private string contrasena = "gabo xihq rudm pfjw";
        private string servidorSMTP = "smtp.gmail.com";
        private int puertoSMTP = 587;

        public string EnviarFacturaPorCorreo(string rutaPDF, Cliente cliente)
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress(correoEmisor);
                mensaje.To.Add(new MailAddress(cliente.CorreoElectronico));
                mensaje.Subject = "Gracias por tu compra en Umbrella";

                mensaje.Body = $"Hola {cliente.PrimerNombre},\n\n" +
                               "Gracias por tu compra en Umbrella, tu tienda de videojuegos de confianza. " +
                               "Adjunto encontrarás la factura de tu compra.\n\n" +
                               "¡Esperamos que disfrutes de tus nuevos juegos!\n\n" +
                               "Saludos,\n" +
                               "Equipo de Umbrella";

                mensaje.Attachments.Add(new Attachment(rutaPDF));

                SmtpClient clienteSMTP = new SmtpClient(servidorSMTP, puertoSMTP)
                {
                    Credentials = new NetworkCredential(correoEmisor, contrasena),
                    EnableSsl = true
                };

                clienteSMTP.Send(mensaje);
                return $"Correo enviado exitosamente a {cliente.PrimerNombre} ({cliente.CorreoElectronico})";
            }
            catch (Exception ex)
            {
                return $"Error al enviar el correo: {ex.Message}";
            }
        }
    }
}
