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
    public partial class EditarElementro : Form
    {
        private Vista_Admin principal;
        private List<Aerolinea> aerolinea;
        private List<Ciudad> ciudad;
        private char tipo;
        private Escritura escritor;

        
        public EditarElementro(Vista_Admin padre,Escritura escritor, char tipo)
        {
            this.principal = padre;
            this.escritor= escritor;
            this.tipo = tipo;
            this.ciudad = escritor.GetCiudades();
            this.aerolinea = escritor.GetAerolineas();
            InitializeComponent();
            limpiarComboBox();

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 'A':
                    var a = aerolinea.ElementAt(comboBox1.SelectedIndex);
                    a.Nombre = textBox1.Text;
                    if (escritor.EditAerolinea(a))
                        MessageBox.Show("Se editó correctamente","Actualización",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo actualizar", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 'C':
                    var c = ciudad.ElementAt(comboBox1.SelectedIndex);
                    c.Nombre = textBox1.Text;
                    if (escritor.EditCiudad(c))
                        MessageBox.Show("Se editó correctamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo actualizar", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarElementro_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.actualizarForm();
            principal.Show();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 'A':
                    var a = aerolinea.ElementAt(comboBox1.SelectedIndex);
                    if (escritor.DeleteAerolinea(a))
                    {
                        aerolinea.Remove(a);
                        MessageBox.Show("Se eliminó correctamente", "Elimincación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                        MessageBox.Show("No se pudo eliminar", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                case 'C':
                    var c = ciudad.ElementAt(comboBox1.SelectedIndex);
                    if (escritor.DeleteCiudad(c))
                    {
                        ciudad.Remove(c);
                        MessageBox.Show("Se eliminó correctamente", "Elimincación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("No se pudo eliminar", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            limpiarComboBox();
        }

        private void limpiarComboBox()
        {
            switch(tipo)
            {
                case 'A':
                    comboBox1.DataSource = aerolinea.Select(x => x.Nombre).ToList();
                break;
                case 'C':
                    comboBox1.DataSource = ciudad.Select(x => x.Nombre).ToList();
                break;
            }
            if (comboBox1.Items.Count == 0)
            {
                buttonAgregar.Enabled = false;
                buttonEliminar.Enabled = false;
            }
        }
    }
}
