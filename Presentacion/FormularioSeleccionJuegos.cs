using Entidades;
using Logica;
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
    public partial class FormularioSeleccionJuegos : Form
    {
        private ServiciosJuegos serviciosJuegos;
        private List<Juego> juegosSeleccionados;
        public event Action<List<Juego>> DatosActualizados;
        FormularioCarrito formularioCarrito;
        public FormularioSeleccionJuegos(List<Juego> juegoSeleccionados, FormularioCarrito formCarrito)
        {
            InitializeComponent();
            serviciosJuegos = new ServiciosJuegos();
            juegosSeleccionados = juegoSeleccionados;
            formularioCarrito = formCarrito;
        }

        private void CargarDatos(List<Juego> juegos)
        {
            dgvJuegos.Rows.Clear();
            foreach (Juego juego in juegos)
            {
                dgvJuegos.Rows.Add(null, juego.Id, juego.Titulo, juego.Categoria.Descripcion, 
                    juego.AnioLanzamiento, juego.Stock, juego.Precio, null);
            }
        }

        private void FormularioSeleccionJuegos_Load(object sender, EventArgs e)
        {
            CargarDatos(serviciosJuegos.ObtenerTodo());
        }

        private void VerPortada(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                Juego juego = serviciosJuegos.BuscarPorId(dgvJuegos.Rows[e.RowIndex].Cells[1].Value.ToString());
                Image portada = ServiciosImagen.ConvertirBytesAImagen(juego.Portada);
                AbrirFormOscurecer(new FormularioPortada(juego.Titulo,portada));
            }
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

        private void BuscarJuegosSeleccionados()
        {
            juegosSeleccionados = new List<Juego>();
            foreach (DataGridViewRow row in dgvJuegos.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Juego juego = serviciosJuegos.BuscarPorId(row.Cells[1].Value.ToString());
                    juegosSeleccionados.Add(juego);
                }
            }
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvJuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VerPortada(e);
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            BuscarJuegosSeleccionados();
            DatosActualizados?.Invoke(juegosSeleccionados);
            formularioCarrito.CalcularTotalItem();
            formularioCarrito.CalcularSubTotalCarrito();
            this.Close();
        }
    }
}
