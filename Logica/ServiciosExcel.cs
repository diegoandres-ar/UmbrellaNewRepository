using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Logica
{
    public static class ServiciosExcel
    {
        public static string ExportarExcel(DataGridView dgv, string archivoDestino)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.AddWorksheet("Hoja1");

                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        var cell = worksheet.Cell(1, i + 1);
                        cell.Value = dgv.Columns[i].HeaderText;
                        cell.Style.Font.Bold = true;
                        cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        cell.Style.Fill.BackgroundColor = XLColor.LightGray;
                        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    }

                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            var cell = worksheet.Cell(i + 2, j + 1);
                            cell.Value = XLCellValue.FromObject(dgv.Rows[i].Cells[j].Value);
                            cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        }
                    }

                    worksheet.Columns().AdjustToContents();

                    workbook.SaveAs(archivoDestino);
                }

                return "Archivo exportado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al exportar archivo: " + ex.Message;
            }
        }
    }
}