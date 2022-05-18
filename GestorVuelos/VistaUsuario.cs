using Modelo;
using Negocio;
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
    public partial class VistaUsuario : Form
    {
        private Form padre;
        private Lectura lectura;
        public VistaUsuario(Form padre)
        {
            this.padre = padre;
            lectura = new Lectura();
            InitializeComponent();
            dataGridView1.DataSource = lectura.GetVuelos();
            var elm = lectura.GetVuelos().Select(x => new { x.ID, x.Fecha, Salida = x.HSalida, Llegada = x.HLlegada, Origen = x.Origen.Nombre, Destino = x.Destino.Nombre, Aerolinea = x.Aerolinea.Nombre, x.Estado });
            dataGridView1.DataSource = elm.ToList();
            cbVuelos.DataSource=lectura.GetVuelos().Select(x=>x.ID).ToList();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbVuelos.Items.Count!=0)
            {
                Vuelo v = lectura.GetVuelo(Int32.Parse(cbVuelos.SelectedItem.ToString()));
                if (v != null)
                {
                    Form hijo = new ObservarVuelo(this, v);
                    hijo.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se encuentra el Vuelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay vuelos que Revisar","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
                
        }
    }
}
