using Logica;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormularioReportes : Form
    {
        public FormularioReportes()
        {
            InitializeComponent();
        }

        private void ResaltarPicture(PictureBox picture)
        {
            picture.BackColor = Color.LightBlue;
        }

        private void QuitarResalto()
        {
            if(picturePanelJuegos.BackColor == Color.LightBlue)
                picturePanelJuegos.BackColor = Color.FromArgb(244, 248, 251);
            if(pictureReporteGeneral.BackColor == Color.LightBlue)
                pictureReporteGeneral.BackColor = Color.FromArgb(244, 248, 251);
            if(picturePanelVentas.BackColor == Color.LightBlue)
                picturePanelVentas.BackColor = Color.FromArgb(244, 248, 251);
        }

        private void OcultarPanelFiltro()
        {
            panelFiltro.Visible = false;
            panelFiltro.Size = new Size(0, 0);
            panelFiltro.Enabled = false;
        }

        private void MostrarPanelFiltro()
        {
            panelFiltro.Visible = true;
            panelFiltro.Size = new Size(1200, 42);
            panelFiltro.Enabled = true;
        }

        private void RedondearPictures()
        {
            RedondearPictureBox(picturePanelJuegos, 30);
            RedondearPictureBox(pictureReporteGeneral, 30);
            RedondearPictureBox(picturePanelVentas, 30);
        }

        public void RedondearPictureBox(PictureBox pictureBox, int radio)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            graphicsPath.AddArc(new Rectangle(pictureBox.Width - radio, 0, radio, radio), 270, 90);
            graphicsPath.AddArc(new Rectangle(pictureBox.Width - radio, pictureBox.Height - radio, radio, radio), 0, 90);
            graphicsPath.AddArc(new Rectangle(0, pictureBox.Height - radio, radio, radio), 90, 90);
            graphicsPath.CloseFigure();
            pictureBox.Region = new Region(graphicsPath);
        }

        private string SeleccionarRutaReporte()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return folderBrowserDialog.SelectedPath;
                }
            }

            return string.Empty;
        }

        private void InsertarAlPdfViewer(string rutaPdf)
        {
            if (System.IO.File.Exists(rutaPdf))
            {
                pdfViewerReportes.Document = PdfDocument.Load(rutaPdf);
            }
            else
            {
                MessageBox.Show("El archivo PDF no existe en la ruta especificada.");
            }
        }

        private void FormularioReportes_Load(object sender, EventArgs e)
        {
            RedondearPictures();
            OcultarPanelFiltro();
        }

        private void picturePanelJuegos_Click(object sender, EventArgs e)
        {
            QuitarResalto();
            OcultarPanelFiltro();
            ResaltarPicture(picturePanelJuegos);
            string ruta = SeleccionarRutaReporte();
            if (!string.IsNullOrEmpty(ruta))
            {
                var mensaje = ServiciosReportesPdf.GenerarReporteVideojuegosPDF(ruta);
                MessageBox.Show(mensaje);
                string rutaPdf = Path.Combine(ruta, "Reporte_Videojuegos.pdf");
                InsertarAlPdfViewer(rutaPdf);
            }
        }

        private void picturePanelVentas_Click(object sender, EventArgs e)
        {
            QuitarResalto();
            MostrarPanelFiltro();
            ResaltarPicture(picturePanelVentas);
        }

        private void pictureReporteGeneral_Click(object sender, EventArgs e)
        {
            QuitarResalto();
            MostrarPanelFiltro();
            ResaltarPicture(pictureReporteGeneral);
        }
    }
}
