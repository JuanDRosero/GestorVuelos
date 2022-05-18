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
    public partial class AgregarVuelo : Form
    {
        private Vista_Admin padre;
        private Escritura escritor;
        private List<Ciudad> ciudades;
        private List<Aerolinea> aerolineas;
        public AgregarVuelo(Vista_Admin padre, Escritura escritor)
        {
            this.padre = padre;
            this.escritor = escritor;
            InitializeComponent();
            ciudades = escritor.GetCiudades();
            aerolineas=escritor.GetAerolineas();
            comboBoxOrigen.DataSource =  ciudades.Select(x => x.Nombre).ToList();
            comboBoxDestino.DataSource = ciudades.Select(x => x.Nombre).ToList();
            comboBoxAerolinea.DataSource=aerolineas.Select(x => x.Nombre).ToList();
            comboBoxestado.SelectedIndex = 0;
        }

        private void AgregarVuelo_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.actualizarForm();
            padre.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vuelo vuelo = new Vuelo();
            try
            {
                vuelo.ID = Int32.Parse(textBoxNo.Text);
                vuelo.Origen = ciudades.ElementAt(comboBoxOrigen.SelectedIndex);
                vuelo.Destino = ciudades.ElementAt(comboBoxDestino.SelectedIndex);
                vuelo.Fecha = dateTimePickerFecha.Value.Date;
                vuelo.HSalida = TimeSpan.Parse(dateTimePickerSalida.Value.ToString("HH:mm"));
                vuelo.HLlegada = TimeSpan.Parse(dateTimePickerLlegada.Value.ToString("HH:mm"));
                vuelo.Aerolinea = aerolineas.ElementAt(comboBoxAerolinea.SelectedIndex);
                vuelo.Estado = comboBoxestado.SelectedIndex == 0 ? true : false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido ingresar el vuelo", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (escritor.AddVuelo(vuelo))
            {
                MessageBox.Show("Se ha ingresado el vuelo correctamente","Actualización",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha podido ingresar el vuelo", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
