using Entidades;

namespace Form_Aerolinea
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int validar = 0;
            List<Usuario> usuarios = Serializacion<Usuario>.Deserializar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MOCK_DATA.json");

            foreach (Usuario usuario in usuarios)
            {
                if (txtUsuario.Text == usuario.Correo && txtContrasenia.Text == usuario.Clave)
                {
                    validar = 1;
                    FrmMenu fm = new FrmMenu();

                    switch (usuario.Perfil)
                    {
                        case EPerfil.Administrador:
                            fm = new FrmAdmin(usuario.Nombre, usuario.Apellido, usuario.Perfil);
                            break;
                        case EPerfil.Supervisor:
                            fm = new FrmSupervisor(usuario.Nombre, usuario.Apellido, usuario.Perfil);
                            break;
                        case EPerfil.Vendedor:
                            fm = new FrmVendedor(usuario.Nombre, usuario.Apellido, usuario.Perfil);
                            break;
                    }

                    this.Hide();

                    if (fm.ShowDialog() is DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
            }
            if (validar == 0)
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }


    }
}