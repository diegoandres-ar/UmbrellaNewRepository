using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormularioVistaPreviaFactura : Form
    {
        FormularioCarrito formularioCarrito;
        public FormularioVistaPreviaFactura(string rutaPdf, FormularioCarrito formularioCarrito)
        {
            InitializeComponent();
            CargarFactura(rutaPdf);
            this.formularioCarrito = formularioCarrito;
        }

        private void CargarFactura(string rutaPdf)
        {
            if (System.IO.File.Exists(rutaPdf))
            {
                pdfFactura.Document = PdfiumViewer.PdfDocument.Load(rutaPdf);
            }
            else
            {
                MessageBox.Show("No se encontró el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            formularioCarrito.LimpiarTodo();
            this.Close();
        }
    }
}
