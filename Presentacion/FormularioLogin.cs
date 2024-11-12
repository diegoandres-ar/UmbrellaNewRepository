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
    public partial class FormularioLogin : Form
    {
        ServiciosIniciarSesion serviciosIniciarSesion;
        public FormularioLogin()
        {
            InitializeComponent();
            serviciosIniciarSesion = new ServiciosIniciarSesion();
        }

        private Usuario ValidarCredenciales()
        {
            string nombreUsuario = txtNombreUsuario.Text.ToUpper();
            string contrasena = txtContrasenia.Text.ToUpper();
            Usuario usuario = serviciosIniciarSesion.IniciarSesion(nombreUsuario, contrasena);
            return usuario;
        }

        private void IniciarSesion(Usuario usuario)
        {
            if (usuario != null)
            {
                AbrirForm(new FormularioContenedor(usuario));
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void AbrirForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void BtIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = ValidarCredenciales();
            IniciarSesion(usuario);
        }
    }
}
