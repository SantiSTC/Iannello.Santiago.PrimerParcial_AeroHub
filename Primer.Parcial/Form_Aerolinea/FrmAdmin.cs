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
    public partial class FrmAdmin : FrmMenu
    {
        public FrmAdmin(string nombre, string apellido, EPerfil perfil) : base(nombre, apellido, perfil)
        {
            InitializeComponent();
        }

        private void lblfondoAeronave_Click(object sender, EventArgs e)
        {
            FrmCRUD fm = new FrmCRUD(1);

            fm.FormClosed += FrmAdmin_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void lblFondoViaje_Click(object sender, EventArgs e)
        {
            FrmCRUD fm = new FrmCRUD(2);

            fm.FormClosed += FrmAdmin_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
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

        private void lblfondoAeronave_MouseEnter(object sender, EventArgs e)
        {
            lblfondoAeronave.BackColor = SystemColors.HotTrack;
            lblAeronave.BackColor = SystemColors.HotTrack;
            lblDescAeronave.BackColor = SystemColors.HotTrack;
            iconoAeronave.BackColor = SystemColors.HotTrack;
            lblAeronave.ForeColor = SystemColors.Window;
            lblDescAeronave.ForeColor = SystemColors.Window;
        }

        private void lblfondoAeronave_MouseLeave(object sender, EventArgs e)
        {
            lblfondoAeronave.BackColor = SystemColors.Window;
            lblAeronave.BackColor = SystemColors.Window;
            lblDescAeronave.BackColor = SystemColors.Window;
            iconoAeronave.BackColor = SystemColors.Window;
            lblAeronave.ForeColor = SystemColors.ControlText;
            lblDescAeronave.ForeColor = SystemColors.ControlDarkDark;
        }
    }
}
