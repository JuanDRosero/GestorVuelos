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
    public partial class EditarVuelo : Form
    {
        private Vista_Admin padre;
        private Escritura escritor;
        private AgregarVuelo Vuelo;
        private List<Vuelo> vuelos;
        
        public EditarVuelo(Vista_Admin padre,Escritura escritor)
        {
            this.padre = padre;
            this.escritor = escritor;
            vuelos = escritor.GetVuelos();
            InitializeComponent();
            comboBoxVuelo.DataSource=vuelos.Select(x=>x.ID).ToList();
            comboBoxVuelo.SelectedIndex = 0;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        var vuelo = vuelos.Where(x => x.ID == Int32.Parse(comboBoxVuelo.SelectedItem.ToString())).First();
        vuelo.Estado= comboBox1.SelectedIndex == 0 ? true : false;
            if (escritor.EditVuelo(vuelo))
            {
                MessageBox.Show("Se ha actualziado correctamente","Actualización",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }else
                MessageBox.Show("No se ha podido editar el vuelo","Actualización",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarVuelo_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.actualizarForm();
            padre.Show();
        }

        private void comboBoxVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVuelo.SelectedIndex!=-1)
            {
                Vuelo vuelo = escritor.GetVuelo(Int32.Parse(comboBoxVuelo.SelectedItem.ToString()));
                textBoxNo.Text = vuelo.ID.ToString();
                textBoxOrigen.Text = vuelo.Origen.Nombre;
                textBoxDestino.Text = vuelo.Destino.Nombre;
                textBoxHSalida.Text = vuelo.HSalida.ToString();
                textBoxHLlegada.Text = vuelo.HLlegada.ToString();
                textBoxAerolinea.Text = vuelo.Aerolinea.Nombre;
                vuelo.Estado = comboBox1.SelectedIndex == 0 ? true : false;
            }
        }
    }
}
