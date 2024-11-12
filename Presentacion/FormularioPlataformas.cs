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
    public partial class FormularioPlataformas : Form
    {
        ServiciosPlataformas serviciosPlataformas;
        public FormularioPlataformas()
        {
            InitializeComponent();
            serviciosPlataformas = new ServiciosPlataformas();
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
            List<Plataforma> plataformas = serviciosPlataformas.ObtenerTodo();
            dgvPlataformas.Rows.Clear();
            foreach (Plataforma plataforma in plataformas)
            {
                dgvPlataformas.Rows.Add(plataforma.Id, plataforma.Descripcion);
            }
            dgvPlataformas.CurrentCell = null;
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

        private void LimpiarControles()
        {
            txtID.Text = serviciosPlataformas.GenerarId();
            txtDescripcion.Text = "";
            BtGuardar.Text = "Guardar";
        }

        private void InsertarDatos()
        {
            string id = dgvPlataformas.CurrentRow.Cells[0].Value.ToString();
            Plataforma plataforma = serviciosPlataformas.BuscarPorId(id);
            txtID.Text = plataforma.Id;
            txtDescripcion.Text = plataforma.Descripcion;
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
            Plataforma plataforma = new Plataforma(id, descripcion);
            var mensaje = serviciosPlataformas.Guardar(plataforma);
            MessageBox.Show(mensaje);
        }

        private void Actualizar()
        {
            string id = txtID.Text;
            string descripcion = txtDescripcion.Text.Trim().ToUpper();
            Plataforma plataforma = new Plataforma(id, descripcion);
            var mensaje = serviciosPlataformas.Modificar(plataforma);
            MessageBox.Show(mensaje);
        }

        private void Eliminar()
        {
            string id = dgvPlataformas.CurrentRow.Cells[0].Value.ToString();
            var respuesta = MessageBox.Show("¿Está seguro de eliminar el registro?", 
                "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                var mensaje = serviciosPlataformas.Eliminar(id);
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
            LimpiarControles();
            DesactivarControles();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            DesactivarControles();
        }
    }
}
