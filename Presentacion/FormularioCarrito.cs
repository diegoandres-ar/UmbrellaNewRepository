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
    public partial class FormularioCarrito : Form
    {
        ServiciosItemsFactura serviciosItemsFactura;
        ServiciosJuegos serviciosJuegos;
        ServiciosFacturas serviciosFacturas;
        Usuario usuarioLogueado;
        public FormularioCarrito(Usuario usuarioLogueado)
        {
            InitializeComponent();
            serviciosItemsFactura = new ServiciosItemsFactura();
            serviciosJuegos = new ServiciosJuegos();
            serviciosFacturas = new ServiciosFacturas();
            this.usuarioLogueado = usuarioLogueado;
        }

        private void EliminarFila()
        {
            dgvCarrito.Rows.RemoveAt(dgvCarrito.CurrentRow.Index);
        }

        private void DisminuirCantidad()
        {
            int cantidad = Convert.ToInt32(dgvCarrito.CurrentRow.Cells[6].Value);
            if (cantidad > 1)
            {
                dgvCarrito.CurrentRow.Cells[6].Value = cantidad - 1;
            }
        }

        private void AumentarCantidad()
        {
            int cantidad = Convert.ToInt32(dgvCarrito.CurrentRow.Cells[6].Value);
            int stock = Convert.ToInt32(dgvCarrito.CurrentRow.Cells[4].Value);
            if (cantidad < stock)
            {
                dgvCarrito.CurrentRow.Cells[6].Value = cantidad + 1;
            }
        }

        public void CalcularTotalItem()
        {
            if (dgvCarrito.Rows.Count == 0) return;
            double precio = Convert.ToDouble(dgvCarrito.CurrentRow.Cells[3].Value);
            int cantidad = Convert.ToInt32(dgvCarrito.CurrentRow.Cells[6].Value);
            Juego juego = serviciosJuegos.BuscarPorId(dgvCarrito.CurrentRow.Cells[1].Value.ToString());
            double subtotal = serviciosItemsFactura.CalcularSubTotal(juego, cantidad);
            dgvCarrito.CurrentRow.Cells[8].Value = subtotal;
        }

        public void CalcularSubTotalCarrito()
        {
            if (dgvCarrito.Rows.Count == 0)
            {
                labelSubtotal.Text = "0 $";
                return;
            }
            List<Item> items = new List<Item>();
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                Juego juego = serviciosJuegos.BuscarPorId(row.Cells[1].Value.ToString());
                string id = serviciosItemsFactura.GenerarId();
                int cantidad = Convert.ToInt32(row.Cells[6].Value);
                Item item = new Item(id, juego, cantidad);
                items.Add(item);
            }
            double total = serviciosFacturas.CalcularTotalFactura(items);
            labelSubtotal.Text = total.ToString() + " $";
        }

        private void AplicarIVA()
        {
            double subTotalFactura = Convert.ToDouble(labelSubtotal.Text.Replace(" $", ""));
            double IVA = txtIVA.Text == "" ? 0 : Convert.ToDouble(txtIVA.Text);
            double totalFactura = serviciosFacturas.AplicarIVA(subTotalFactura, IVA);
            labelTotal.Text = totalFactura.ToString() + " $";
        }

        private void MostrarIVA()
        {
            double subTotalFactura = Convert.ToDouble(labelSubtotal.Text.Replace(" $", ""));
            double IVA = txtIVA.Text == "" ? 0 : Convert.ToDouble(txtIVA.Text);
            double totalIVA = serviciosFacturas.TotalIVA(subTotalFactura, IVA);
            labelIVA.Text = "+ " + totalIVA.ToString() + " $";
        }

        private List<Item> CrearListaItems()
        {
            List<Item> items = new List<Item>();
            foreach(DataGridViewRow row in dgvCarrito.Rows)
            {
                Juego juego = serviciosJuegos.BuscarPorId(row.Cells[1].Value.ToString());
                int cantidad = Convert.ToInt32(row.Cells[6].Value);
                Item item = new Item(juego, cantidad);
                items.Add(item);
            }
            return items;
        }

        private void ClicDataGridView(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            switch (e.ColumnIndex)
            {
                case 0:
                    EliminarFila();
                    CalcularTotalItem();
                    CalcularSubTotalCarrito();
                    break;
                case 5:
                    DisminuirCantidad();
                    break;
                case 7:
                    AumentarCantidad();
                    break;
            }
        }

        private void CargarCarrito(List<Juego> juegos)
        {
            if (juegos == null) return;
            dgvCarrito.Rows.Clear();
            foreach (Juego juego in juegos)
            {
                dgvCarrito.Rows.Add(null, juego.Id, juego.Titulo, juego.Precio, juego.Stock, null, 1, null, juego.Precio);
            }
        }

        public void LimpiarTodo()
        {
            dgvCarrito.Rows.Clear();
            labelSubtotal.Text = "0 $";
            labelIVA.Text = "+ 0 $";
            labelTotal.Text = "0 $";
            txtIVA.Text = "";
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClicDataGridView(e);
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

        private void dgvCarrito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotalItem();
            CalcularSubTotalCarrito();
        }

        private void BtBuscarJuegos_Click(object sender, EventArgs e)
        {
            FormularioSeleccionJuegos formularioSeleccionJuegos = new FormularioSeleccionJuegos(null, this);
            formularioSeleccionJuegos.DatosActualizados += (juegosSeleccionados) =>
            {
                CargarCarrito(juegosSeleccionados);
            };
            AbrirFormOscurecer(formularioSeleccionJuegos);
        }

        private void BtCobrar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("No hay juegos en el carrito");
                return;
            }
            List<Item> items = CrearListaItems();
            double totalFactura = Convert.ToDouble(labelTotal.Text.Replace(" $", ""));
            double iva = txtIVA.Text == "" ? 0 : Convert.ToDouble(txtIVA.Text);
            CalcularTotalItem();
            CalcularSubTotalCarrito();
            MostrarIVA();
            AplicarIVA();
            AbrirFormOscurecer(new FormularioFinalizarCompra(items, totalFactura, iva, usuarioLogueado, this));
        }

        private void BtAplicarIVA_Click(object sender, EventArgs e)
        {
            MostrarIVA();
            AplicarIVA();
        }
    }
}
