using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormularioConfiguraciones : Form
    {
        public FormularioConfiguraciones()
        {
            InitializeComponent();
        }

        private void RedondearPictures()
        {
            RedondearPictureBox(BtUsuarios, 50);
            RedondearPictureBox(BtCategorias, 50);
            RedondearPictureBox(BtPlataformas, 50);
            RedondearPictureBox(BtClientes, 50);
            RedondearPictureBox(BtPermisos, 50);
            RedondearPictureBox(BtTiposDocumento, 50);
            RedondearPictureBox(BtMediosPago, 50);
        }

        private void ResaltarPicture(PictureBox pictureBox)
        {
            pictureBox.BackColor = Color.FromArgb(215, 217, 220);
        }

        private void PictureDefecto(PictureBox pictureBox)
        {
            pictureBox.BackColor = Color.FromArgb(242, 245, 249);
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

        #region Eventos de los PictureBox

        private void BtCategorias_MouseEnter(object sender, EventArgs e)
        {
            ResaltarPicture(BtCategorias);
        }

        private void BtCategorias_MouseLeave(object sender, EventArgs e)
        {
            PictureDefecto(BtCategorias);
        }

        private void BtPlataformas_MouseEnter(object sender, EventArgs e)
        {
            ResaltarPicture(BtPlataformas);
        }

        private void BtPlataformas_MouseLeave(object sender, EventArgs e)
        {
            PictureDefecto(BtPlataformas);
        }

        private void BtMediosPago_MouseEnter(object sender, EventArgs e)
        {
            ResaltarPicture(BtMediosPago);
        }

        private void BtMediosPago_MouseLeave(object sender, EventArgs e)
        {
            PictureDefecto(BtMediosPago);
        }

        private void BtClientes_MouseEnter(object sender, EventArgs e)
        {
            ResaltarPicture(BtClientes);
        }

        private void BtClientes_MouseLeave(object sender, EventArgs e)
        {
            PictureDefecto(BtClientes);
        }

        private void BtTiposDocumento_MouseEnter(object sender, EventArgs e)
        {
            ResaltarPicture(BtTiposDocumento);
        }

        private void BtTiposDocumento_MouseLeave(object sender, EventArgs e)
        {
            PictureDefecto(BtTiposDocumento);
        }

        private void BtUsuarios_MouseEnter(object sender, EventArgs e)
        {
            ResaltarPicture(BtUsuarios);
        }

        private void BtUsuarios_MouseLeave(object sender, EventArgs e)
        {
            PictureDefecto(BtUsuarios);
        }

        private void BtPermisos_MouseEnter(object sender, EventArgs e)
        {
            ResaltarPicture(BtPermisos);
        }

        private void BtPermisos_MouseLeave(object sender, EventArgs e)
        {
            PictureDefecto(BtPermisos);
        }
        #endregion

        private void FormularioConfiguraciones_Load(object sender, EventArgs e)
        {
            RedondearPictures();
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

        private void BtClientes_Click(object sender, EventArgs e)
        {
            AbrirFormOscurecer(new FormularioClientes());
        }

        private void BtUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormOscurecer(new FormularioUsuarios());
        }

        private void BtJuegos_Click(object sender, EventArgs e)
        {
            AbrirFormOscurecer(new FormularioJuegos());
        }

        private void BtCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormOscurecer(new FormularioCategorias());
        }

        private void BtPlataformas_Click(object sender, EventArgs e)
        {
            AbrirFormOscurecer(new FormularioPlataformas());
        }

        private void BtTiposDocumento_Click(object sender, EventArgs e)
        {
            AbrirFormOscurecer(new FormularioTiposDocumento());
        }

        private void BtMediosPago_Click(object sender, EventArgs e)
        {
            AbrirFormOscurecer(new FormularioMediosPago());
        }
    }
}