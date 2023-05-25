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
            bool validar = false;
            List<Usuario> usuarios = Serializacion<Usuario>.Deserializar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MOCK_DATA.json");

            foreach (Usuario usuario in usuarios)
            {
                if (!(txtUsuario.Text == usuario.Correo && txtContrasenia.Text == usuario.Clave))
                {
                    usuario.Perfil = EPerfil.Vendedor;//
                    validar = true;
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
            if (!validar)
            {
                MessageBox.Show("El usuario o la contraseņa son incorrectos...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Listas.aviones = Serializacion<Aeronave>.Deserializar(Application.StartupPath + @"\Listas_Serializadas\aviones.json");
            Listas.viajes = Serializacion<Viaje>.Deserializar(Application.StartupPath + @"\Listas_Serializadas\viajes.json");
            Listas.pasajeros = Serializacion<Pasajero>.Deserializar(Application.StartupPath + @"\Listas_Serializadas\pasajeros.json");
        }


    }
}