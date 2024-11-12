using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentacion
{
    public partial class FormularioFinalizarCompra : Form
    {
        ServiciosClientes serviciosClientes;
        ServiciosUsuarios serviciosUsuarios;
        ServiciosFacturas serviciosFacturas;
        ServiciosMediosPagos serviciosMediosPagos;
        ServiciosItemsFactura serviciosItemsFactura;
        ServiciosInventario serviciosInventario;
        List<Item> itemsFactura;
        double totalFactura;
        double IVA;
        Usuario usuarioLogueado;
        Cliente cliente;
        FormularioCarrito formularioCarrito;
        public FormularioFinalizarCompra(List<Item> items, double totalFactura, double IVA, 
            Usuario usuarioLogueado, FormularioCarrito formularioCarrito)
        {
            InitializeComponent();
            serviciosClientes = new ServiciosClientes();
            serviciosUsuarios = new ServiciosUsuarios();
            serviciosFacturas = new ServiciosFacturas();
            serviciosMediosPagos = new ServiciosMediosPagos();
            serviciosItemsFactura = new ServiciosItemsFactura();
            serviciosInventario = new ServiciosInventario();
            itemsFactura = items;
            this.totalFactura = totalFactura;
            this.IVA = IVA;
            this.usuarioLogueado = usuarioLogueado;
            this.formularioCarrito = formularioCarrito;
        }

        private void CargarComboMediosPagos()
        {
            List<MedioPago> mediosPagos = serviciosMediosPagos.ObtenerTodo();
            comboMedioPago.DataSource = mediosPagos;
            comboMedioPago.DisplayMember = "Descripcion";
            comboMedioPago.ValueMember = "Id";
        }

        private void InsertarDatos()
        {
            labelTotal.Text = totalFactura.ToString() + " $";
        }

        private void GenerarQR()
        {
            string codigo = serviciosFacturas.GenerarId();
            Zen.Barcode.CodeQrBarcodeDraw qr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            Image imgQr = qr.Draw(codigo, 50);
            Bitmap bmp = new Bitmap(imgQr, pictureQr.Width - 10, pictureQr.Height - 10);
            pictureQr.Image = bmp;
        }

        private void TecladoPantalla(string numero)
        {
            if (txtEfectivo.Enabled == false) return;
            if (txtEfectivo.Text == "0")
            {
                txtEfectivo.Text = numero;
            }
            else
            {
                txtEfectivo.Text += numero;
            }
        }

        private bool VerificarEfectivo()
        {
            double efectivo = txtEfectivo.Text == "" ? 0 : Convert.ToDouble(txtEfectivo.Text);
            double efectivoValido = serviciosFacturas.CalcularCambio(totalFactura, efectivo);
            if (efectivoValido < 0)
            {
                labelCambio2.ForeColor = Color.Red;
                labelCambio2.Text = efectivoValido.ToString();
                return false;
            }
            else
            {
                labelCambio2.ForeColor = Color.Green;
                labelCambio2.Text = efectivoValido.ToString();
                return true;
            }
        }

        private void BuscarClientePorId()
        {
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Ingrese un documento");
            }
            cliente = serviciosClientes.BuscarPorId(txtDocumento.Text);
        }

        private void InsertarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado");
                return;
            }
            txtNombreCliente.Text = cliente.PrimerNombre + " " + cliente.SegundoNombre
                + " " + cliente.PrimerApellido + " " + cliente.SegundoApellido;
        }

        private Factura GuardarFactura()
        {
            string id = serviciosFacturas.GenerarId();
            DateTime fecha = DateTime.Now;
            DateTime hora = DateTime.Now;
            MedioPago medioPago = serviciosMediosPagos.BuscarPorId(comboMedioPago.SelectedValue.ToString());
            string observaciones = txtObservaciones.Text.ToUpper();
            byte[] codigoQr = ServiciosImagen.ConvertirImagenABytes(pictureQr.Image);
            Factura factura = new Factura(id, cliente, usuarioLogueado, fecha, hora, itemsFactura, IVA, 
                medioPago, observaciones, codigoQr, totalFactura);
            var mensaje = serviciosFacturas.Guardar(factura);

            foreach (Item item in itemsFactura)
            {
                item.Id = serviciosItemsFactura.GenerarId();
                serviciosItemsFactura.Guardar(item, factura.Id);
            }
            serviciosInventario.DisminuirCantidadJuegos(factura);
            MessageBox.Show(mensaje);
            return factura;
        }

        private string SeleccionarRutaFactura()
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


        private void BorrarUltimoDigito()
        {
            if (txtEfectivo.Text.Length > 1)
            {
                txtEfectivo.Text = txtEfectivo.Text.Substring(0, txtEfectivo.Text.Length - 1);
            }
            else
            {
                txtEfectivo.Text = "0";
            }
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Teclado
        private void Bt1_Click(object sender, EventArgs e)
        {
            TecladoPantalla("1");
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            TecladoPantalla("2");
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            TecladoPantalla("3");
        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            TecladoPantalla("4");
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            TecladoPantalla("5");
        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            TecladoPantalla("6");
        }

        private void Bt7_Click(object sender, EventArgs e)
        {
            TecladoPantalla("7");
        }

        private void Bt8_Click(object sender, EventArgs e)
        {
            TecladoPantalla("8");
        }

        private void Bt9_Click(object sender, EventArgs e)
        {
            TecladoPantalla("9");
        }

        private void Bt0_Click(object sender, EventArgs e)
        {
            TecladoPantalla("0");
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            BorrarUltimoDigito();
        }

        #endregion
        private void BtBuscar_Click(object sender, EventArgs e)
        {
            BuscarClientePorId();
            InsertarCliente(cliente);
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            VerificarEfectivo();
        }

        private void BtVistaPrevia_Click(object sender, EventArgs e)
        {
            Factura factura = GuardarFactura();
            string ruta = SeleccionarRutaFactura();
            if (ruta != string.Empty)
            {
                string rutaPath = ServiciosFormatoFactura.ConvertirFacturaPDF(factura, ruta);
                AbrirFormOscurecer(new FormularioVistaPreviaFactura(rutaPath, formularioCarrito));
                this.Close();
            }
        }

        private async void EscogerMedioDeEnvio(string rutaPdf, Factura factura)
        {
            string medioEnvio = comboMedioEnvio.SelectedItem.ToString();
            string mensaje = string.Empty;

            if (medioEnvio == "CORREO ELECTRÓNICO")
            {
                mensaje = new ServicioEnvioCorreoElectronico().EnviarFacturaPorCorreo(rutaPdf, cliente);
            }
            else if (medioEnvio == "WHATSAPP")
            {
                ServicioEnvioWhatsApp servicioWhatsApp = new ServicioEnvioWhatsApp();
                string linkFactura = await ServiciosDropBox.UploadFileToDropboxAsync(rutaPdf);

                if (!string.IsNullOrEmpty(linkFactura))
                {
                    mensaje = await servicioWhatsApp.EnviarFacturaWhatsApp(factura, linkFactura);
                }
                else
                {
                    mensaje = "Error al subir el archivo a WhatsApp.";
                }
            }
            MessageBox.Show(mensaje);
        }

        private void BtEnviar_Click(object sender, EventArgs e)
        {
            if (VerificarEfectivo())
            {
                Factura factura = GuardarFactura();
                string ruta = SeleccionarRutaFactura();
                if (ruta != string.Empty)
                {
                    string path = ServiciosFormatoFactura.ConvertirFacturaPDF(factura, ruta);
                    EscogerMedioDeEnvio(path, factura);
                    formularioCarrito.LimpiarTodo();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Efectivo insuficiente");
            }
        }

        private void AbrirFormOscurecer(Form formHijo)
        {
            Form formBG = new Form();
            formBG.StartPosition = FormStartPosition.Manual;
            formBG.FormBorderStyle = FormBorderStyle.None;
            formBG.Opacity = .70d;
            formBG.BackColor = Color.Black;
            formBG.WindowState = FormWindowState.Maximized;
            formBG.TopMost = false;
            formBG.Location = this.Location;
            formBG.ShowInTaskbar = false;
            formBG.Show();

            formHijo.Owner = formBG;
            formHijo.BringToFront();
            formHijo.ShowDialog();
            formBG.Dispose();
        }

        private void FormularioFinalizarCompra_Load(object sender, EventArgs e)
        {
            InsertarDatos();
            CargarComboMediosPagos();
            GenerarQR();
            txtEfectivo.Focus();
        }
    }
}
