using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormularioJuegos : Form
    {
        private readonly ServiciosJuegos serviciosJuegos;

        public FormularioJuegos()
        {
            InitializeComponent();
            serviciosJuegos = new ServiciosJuegos();
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos(List<Juego> juegos)
        {
            dgvJuegos.Rows.Clear();

            foreach (Juego juego in juegos)
            {
                dgvJuegos.Rows.Add(null, null, juego.Id, juego.Titulo, juego.AnioLanzamiento, juego.Formato,
                    juego.Categoria.Descripcion, juego.Plataforma.Descripcion, null);
            }
            dgvJuegos.CurrentCell = null;
        }

        private void Eliminar(string id)
        {
            string mensaje = serviciosJuegos.Eliminar(id);
            MessageBox.Show(mensaje);
        }

        private void AbrirFormOscurecer(Form formHijo)
        {
            using (Form formBG = new Form())
            {
                formBG.StartPosition = FormStartPosition.Manual;
                formBG.FormBorderStyle = FormBorderStyle.None;
                formBG.Opacity = 0.70d;
                formBG.BackColor = Color.Black;
                formBG.WindowState = FormWindowState.Maximized;
                formBG.TopMost = false;
                formBG.Location = this.Location;
                formBG.ShowInTaskbar = false;
                formBG.Show();

                formHijo.Owner = formBG;
                formHijo.BringToFront();
                formHijo.ShowDialog();
            }
        }

        private void Verificacion(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string id = dgvJuegos.Rows[e.RowIndex].Cells[2].Value?.ToString();

            switch (e.ColumnIndex)
            {
                case 0:
                    ConfirmarEliminacion(id);
                    break;

                case 1:
                    AbrirFormularioModificarJuego(id);
                    break;

                case 8:
                    MostrarPortadaJuego(id);
                    break;
            }
        }

        private void ConfirmarEliminacion(string id)
        {
            if (string.IsNullOrEmpty(id)) return;

            var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este juego?", 
                "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Eliminar(id);
                CargarDatos(serviciosJuegos.ObtenerTodo());
            }
        }

        private void AbrirFormularioModificarJuego(string id)
        {
            if (string.IsNullOrEmpty(id)) return;

            Juego juego = serviciosJuegos.BuscarPorId(id);
            if (juego == null)
            {
                MessageBox.Show("Juego no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormularioNuevoJuego nuevoJuegoForm = new FormularioNuevoJuego(juego, "Modificar");
            nuevoJuegoForm.DatosActualizados += () => CargarDatos(serviciosJuegos.ObtenerTodo());
            AbrirFormOscurecer(nuevoJuegoForm);
        }

        private void MostrarPortadaJuego(string id)
        {
            if (string.IsNullOrEmpty(id)) return;
            Juego juego = serviciosJuegos.BuscarPorId(id);
            Image portada = ServiciosImagen.ConvertirBytesAImagen(juego.Portada);
            AbrirFormOscurecer(new FormularioPortada(juego.Titulo, portada));
        }

        private void FiltrarPorAnios()
        {
            int anioInicio = txtAnioInicio.Text == "" ? 0 : int.Parse(txtAnioInicio.Text);
            int anioFin = txtAnioFin.Text == "" ? 0 : int.Parse(txtAnioFin.Text);
            List<Juego> juegos = serviciosJuegos.FiltrarPorAnios(anioInicio, anioFin);
            CargarDatos(juegos);
        }

        private DataGridView CrearNuevoDGV()
        {
            DataGridView nuevoDGV = new DataGridView
            {
                AutoGenerateColumns = false,
            };

            nuevoDGV.Columns.Add("Id", "ID");
            nuevoDGV.Columns.Add("Titulo", "Título");
            nuevoDGV.Columns.Add("Formato", "Formato");
            nuevoDGV.Columns.Add("AnioLanzamiento", "Año de Lanzamiento");
            nuevoDGV.Columns.Add("Precio", "Precio");
            nuevoDGV.Columns.Add("Stock", "Stock");
            nuevoDGV.Columns.Add("Categoria", "Categoría");
            nuevoDGV.Columns.Add("Plataforma", "Plataforma");

            foreach (DataGridViewRow fila in dgvJuegos.Rows)
            {
                var valoresFila = new List<object>();

                string idJuego = fila.Cells[2].Value?.ToString();

                if (string.IsNullOrEmpty(idJuego)) continue;

                Juego juego = serviciosJuegos.BuscarPorId(idJuego);
                if (juego != null)
                {
                    valoresFila.Add(juego.Id);
                    valoresFila.Add(juego.Titulo);
                    valoresFila.Add(juego.Formato);
                    valoresFila.Add(juego.AnioLanzamiento);
                    valoresFila.Add(juego.Precio);
                    valoresFila.Add(juego.Stock);
                    valoresFila.Add(juego.Categoria.Descripcion);
                    valoresFila.Add(juego.Plataforma.Descripcion);

                    nuevoDGV.Rows.Add(valoresFila.ToArray());
                }
            }

            return nuevoDGV;
        }

        private string SeleccionarRuta()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string rutaSeleccionada = folderBrowserDialog.SelectedPath;
                    string archivoDestino = Path.Combine(rutaSeleccionada, "TablaJuegos.xlsx");

                    if (!archivoDestino.EndsWith(".xlsx"))
                    {
                        archivoDestino += ".xlsx";
                    }

                    return archivoDestino;
                }
            }

            return string.Empty;
        }
        private void dgvJuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Verificacion(e);
        }

        private void FormularioJuegos_Load(object sender, EventArgs e)
        {
            CargarDatos(serviciosJuegos.ObtenerTodo());
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            FormularioNuevoJuego nuevoJuegoForm = new FormularioNuevoJuego(null, "");
            nuevoJuegoForm.DatosActualizados += () => CargarDatos(serviciosJuegos.ObtenerTodo());
            AbrirFormOscurecer(nuevoJuegoForm);
        }

        private void BtFiltrarAnios_Click(object sender, EventArgs e)
        {
            if (txtAnioInicio.Text == "")
            {
                MessageBox.Show("Ingrese un año de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FiltrarPorAnios();
            }
        }

        private void BtNuevoJuego_Click(object sender, EventArgs e)
        {
            FormularioNuevoJuego nuevoJuegoForm = new FormularioNuevoJuego(null, "");
            nuevoJuegoForm.DatosActualizados += () => CargarDatos(serviciosJuegos.ObtenerTodo());
            AbrirFormOscurecer(nuevoJuegoForm);
        }

        private void BtExportarExcel_Click(object sender, EventArgs e)
        {
            DataGridView dgvExcel = CrearNuevoDGV();
            string ruta = SeleccionarRuta();
            var mensaje = ServiciosExcel.ExportarExcel(dgvExcel, ruta);
            MessageBox.Show(mensaje);
        }
    }
}