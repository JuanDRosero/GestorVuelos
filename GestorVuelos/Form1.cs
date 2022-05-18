using Negocio;

namespace GestorVuelos
{
    public partial class LogIn : Form
    {
        private Lectura leer;
        public LogIn()
        {
            leer = new Lectura();
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Form hijo = new VistaUsuario(this);
            hijo.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                int cedula=int.Parse(textBoxDoc.Text);
                string pass=textBoxPass.Text ;
                if (leer.Ingresar(cedula,pass))
                {
                    Form hijo = new Vista_Admin(this);
                    hijo.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Datos Incorrectos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }catch (Exception ex)
            {
                MessageBox.Show("Datos Invalidos","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            
        }
    }
}