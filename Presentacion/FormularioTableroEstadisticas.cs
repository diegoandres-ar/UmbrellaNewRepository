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
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class FormularioTableroEstadisticas : Form
    {
        ServiciosUsuarios serviciosUsuarios;
        ServiciosJuegos serviciosJuegos;
        ServiciosClientes serviciosClientes;
        ServiciosFacturas serviciosFacturas;
        public FormularioTableroEstadisticas()
        {
            InitializeComponent();
            serviciosUsuarios = new ServiciosUsuarios();
            serviciosJuegos = new ServiciosJuegos();
            serviciosClientes = new ServiciosClientes();
            serviciosFacturas = new ServiciosFacturas();
        }

        private void InsertarNumeroUsuarios()
        {
            List<Usuario> usuarios = serviciosUsuarios.ObtenerTodo();
            int cantidadUsuarios = usuarios.Count;
            labelUsuarios.Text = cantidadUsuarios.ToString();
        }

        private void InsertarNumeroJuegos()
        {
            List<Juego> juegos = serviciosJuegos.ObtenerTodo();
            int cantidadJuegos = juegos.Count;
            labelJuegos.Text = cantidadJuegos.ToString();
        }

        private void InsertarNumeroClientes()
        {
            List<Cliente> clientes = serviciosClientes.ObtenerTodo();
            int cantidadClientes = clientes.Count;
            labelClientes.Text = cantidadClientes.ToString();
        }

        private void InsertarNumeroFacturas()
        {
            List<Factura> facturas = serviciosFacturas.ObtenerTodo();
            int cantidadFacturas = facturas.Count;
            labelVentas.Text = cantidadFacturas.ToString();
        }

        private void FormularioTableroEstadisticas_Load(object sender, EventArgs e)
        {
            InsertarNumeroUsuarios();
            InsertarNumeroJuegos();
            InsertarNumeroClientes();
            InsertarNumeroFacturas();
            DateTime fechaInicio = dateTimeFechaInicio.MinDate;
            DateTime fechaFin = dateTimeFechaFin.MaxDate;
            GraficarVentasPorDia(fechaInicio, fechaFin);
        }

        private void GraficarVentasPorDia(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio == null || fechaFin == null)
            {
                return;
            }

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<DateTime, int> facturasPorDia = serviciosFacturas.ObtenerFacturasPorDia(fechaInicio, fechaFin);

            panelGrafica.Controls.Clear();

            if (facturasPorDia.Count == 0)
            {
                return;
            }

            Chart chartFacturas = new Chart
            {
                Dock = DockStyle.Fill,
            };

            ChartArea chartArea = new ChartArea
            {
                AxisX = { Title = "Día" },
                AxisY = { Title = "Cantidad de Facturas" },
            };
            chartFacturas.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Facturas",
                ChartType = SeriesChartType.Column,
                Color = Color.SteelBlue
            };

            foreach (var entry in facturasPorDia)
            {
                series.Points.AddXY(entry.Key.ToString("dd/MM/yyyy"), entry.Value);
            }

            chartFacturas.Series.Add(series);

            panelGrafica.Controls.Add(chartFacturas);
            panelGrafica.Refresh();
        }

        private void BtFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimeFechaInicio.Value;
            DateTime fechaFin = dateTimeFechaFin.Value;
            GraficarVentasPorDia(fechaInicio, fechaFin);
        }
    }
}
