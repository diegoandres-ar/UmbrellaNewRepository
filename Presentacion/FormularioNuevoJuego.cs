using Entidades;
using Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormularioNuevoJuego : Form
    {
        ServiciosJuegos serviciosJuegos;
        ServiciosCategorias serviciosCategorias;
        ServiciosPlataformas serviciosPlataformas;
        public event Action DatosActualizados;
        string idModificar;

        public FormularioNuevoJuego(Juego juego, string op)
        {
            InitializeComponent();
            serviciosJuegos = new ServiciosJuegos();
            serviciosCategorias = new ServiciosCategorias();
            serviciosPlataformas = new ServiciosPlataformas();
            CargarComboCategorias();
            CargarComboPlataformas();
            idModificar = juego?.Id ?? "0";
            InsertarDatos(juego, op);
            DesactivarControles(juego, op);
            GenerarCodigoBarras(serviciosJuegos.GenerarId());
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            DatosActualizados?.Invoke();
            this.Close();
        }

        private void Guardar()
        {
            string id = serviciosJuegos.GenerarId();
            string titulo = txtTitulo.Text.Trim().ToUpper();
            int anioLanzamiento = int.Parse(txtAnioLanzamiento.Text);
            double precio = double.Parse(txtPrecio.Text);
            int stock = int.Parse(txtStock.Text);
            string formato = comboFormato.Text;
            Categoria categoria = serviciosCategorias.BuscarPorId(comboCategoria.SelectedValue.ToString());
            Plataforma plataforma = serviciosPlataformas.BuscarPorId(comboPlataforma.SelectedValue.ToString());
            byte[] portada = ServiciosImagen.ConvertirImagenABytes(picPortada.Image);

            Juego juego = new Juego(id, titulo, formato, portada, anioLanzamiento, 
                precio, stock, categoria, plataforma);
            var mensaje = serviciosJuegos.Guardar(juego);
            MessageBox.Show(mensaje, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Modificar()
        {
            string id = idModificar;
            string titulo = txtTitulo.Text.Trim().ToUpper();
            int anioLanzamiento = int.Parse(txtAnioLanzamiento.Text);
            double precio = double.Parse(txtPrecio.Text);
            int stock = int.Parse(txtStock.Text);
            string formato = comboFormato.Text;
            Categoria categoria = serviciosCategorias.BuscarPorId(comboCategoria.SelectedValue.ToString());
            Plataforma plataforma = serviciosPlataformas.BuscarPorId(comboPlataforma.SelectedValue.ToString());
            byte[] portada = ServiciosImagen.ConvertirImagenABytes(picPortada.Image);

            Juego juego = new Juego(id, titulo, formato, portada, anioLanzamiento,
               precio, stock, categoria, plataforma);
            var mensaje = serviciosJuegos.Modificar(juego);
            MessageBox.Show(mensaje, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InsertarDatos(Juego juego, string op)
        {
            if (juego != null)
            {
                labelCodigo.Text = juego.Id;
                txtTitulo.Text = juego.Titulo;
                txtAnioLanzamiento.Text = juego.AnioLanzamiento.ToString();
                comboFormato.Text = juego.Formato;
                comboCategoria.SelectedValue = juego.Categoria.Id;
                comboPlataforma.SelectedValue = juego.Plataforma.Id;
                txtPrecio.Text = juego.Precio.ToString();
                txtStock.Text = juego.Stock.ToString();
                Image portada = ServiciosImagen.ConvertirBytesAImagen(juego.Portada);
                Bitmap bitmap = new Bitmap(portada, picPortada.Width, picPortada.Height);
                picPortada.Image = bitmap;
            }
        }

        private void DesactivarControles(Juego juego, string op)
        {
            if (juego != null)
            {
                BtGuardar.Text = op;
            }
        }

        private void GenerarCodigoBarras(string codigo)
        {
            labelCodigo.Text = codigo;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            Image imgCodigo = barcode.Draw(codigo,60);
            Bitmap bmp = new Bitmap(imgCodigo, pictureCB.Width - 10, pictureCB.Height - 10);
            pictureCB.Image = bmp;
        }
        private void Limpiar()
        {
            txtTitulo.Clear();
            txtAnioLanzamiento.Clear();
            comboFormato.SelectedIndex = 0;
            comboCategoria.SelectedIndex = 0;
            comboPlataforma.SelectedIndex = 0;
            picPortada.Image = null;
            BtGuardar.Text = "Guardar";
            BtCargar.Enabled = true;
            BtCargar.Visible = true;
            labelMax.Visible = true;
        }

        private void CargarComboCategorias()
        {
            comboCategoria.DataSource = serviciosCategorias.ObtenerTodo();
            comboCategoria.DisplayMember = "Descripcion";
            comboCategoria.ValueMember = "Id";
        }

        private void CargarComboPlataformas()
        {
            comboPlataforma.DataSource = serviciosPlataformas.ObtenerTodo();
            comboPlataforma.DisplayMember = "Descripcion";
            comboPlataforma.ValueMember = "Id";
        }

        private void CargarImagen()
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg";
            dialogo.Title = "Seleccionar imagen";
            dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(dialogo.FileName);
                if (fileInfo.Length > 3 * 1024 * 1024)
                {
                    MessageBox.Show("El archivo seleccionado es mayor a 3 MB. Por favor, seleccione un archivo más pequeño.", 
                        "Archivo demasiado grande", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    picPortada.Image = Image.FromFile(dialogo.FileName);
                }
            }
        }

        private void Operacion()
        {
            if (BtGuardar.Text == "Guardar")
            {
                Guardar();
            }
            else
            {
                Modificar();
            }
        }

        private void ExportarCodigoBarras()
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "Archivos de imagen|*.png";
            dialogo.Title = "Guardar imagen";
            dialogo.FileName = labelCodigo.Text;
            dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                pictureCB.Image.Save(dialogo.FileName);
            }
        }
        private void BtCargar_Click(object sender, EventArgs e)
        {
            CargarImagen();
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            Operacion();
            Limpiar();
        }

        private void BtExportarCodigo_Click(object sender, EventArgs e)
        {
            ExportarCodigoBarras();
        }
    }
}
