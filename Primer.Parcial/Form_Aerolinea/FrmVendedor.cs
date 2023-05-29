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
    public partial class FrmVendedor : FrmMenu
    {
        public FrmVendedor(string nombre, string apellido, EPerfil perfil) : base(nombre, apellido, perfil)
        {
            InitializeComponent();
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void lblPasajeros_Click(object sender, EventArgs e)
        {
            FrmCRUD fm = new FrmCRUD(3);
            fm.FormClosed += FrmVendedor_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void lblViaje_Click(object sender, EventArgs e)
        {
            FrmListar fm = new FrmListar(Listas.viajes);
            fm.FormClosed += FrmVendedor_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void lblVenta_Click(object sender, EventArgs e)
        {
            FrmVenderViaje fm = new FrmVenderViaje();
            fm.FormClosed += FrmVendedor_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void lblEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas fm = new FrmEstadisticas();
            fm.FormClosed += FrmVendedor_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lblfondoPasajero.BackColor = SystemColors.HotTrack;
            lblDescPasajero.BackColor = SystemColors.HotTrack;
            lblPasajeros.BackColor = SystemColors.HotTrack;
            iconoPasajero.BackColor = SystemColors.HotTrack;
            lblPasajeros.ForeColor = SystemColors.Window;
            lblDescPasajero.ForeColor = SystemColors.Window;

        }

        private void lblfondoPasajero_MouseLeave(object sender, EventArgs e)
        {
            lblfondoPasajero.BackColor = SystemColors.Window;
            lblDescPasajero.BackColor = SystemColors.Window;
            lblPasajeros.BackColor = SystemColors.Window;
            iconoPasajero.BackColor = SystemColors.Window;
            lblPasajeros.ForeColor = SystemColors.ControlText;
            lblDescPasajero.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lblFondoViaje_MouseEnter(object sender, EventArgs e)
        {
            lblFondoViaje.BackColor = SystemColors.HotTrack;
            lblDescViaje.BackColor = SystemColors.HotTrack;
            lblViaje.BackColor = SystemColors.HotTrack;
            iconoViaje.BackColor = SystemColors.HotTrack;
            lblViaje.ForeColor = SystemColors.Window;
            lblDescViaje.ForeColor = SystemColors.Window;
        }

        private void lblFondoViaje_MouseLeave(object sender, EventArgs e)
        {
            lblFondoViaje.BackColor = SystemColors.Window;
            lblDescViaje.BackColor = SystemColors.Window;
            lblViaje.BackColor = SystemColors.Window;
            iconoViaje.BackColor = SystemColors.Window;
            lblViaje.ForeColor = SystemColors.ControlText;
            lblDescViaje.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lblFondoVenta_MouseEnter(object sender, EventArgs e)
        {
            lblFondoVenta.BackColor = SystemColors.HotTrack;
            lblDescVenta.BackColor = SystemColors.HotTrack;
            lblVenta.BackColor = SystemColors.HotTrack;
            iconoVenta.BackColor = SystemColors.HotTrack;
            lblVenta.ForeColor = SystemColors.Window;
            lblDescVenta.ForeColor = SystemColors.Window;
        }

        private void lblFondoVenta_MouseLeave(object sender, EventArgs e)
        {
            lblFondoVenta.BackColor = SystemColors.Window;
            lblDescVenta.BackColor = SystemColors.Window;
            lblVenta.BackColor = SystemColors.Window;
            iconoVenta.BackColor = SystemColors.Window;
            lblVenta.ForeColor = SystemColors.ControlText;
            lblDescVenta.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lblEstadistica_MouseEnter(object sender, EventArgs e)
        {
            lblFondoEstadistica.BackColor = SystemColors.HotTrack;
            lblDescEstadisticas.BackColor = SystemColors.HotTrack;
            lblEstadisticas.BackColor = SystemColors.HotTrack;
            iconoEstadisticas.BackColor = SystemColors.HotTrack;
            lblEstadisticas.ForeColor = SystemColors.Window;
            lblDescEstadisticas.ForeColor = SystemColors.Window;
        }

        private void lblEstadistica_MouseLeave(object sender, EventArgs e)
        {
            lblFondoEstadistica.BackColor = SystemColors.Window;
            lblDescEstadisticas.BackColor = SystemColors.Window;
            lblEstadisticas.BackColor = SystemColors.Window;
            iconoEstadisticas.BackColor = SystemColors.Window;
            lblEstadisticas.ForeColor = SystemColors.ControlText;
            lblDescEstadisticas.ForeColor = SystemColors.ControlDarkDark;
        }

        private void FrmVendedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
