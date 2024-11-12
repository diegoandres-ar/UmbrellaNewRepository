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
    public partial class FormularioNuevoCliente : Form
    {
        private ServiciosClientes serviciosClientes;
        private ServiciosTiposDocumentos serviciosTiposDocumentos;
        public FormularioNuevoCliente()
        {
            InitializeComponent();
            serviciosClientes = new ServiciosClientes();
            serviciosTiposDocumentos = new ServiciosTiposDocumentos();
            CargarComboTiposDocumentos();
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarComboTiposDocumentos()
        {
            comboTipoDocumento.DataSource = serviciosTiposDocumentos.ObtenerTodo();
            comboTipoDocumento.DisplayMember = "Descripcion";
            comboTipoDocumento.ValueMember = "Id";
        }

        private void Guardar()
        {
            string primerNombre = txtPrimerNombre.Text.Trim().ToUpper();
            string segundoNombre = txtSegundoNombre.Text.Trim().ToUpper();
            string primerApellido = txtPrimerApellido.Text.Trim().ToUpper();
            string segundoApellido = txtSegundoApellido.Text.Trim().ToUpper();
            string numeroDocumento = txtNumeroDocumento.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correoElectronico = txtCorreo.Text.Trim();
            TipoDocumento tipoDocumento = serviciosTiposDocumentos.BuscarPorId(comboTipoDocumento.SelectedValue.ToString());
            string tipoPersona = comboTipoPersona.Text;

            Cliente cliente = new Cliente(numeroDocumento, tipoDocumento, primerNombre, segundoNombre,
                primerApellido, segundoApellido, correoElectronico, telefono, tipoPersona);

            var mensaje = serviciosClientes.Guardar(cliente);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Operacion()
        {
            if(BtNuevoCliente.Text == "Guardar")
            {
                Guardar();
            }
        }

        private void BtNuevoCliente_Click(object sender, EventArgs e)
        {
            Operacion();
        }
    }
}
