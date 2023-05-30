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
            List<Usuario> usuarios = Serializacion<Usuario>.Deserializar(Application.StartupPath + @"\Usuarios_Serializados\MOCK_DATA.json");

            foreach (Usuario usuario in usuarios)
            {
                if (!(txtUsuario.Text == usuario.Correo && txtContrasenia.Text == usuario.Clave))
                {
                    usuario.Perfil = EPerfil.Administrador;//
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
                MessageBox.Show("El usuario o la contraseña son incorrectos...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Deserializar JSON
            Listas.aviones = Serializacion<Aeronave>.Deserializar(Application.StartupPath + @"\Listas_Serializadas\aviones.json");
            Listas.viajes = Serializacion<Viaje>.Deserializar(Application.StartupPath + @"\Listas_Serializadas\viajes.json");
            Listas.pasajeros = Serializacion<Pasajero>.Deserializar(Application.StartupPath + @"\Listas_Serializadas\pasajeros.json");

            //Deserializar XML
            //Listas.aviones = Serializacion<Aeronave>.DeserializarXML(Application.StartupPath + @"\Listas_Serializadas\aviones.xml");
            //Listas.viajes = Serializacion<Viaje>.DeserializarXML(Application.StartupPath + @"\Listas_Serializadas\viajes.xml");
            //Listas.pasajeros = Serializacion<Pasajero>.DeserializarXML(Application.StartupPath + @"\Listas_Serializadas\pasajeros.xml");
        }
    }
}