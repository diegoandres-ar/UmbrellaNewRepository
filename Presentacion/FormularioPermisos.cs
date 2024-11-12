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
    public partial class FormularioPermisos : Form
    {
        public FormularioPermisos()
        {
            InitializeComponent();
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvMediosPago.Rows.Add("Juan Pérez", "DNI", "12345678");
            dgvMediosPago.Rows.Add("María López", "Pasaporte", "A12345678");
            dgvMediosPago.Rows.Add("Carlos Gómez", "RUC", "20456789");
            dgvMediosPago.Rows.Add("Laura Martínez", "DNI", "87654321");
            dgvMediosPago.Rows.Add("Pedro Fernández", "Carnet de extranjería", "C87654321");
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
    }
}
