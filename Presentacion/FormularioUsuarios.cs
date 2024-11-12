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
    public partial class FormularioUsuarios : Form
    {
        public FormularioUsuarios()
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
            dgvUsuarios.Rows.Add(null, null, "Juan Pérez", "DNI", "12345678", "987654321", "juan.perez@example.com");
            dgvUsuarios.Rows.Add(null, null, "María López", "Pasaporte", "A12345678", "912345678", "maria.lopez@example.com");
            dgvUsuarios.Rows.Add(null, null, "Carlos Gómez", "RUC", "20456789", "923456789", "carlos.gomez@example.com");
            dgvUsuarios.Rows.Add(null, null, "Laura Martínez", "DNI", "87654321", "934567890", "laura.martinez@example.com");
            dgvUsuarios.Rows.Add(null, null, "Pedro Fernández", "Carnet de extranjería", "C87654321", "945678901", "pedro.fernandez@example.com");
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

        private void BtNuevoCliente_Click(object sender, EventArgs e)
        {
            AbrirFormOscurecer(new FormularioNuevoUsuario());
        }
    }
}
