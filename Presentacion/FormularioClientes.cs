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
    public partial class FormularioClientes : Form
    {
        private ServiciosClientes serviciosClientes;
        public FormularioClientes()
        {
            InitializeComponent();
            serviciosClientes = new ServiciosClientes();
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            CargarDatos(serviciosClientes.ObtenerTodo());
        }

        private void CargarDatos(List<Cliente> clientes)
        {
            dgvClientes.Rows.Clear();
            foreach (Cliente cliente in clientes)
            {
                dgvClientes.Rows.Add(null, null, cliente.PrimerNombre + " " + cliente.SegundoNombre + " " + cliente.PrimerApellido
                    + " " + cliente.SegundoApellido, cliente.TipoDocumento.Descripcion, cliente.NumeroIdentificacion, 
                    cliente.Telefono, cliente.CorreoElectronico,
                    cliente.TipoPersona);
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

        private void BtNuevoCliente_Click(object sender, EventArgs e)
        {
            AbrirFormOscurecer(new FormularioNuevoCliente());
        }
    }
}
