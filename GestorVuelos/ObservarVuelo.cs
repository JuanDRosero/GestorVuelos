using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorVuelos
{
    public partial class ObservarVuelo : Form
    {
        private Form padre;
        private Vuelo vuelo;
        public ObservarVuelo(Form padre,Vuelo vuelo)
        {
            this.padre = padre;
            this.vuelo = vuelo;
            InitializeComponent();
            textBoxNo.Text = vuelo.ID.ToString();
            textBoxOrigen.Text = vuelo.Origen.Nombre;
            textBoxDestino.Text = vuelo.Destino.Nombre;
            textBoxFecha.Text=vuelo.Fecha.ToString();
            textBoxHSalida.Text=vuelo.HSalida.ToString();
            textBoxHLlegada.Text=vuelo.HLlegada.ToString();
            textBoxAerolinea.Text = vuelo.Aerolinea.ToString();
            textBoxEstado.Text = vuelo.Estado ? "En vuelo" : "Terminado";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObservarVuelo_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.Show();
        }
    }
}
