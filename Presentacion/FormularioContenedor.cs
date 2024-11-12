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
    public partial class FormularioContenedor : Form
    {
        ServiciosUsuarios serviciosUsuarios;
        Usuario usuarioLogueado;
        public FormularioContenedor(Usuario usuario)
        {
            InitializeComponent();
            labelTitulo.Text = "Bienvenido, " + usuario.PrimerNombre + " " + usuario.PrimerApellido;
            labelDocumento.Text = usuario.NumeroIdentificacion;
            labelRol.Text = usuario.Rol.Descripcion;
            serviciosUsuarios = new ServiciosUsuarios();
            usuarioLogueado = usuario;
        }

        Form formActivo = null;
        private void AbrirFormHijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }


        private void Salir()
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Maximizar()
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void BtMaximizar_Click(object sender, EventArgs e)
        {
            Maximizar();
        }

        private void BtMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtConfiguracion_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "Panel de Configuraciones";
            AbrirFormHijo(new FormularioConfiguraciones());
        }

        private void BtInventario_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "Panel de Inventario";
            AbrirFormHijo(new FormularioJuegos());
        }

        private void BtVender_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "Área de ventas | Videojuegos";
            AbrirFormHijo(new FormularioCarrito(usuarioLogueado));
        }

        private void FormularioContenedor_Load(object sender, EventArgs e)
        {
            labelTitulo.Text = "Bienvenido, " + usuarioLogueado.PrimerNombre + " " + usuarioLogueado.PrimerApellido;
            AbrirFormHijo(new FormularioTableroEstadisticas());
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "Bienvenido, " + usuarioLogueado.PrimerNombre + " " + usuarioLogueado.PrimerApellido;
            AbrirFormHijo(new FormularioTableroEstadisticas());
        }

        private void BtReportes_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "Panel de Reportes";
            AbrirFormHijo(new FormularioReportes());
        }
    }
}
