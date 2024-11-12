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
    public partial class FormularioTiposDocumento : Form
    {
        ServiciosTiposDocumentos serviciosTiposDocumentos;
        public FormularioTiposDocumento()
        {
            InitializeComponent();
            serviciosTiposDocumentos = new ServiciosTiposDocumentos();
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
            List<TipoDocumento> tiposDocumentos = serviciosTiposDocumentos.ObtenerTodo();
            dgvTiposDocumentos.Rows.Clear();
            foreach (TipoDocumento tipoDocumento in tiposDocumentos)
            {
                dgvTiposDocumentos.Rows.Add(tipoDocumento.Id, tipoDocumento.Descripcion);
            }
            dgvTiposDocumentos.CurrentCell = null;
        }

        private void LimpiarControles()
        {
            txtID.Text = serviciosTiposDocumentos.GenerarId();
            txtDescripcion.Text = "";
            BtGuardar.Text = "Guardar";
        }

        private void DesactivarControles()
        {
            txtID.Enabled = false;
            txtDescripcion.Enabled = false;
            BtGuardar.Enabled = false;
        }

        private void ActivarControles()
        {
            txtDescripcion.Enabled = true;
            BtGuardar.Enabled = true;
        }

        private void Guardar()
        {
            string id = txtID.Text;
            string descripcion = txtDescripcion.Text.Trim().ToUpper();
            TipoDocumento tipoDocumento = new TipoDocumento(id, descripcion);
            var mensaje = serviciosTiposDocumentos.Guardar(tipoDocumento);
            MessageBox.Show(mensaje);
        }

        private void Actualizar()
        {
            string id = txtID.Text;
            string descripcion = txtDescripcion.Text.Trim().ToUpper();
            TipoDocumento tipoDocumento = new TipoDocumento(id, descripcion);
            var mensaje = serviciosTiposDocumentos.Modificar(tipoDocumento);
            MessageBox.Show(mensaje);
        }

        private void Eliminar()
        {
            string id = dgvTiposDocumentos.CurrentRow.Cells[0].Value.ToString();
            var respuesta = MessageBox.Show("¿Está seguro de eliminar el registro?", 
                "Eliminar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                var mensaje = serviciosTiposDocumentos.Eliminar(id);
                MessageBox.Show(mensaje);
            }
        }

        private void Funcion()
        {
            if (BtGuardar.Text == "Guardar")
            {
                Guardar();
            }
            else
            {
                Actualizar();
            }
        }

        private void InsertarDatos()
        {
            string id = dgvTiposDocumentos.CurrentRow.Cells[0].Value.ToString();
            TipoDocumento tipoDocumento = serviciosTiposDocumentos.BuscarPorId(id);
            txtID.Text = tipoDocumento.Id;
            txtDescripcion.Text = tipoDocumento.Descripcion;
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            ActivarControles();
            LimpiarControles();
            txtDescripcion.Focus();
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            Funcion();
            LimpiarControles();
            DesactivarControles();
            CargarDatos();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            BtGuardar.Text = "Actualizar";
            InsertarDatos();
            ActivarControles();
            txtDescripcion.Focus();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            DesactivarControles();
        }
    }
}
