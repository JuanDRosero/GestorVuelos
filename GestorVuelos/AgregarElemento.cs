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
    public partial class AgregarElemento : Form
    {
        private Form principal;
        private Aerolinea aerolinea;
        private Ciudad ciudad;
        private char tipo;
        private Escritura escritor;
        public AgregarElemento(Form padre, Escritura escritor, char tipo, Aerolinea aerolinea = null, Ciudad ciudad = null)
        {
            this.principal = padre;
            this.escritor = escritor;
            this.tipo = tipo;
            this.ciudad = ciudad;
            this.aerolinea = aerolinea;
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 'A':
                    aerolinea = new Aerolinea() { Nombre = textBox1.Text };
                    if (escritor.AddAerolinea(aerolinea))
                    {
                        MessageBox.Show("La aerolinea se agregó correctamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Agregar la aeroliea","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    break;
                case 'C':
                    ciudad= new Ciudad() { Nombre = textBox1.Text };
                    if(escritor.AddCiudad(ciudad))
                    {
                        MessageBox.Show("La ciudad se agregó correctamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("No se pudo Agregar la ciudad", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarElemento_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }
    }
}
