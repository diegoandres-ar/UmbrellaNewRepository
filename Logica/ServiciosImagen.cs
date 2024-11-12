using System;
using System.Drawing;
using System.IO;

namespace Logica
{
    public static class ServiciosImagen
    {
        public static byte[] ConvertirImagenABytes(Image imagen)
        {
            if (imagen == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Image ConvertirBytesAImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        public static iTextSharp.text.Image ConvertirBytesAImagenPDF(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);

                using (MemoryStream pdfStream = new MemoryStream())
                {
                    image.Save(pdfStream, System.Drawing.Imaging.ImageFormat.Png);
                    return iTextSharp.text.Image.GetInstance(pdfStream.ToArray());
                }
            }
        }

        public static iTextSharp.text.Image ConvertirRecursoAImagenPDF(System.Drawing.Image recursoImagen)
        {
            if (recursoImagen == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                recursoImagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return iTextSharp.text.Image.GetInstance(ms.ToArray());
            }
        }

    }
}