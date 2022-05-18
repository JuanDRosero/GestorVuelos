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
    public partial class Vista_Admin : Form
    {
        private Form padre;
        private Escritura escritor;
        public Vista_Admin(Form padre)
        {
            this.padre = padre;
            escritor = new Escritura();
            InitializeComponent();
            actualizarForm();
        }

        private void btnAerolineasAgregar_Click(object sender, EventArgs e)
        {
            Form hijo = new AgregarElemento(this,escritor,'A');
            hijo.Show();
            this.Hide();
        }

        private void btnAerolineasEditar_Click(object sender, EventArgs e)
        { 
            Form hijo = new EditarElementro(this,escritor,'A');
            hijo.Show();
            this.Hide();
        }

        private void btnCiudadesAgregar_Click(object sender, EventArgs e)
        {
            Form hijo = new AgregarElemento(this, escritor, 'C');
            hijo.Show();
            this.Hide();
        }

        private void btnCiudadesEditar_Click(object sender, EventArgs e)
        {
            Form hijo = new EditarElementro(this, escritor, 'C');
            hijo.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form hijo = new AgregarVuelo(this, escritor);
            hijo.Show();
            this.Hide();
            actualizarForm();
        }

        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            if (escritor.GetVuelos().Count != 0)
            {
                Form hijo = new EditarVuelo(this, escritor);
                hijo.Show();
                this.Hide();
                actualizarForm();
            }
            else
            {
                MessageBox.Show("No hay Vuelos que editar","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void Vista_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.Show();
        }
        public void actualizarForm()
        {
            var elm= escritor.GetVuelos().Select(x => new { x.ID, x.Fecha, Salida = x.HSalida, Llegada = x.HLlegada, Origen = x.Origen.Nombre, Destino = x.Destino.Nombre, Aerolinea = x.Aerolinea.Nombre, x.Estado });
            dataGridView1.DataSource = elm.ToList();
        }

    }
}
