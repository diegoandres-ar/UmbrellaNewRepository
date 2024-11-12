using System;
using System.Collections.Generic;
using System.IO;
using Entidades;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Logica
{
    public static class ServiciosReportesPdf
    {
        private static ServiciosReportes serviciosReportes = new ServiciosReportes();
        private static ServiciosJuegos serviciosJuegos = new ServiciosJuegos();

        public static string GenerarReporteVideojuegosPDF(string ruta)
        {
            List<Juego> juegos = serviciosJuegos.ObtenerTodo();
            int totalStock = serviciosReportes.ObtenerCantidadEnStock();
            double totalPorVender = serviciosReportes.ObtenerRestantePorVender();
            double gananciaTotal = serviciosReportes.ObtenerGananciaTotal();
            Dictionary<string, double> gananciaPorJuego = serviciosReportes.ObtenerGananciaPorJuego();

            string fontPath = @"C:\Windows\Fonts\GOTHIC.TTF";
            iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 50f, 50f, 50f, 50f);
            string path = Path.Combine(ruta, "Reporte_Videojuegos.pdf");

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font fontTitle = new Font(baseFont, 14, Font.BOLD);
                Font fontHeader = new Font(baseFont, 10, Font.BOLD);
                Font fontContent = new Font(baseFont, 10, Font.NORMAL);

                document.Add(new Paragraph("Reporte de Videojuegos", fontTitle) { Alignment = Element.ALIGN_CENTER });
                document.Add(new Paragraph($"Fecha del reporte: {DateTime.Now:dd-MM-yyyy HH:mm:ss}", fontContent) { Alignment = Element.ALIGN_RIGHT });
                document.Add(new Paragraph("\n"));

                PdfPTable table = new PdfPTable(5) { WidthPercentage = 100 };
                table.SetWidths(new float[] { 3, 2, 1, 1, 1 });
                table.AddCell(new PdfPCell(new Phrase("Juego", fontHeader)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Categoría", fontHeader)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Stock", fontHeader)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Precio", fontHeader)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Vendido", fontHeader)) { HorizontalAlignment = Element.ALIGN_CENTER });

                foreach (var juego in juegos)
                {
                    table.AddCell(new PdfPCell(new Phrase(juego.Titulo, fontContent)));
                    table.AddCell(new PdfPCell(new Phrase(juego.Categoria.Descripcion, fontContent)));
                    table.AddCell(new PdfPCell(new Phrase(juego.Stock.ToString(), fontContent)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    table.AddCell(new PdfPCell(new Phrase(juego.Precio.ToString("C"), fontContent)) { HorizontalAlignment = Element.ALIGN_RIGHT });

                    double gananciaVendido = gananciaPorJuego.ContainsKey(juego.Id) ? gananciaPorJuego[juego.Id] : 0;
                    table.AddCell(new PdfPCell(new Phrase(gananciaVendido.ToString("C"), fontContent)) { HorizontalAlignment = Element.ALIGN_RIGHT });
                }
                document.Add(table);

                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph($"Cantidad Total en Stock: {totalStock}", fontContent));
                document.Add(new Paragraph($"Total por Vender: {totalPorVender:C}", fontContent));
                document.Add(new Paragraph($"Total Vendido: {gananciaTotal:C}", fontContent));

                document.Close();
            }

            return $"Reporte generado en: {path}";
        }
    }
}
