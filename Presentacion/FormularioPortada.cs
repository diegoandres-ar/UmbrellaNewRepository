using Entidades;
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
    public partial class FormularioPortada : Form
    {
        public FormularioPortada(string tituloJuego, Image portadaJuego)
        {
            InitializeComponent();
            InsertarDatos(tituloJuego, portadaJuego);
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertarDatos(string tituloJuego, Image portadaJuego)
        {
            labelNombreJuego.Text = tituloJuego;
            picturePortada.Image = portadaJuego;
        }
    }
}
