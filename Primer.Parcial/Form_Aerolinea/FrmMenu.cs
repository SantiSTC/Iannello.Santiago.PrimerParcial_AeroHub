using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Aerolinea
{
    public partial class FrmMenu : Form
    {
        public FrmMenu() { }
        public FrmMenu(string nombre, string apellido, EPerfil perfil)
        {
            InitializeComponent();

            lblUsuarioMenu.Text = nombre;
            lblUsuarioMenu.Text += " " + apellido;
            lblPerfilMenu.Text = perfil.ToString();
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                //Serializacion JSON
                Serializacion<Aeronave>.Serializar(Listas.aviones, Application.StartupPath + @"\Listas_Serializadas\aviones.json");
                Serializacion<Viaje>.Serializar(Listas.viajes, Application.StartupPath + @"\Listas_Serializadas\viajes.json");
                Serializacion<Pasajero>.Serializar(Listas.pasajeros, Application.StartupPath + @"\Listas_Serializadas\pasajeros.json");

                //Serializacion XML
                Serializacion<Aeronave>.SerializarXML(Listas.aviones, Application.StartupPath + @"\Listas_Serializadas\aviones.xml");
                Serializacion<Viaje>.SerializarXML(Listas.viajes, Application.StartupPath + @"\Listas_Serializadas\viajes.xml");
                Serializacion<Pasajero>.SerializarXML(Listas.pasajeros, Application.StartupPath + @"\Listas_Serializadas\pasajeros.xml");
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuarioMenu_Click(object sender, EventArgs e)
        {
        }

        private void lblPerfilMenu_Click(object sender, EventArgs e)
        {
        }
    }
}
