using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using Entidades;
using System.Linq;
using System.Xml.Linq;

namespace Logica
{
    public static class ServiciosFormatoFactura
    {
        public static string ConvertirFacturaPDF(Factura factura, string ruta)
        {
            string fontPath = @"C:\Windows\Fonts\GOTHIC.TTF";
            Document document = new Document(PageSize.A4, 50f, 50f, 50f, 50f);
            string path = Path.Combine(ruta, $"Factura_{factura.Id}.pdf");
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(document, stream);
                document.Open();

                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font gothicFont = new Font(baseFont, 11, Font.BOLD);
                Font gothicFontSmall = new Font(baseFont, 9, Font.BOLD);


                iTextSharp.text.Image pdfLogo = iTextSharp.text.Image.GetInstance(@"C:\Users\DIEGO ARIZA\source\repos\UmbrellaStore\UmbrellaLogo.png");
                pdfLogo.ScaleToFit(60f, 60f);
                pdfLogo.Alignment = Element.ALIGN_CENTER;

                Paragraph headerParagraph = new Paragraph();
                headerParagraph.Alignment = Element.ALIGN_CENTER;
                headerParagraph.Add(pdfLogo);
                headerParagraph.Add(new Phrase("UMBRELLA STORE\nFACTURA ELECTRÓNICA DE VENTA", gothicFont));
                document.Add(headerParagraph);
                document.Add(new Chunk("\n"));

                PdfPTable dateTable = new PdfPTable(2);
                dateTable.AddCell(new PdfPCell(new Phrase("Fecha de Generación:", gothicFont)));
                dateTable.AddCell(new PdfPCell(new Phrase(factura.Fecha.ToString("dd-MM-yyyy"), gothicFont)));
                dateTable.AddCell(new PdfPCell(new Phrase("Hora:", gothicFont)));
                dateTable.AddCell(new PdfPCell(new Phrase(factura.Hora.ToString("HH:mm:ss"), gothicFont)));
                document.Add(dateTable);

                PdfPTable clientTable = new PdfPTable(2);
                clientTable.WidthPercentage = 100;
                clientTable.SpacingBefore = 10;

                clientTable.AddCell(new PdfPCell(new Phrase("CLIENTE:", gothicFont)));
                clientTable.AddCell(new PdfPCell(new Phrase($"{factura.Cliente.PrimerNombre} {factura.Cliente.SegundoNombre}" +
                    $" {factura.Cliente.PrimerApellido} {factura.Cliente.SegundoApellido}", gothicFont)));
                clientTable.AddCell(new PdfPCell(new Phrase("N° DOCUMENTO:", gothicFont)));
                clientTable.AddCell(new PdfPCell(new Phrase(factura.Cliente.NumeroIdentificacion, gothicFont)));
                clientTable.AddCell(new PdfPCell(new Phrase("TIPO DOC:", gothicFont)));
                clientTable.AddCell(new PdfPCell(new Phrase(factura.Cliente.TipoDocumento.Descripcion, gothicFont)));
                clientTable.AddCell(new PdfPCell(new Phrase("TELEFONO:", gothicFont)));
                clientTable.AddCell(new PdfPCell(new Phrase(factura.Cliente.Telefono, gothicFont)));
                clientTable.AddCell(new PdfPCell(new Phrase("CORREO:", gothicFont)));
                clientTable.AddCell(new PdfPCell(new Phrase(factura.Cliente.CorreoElectronico, gothicFont)));
                clientTable.AddCell(new PdfPCell(new Phrase("TIPO PERSONA:", gothicFont)));
                clientTable.AddCell(new PdfPCell(new Phrase(factura.Cliente.TipoPersona, gothicFont)));

                document.Add(clientTable);

                PdfPTable itemTable = new PdfPTable(6) { WidthPercentage = 100 };
                itemTable.SpacingBefore = 10;
                itemTable.SetWidths(new float[] { 1, 1, 3, 1, 1, 1 });

                itemTable.AddCell(new PdfPCell(new Phrase("ITEM", gothicFont))
                {
                    BackgroundColor = new BaseColor(64, 64, 64),
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    PaddingTop = 5f,
                    PaddingBottom = 5f,
                    Phrase = new Phrase("ITEM", new Font(baseFont, 11, Font.BOLD, BaseColor.WHITE))
                });
                itemTable.AddCell(new PdfPCell(new Phrase("COD", gothicFont))
                {
                    BackgroundColor = new BaseColor(64, 64, 64),
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    PaddingTop = 5f,
                    PaddingBottom = 5f,
                    Phrase = new Phrase("ID", new Font(baseFont, 11, Font.BOLD, BaseColor.WHITE))
                });
                itemTable.AddCell(new PdfPCell(new Phrase("Descripcion", gothicFont))
                {
                    BackgroundColor = new BaseColor(64, 64, 64),
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    PaddingTop = 5f,
                    PaddingBottom = 5f,
                    Phrase = new Phrase("Descripcion", new Font(baseFont, 11, Font.BOLD, BaseColor.WHITE))
                });
                itemTable.AddCell(new PdfPCell(new Phrase("CANTIDAD", gothicFont))
                {
                    BackgroundColor = new BaseColor(64, 64, 64),
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    PaddingTop = 5f,
                    PaddingBottom = 5f,
                    Phrase = new Phrase("CANTIDAD", new Font(baseFont, 11, Font.BOLD, BaseColor.WHITE))
                });
                itemTable.AddCell(new PdfPCell(new Phrase("VALOR UNITARIO", gothicFont))
                {
                    BackgroundColor = new BaseColor(64, 64, 64),
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    PaddingTop = 5f,
                    PaddingBottom = 5f,
                    Phrase = new Phrase("VALOR UNITARIO", new Font(baseFont, 11, Font.BOLD, BaseColor.WHITE))
                });
                itemTable.AddCell(new PdfPCell(new Phrase("TOTAL", gothicFont))
                {
                    BackgroundColor = new BaseColor(64, 64, 64),
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    PaddingTop = 5f,
                    PaddingBottom = 5f,
                    Phrase = new Phrase("TOTAL", new Font(baseFont, 11, Font.BOLD, BaseColor.WHITE))
                });

                double subtotal = 0;
                int itemNumber = 1;
                foreach (var item in factura.Items)
                {
                    double totalItem = item.Cantidad * item.Juego.Precio;
                    subtotal += totalItem;
                    itemTable.AddCell(new PdfPCell(new Phrase(itemNumber.ToString(), gothicFont)));
                    itemTable.AddCell(new PdfPCell(new Phrase(item.Id.ToString(), gothicFont)));
                    itemTable.AddCell(new PdfPCell(new Phrase(item.Juego.Titulo, gothicFont)));
                    itemTable.AddCell(new PdfPCell(new Phrase(item.Cantidad.ToString(), gothicFont)));

                    itemTable.AddCell(new PdfPCell(new Phrase(item.Juego.Precio.ToString("C"), gothicFontSmall)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    itemTable.AddCell(new PdfPCell(new Phrase(totalItem.ToString("C"), gothicFontSmall)) { HorizontalAlignment = Element.ALIGN_CENTER });
                    itemNumber++;
                }
                document.Add(itemTable);

                double ivaAmount = subtotal * factura.IVA / 100;
                double totalConIVA = subtotal + ivaAmount;

                PdfPTable summaryTable = new PdfPTable(3);
                summaryTable.WidthPercentage = 100;
                summaryTable.SpacingBefore = 10;

                PdfPCell observationsCell = new PdfPCell(new Phrase($"Observaciones:\n{factura.Observaciones}", gothicFont));
                observationsCell.Colspan = 2;
                summaryTable.AddCell(observationsCell);

                PdfPCell qrCell = new PdfPCell(ServiciosImagen.ConvertirBytesAImagenPDF(factura.CodigoQR));
                qrCell.HorizontalAlignment = Element.ALIGN_CENTER;
                qrCell.Border = PdfPCell.NO_BORDER;
                summaryTable.AddCell(qrCell);

                PdfPCell subtotalCell = new PdfPCell(new Phrase($"SubTotal: {subtotal:C}", gothicFont));
                summaryTable.AddCell(subtotalCell);
                PdfPCell ivaCell = new PdfPCell(new Phrase($"IVA ({factura.IVA}%): {ivaAmount:C}", gothicFont));
                summaryTable.AddCell(ivaCell);
                PdfPCell totalCell = new PdfPCell(new Phrase($"Total a pagar COP: {totalConIVA:C}", gothicFontSmall));
                summaryTable.AddCell(totalCell);

                document.Add(summaryTable);

                document.Add(new Phrase($"\nMétodo de pago: {factura.MedioPago.Descripcion}\n", gothicFont));
                document.Add(new Phrase($"Total de ítems: {factura.Items.Count}\n", gothicFont));

                document.Add(new Phrase("Esta no es una factura real, es hecha con fines educativos.\n", gothicFont));

                document.Close();
            }

            return path;
        }

        public static XDocument ConvertirFacturaAXml(Factura factura)
        {
            XNamespace cac = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";
            XNamespace cbc = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
            XNamespace ext = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2";

            var xml = new XDocument(
                new XDeclaration("1.0", "utf-8", "no"),
                new XElement("AttachedDocument",
                    new XAttribute(XNamespace.Xmlns + "cac", cac),
                    new XAttribute(XNamespace.Xmlns + "cbc", cbc),
                    new XAttribute(XNamespace.Xmlns + "ext", ext),

                    // Información del documento principal
                    new XElement(cbc + "ID", factura.Id),
                    new XElement(cbc + "IssueDate", factura.Fecha.ToString("yyyy-MM-dd")),
                    new XElement(cbc + "IssueTime", factura.Hora.ToString("HH:mm:ss")),
                    new XElement(cbc + "DocumentType", "Contenedor de Factura Electrónica"),

                    // Datos del cliente
                    new XElement(cac + "ReceiverParty",
                        new XElement(cac + "PartyTaxScheme",
                            new XElement(cbc + "RegistrationName", $"{factura.Cliente.PrimerNombre} {factura.Cliente.PrimerApellido}"),
                            new XElement(cbc + "CompanyID", factura.Cliente.NumeroIdentificacion),
                            new XElement(cbc + "TaxLevelCode", "R-99-PN")
                        )
                    ),

                    // Datos del usuario (emisor de la factura)
                    new XElement(cac + "SenderParty",
                        new XElement(cac + "PartyTaxScheme",
                            new XElement(cbc + "RegistrationName", $"{factura.Usuario.PrimerNombre} {factura.Usuario.PrimerApellido}"),
                            new XElement(cbc + "CompanyID", factura.Usuario.NumeroIdentificacion),
                            new XElement(cbc + "TaxLevelCode", "R-99-PN")
                        )
                    ),

                    // Información de los ítems de la factura
                    new XElement(cac + "InvoiceLine",
                        new XElement(cbc + "LineCountNumeric", factura.Items.Count),
                        new XElement(cbc + "InvoiceTypeCode", "01"),
                        from item in factura.Items
                        select new XElement(cac + "InvoiceLine",
                            new XElement(cbc + "ID", item.Id),
                            new XElement(cbc + "InvoicedQuantity", item.Cantidad),
                            new XElement(cbc + "LineExtensionAmount", item.Subtotal),
                            new XElement(cac + "Item",
                                new XElement(cbc + "Description", item.Juego.Titulo),
                                new XElement(cac + "SellersItemIdentification",
                                    new XElement(cbc + "ID", item.Juego.Id)
                                )
                            ),
                            new XElement(cac + "Price",
                                new XElement(cbc + "PriceAmount", item.Juego.Precio)
                            )
                        )
                    ),

                    // Totales (subtotales, IVA, y total)
                    new XElement(cac + "LegalMonetaryTotal",
                        new XElement(cbc + "LineExtensionAmount", factura.Total),
                        new XElement(cbc + "TaxExclusiveAmount", factura.Total - (factura.Total * factura.IVA / 100)),
                        new XElement(cbc + "TaxInclusiveAmount", factura.Total),
                        new XElement(cbc + "PayableAmount", factura.Total)
                    ),

                    // Observaciones
                    new XElement(cbc + "Note", factura.Observaciones),

                    // Información del medio de pago
                    new XElement(cbc + "PaymentMeans",
                        new XElement(cbc + "PaymentMeansCode", factura.MedioPago.Descripcion), // El código o descripción del medio de pago
                        new XElement(cbc + "PaymentDueDate", factura.Fecha.AddDays(30).ToString("yyyy-MM-dd")) // Fecha de vencimiento (por ejemplo, 30 días después)
                    )
                )
            );

            return xml;
        }


        public static string ConvertirFacturaAXmlString(XDocument xmlFactura)
        {
            return xmlFactura.ToString();
        }

    }
}