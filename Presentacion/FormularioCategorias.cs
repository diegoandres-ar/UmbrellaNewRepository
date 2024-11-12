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
    public partial class FormularioCategorias : Form
    {
        ServiciosCategorias serviciosCategorias;
        public FormularioCategorias()
        {
            InitializeComponent();
            serviciosCategorias = new ServiciosCategorias();
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
            DesactivarControles();
            LimpiarControles();
        }

        private void CargarDatos()
        {
            List<Categoria> categorias = serviciosCategorias.ObtenerTodo();
            if (categorias == null) return;
            dgvCategorias.Rows.Clear();
            foreach (Categoria categoria in categorias)
            {
                dgvCategorias.Rows.Add(categoria.Id, categoria.Descripcion);
            }
            dgvCategorias.CurrentCell = null;
        }

        private void DesactivarControles()
        {
            txtID.Enabled = false;
            txtDescripcion.Enabled = false;
            BtGuardar.Enabled = false;
            BtCancelar.Enabled = false;
        }

        private void ActivarControles()
        {
            txtDescripcion.Enabled = true;
            BtGuardar.Enabled = true;
            BtCancelar.Enabled = true;
        }

        private void LimpiarControles()
        {
            txtID.Text = serviciosCategorias.GenerarId();
            txtDescripcion.Text = "";
            BtGuardar.Text = "Guardar";
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            ActivarControles();
            LimpiarControles();
            txtDescripcion.Focus();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            BtGuardar.Text = "Actualizar";
            InsertarDatos();
            ActivarControles();
            txtDescripcion.Focus();
        }

        private void Guardar()
        {
            string id = txtID.Text;
            string descripcion = txtDescripcion.Text.Trim().ToUpper();
            Categoria categoria = new Categoria(id, descripcion);
            var mensaje = serviciosCategorias.Guardar(categoria);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Actualizar()
        {
            string id = txtID.Text;
            string descripcion = txtDescripcion.Text.Trim().ToUpper();
            Categoria categoria = new Categoria(id, descripcion);
            var mensaje = serviciosCategorias.Modificar(categoria);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InsertarDatos()
        {
            string id = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            Categoria categoria = serviciosCategorias.BuscarPorId(id);
            txtID.Text = categoria.Id;
            txtDescripcion.Text = categoria.Descripcion;
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

        private void Eliminar()
        {
            string id = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            var respuesta = MessageBox.Show("¿Está seguro de eliminar el registro?", 
                "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                var mensaje = serviciosCategorias.Eliminar(id);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            Funcion();
            CargarDatos();
            LimpiarControles();
            DesactivarControles();
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            CargarDatos();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            DesactivarControles();
        }
    }
}
