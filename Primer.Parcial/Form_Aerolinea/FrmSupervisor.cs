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
    public partial class FrmSupervisor : FrmMenu
    {
        public FrmSupervisor(string nombre, string apellido, EPerfil perfil) : base(nombre, apellido, perfil)
        {
            InitializeComponent();
        }

        private void lblfondoPasajero_Click(object sender, EventArgs e)
        {

        }

        private void lblFondoEstadistica_Click(object sender, EventArgs e)
        {

        }

        private void lblfondoPasajero_MouseEnter(object sender, EventArgs e)
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


    }
}
