using Biblioteca.Modelos;
using Biblioteca.Interfaces;
using Biblioteca.Presentadores;
namespace Vista
{
    public partial class frm_Login : Form , ILogin
    {
        PresentadorLogin presentadorLogin;
        public string Nombre { get => txt_Usuario.Text; set => txt_Usuario.Text = value; }
        public string Password { get => txt_Contraseña.Text; set => txt_Contraseña.Text = value; }
        public string LabelError { get => lbl_Error.Text; set => lbl_Error.Text = value; }

        public frm_Login()
        {
            InitializeComponent();
            presentadorLogin = new PresentadorLogin(this);
        }


        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (presentadorLogin.Verificar())
                {
                    frm_MenuPrincipal formularioPrincipal = new frm_MenuPrincipal();
                    this.Hide();
                    formularioPrincipal.ShowDialog();
                    this.Show();
                }
                else
                {
                    presentadorLogin.MostrarError();
                }
            }
            catch
            {
                if(MessageBox.Show("Error en la conexión a la base de datos.", "ErrorDatos", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_AutoCompletar_Click(object sender, EventArgs e)
        {
            try
            {
                presentadorLogin.AutoCompletarDatos();

            }
            catch
            {
                if (MessageBox.Show("Error en la conexión a la base de datos.", "ErrorDatos", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}