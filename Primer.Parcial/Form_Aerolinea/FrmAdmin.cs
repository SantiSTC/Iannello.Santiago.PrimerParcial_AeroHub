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

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCRUD fm = new FrmCRUD(2);
            fm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmCRUD fm = new FrmCRUD(1);
            fm.ShowDialog();
        }
    }
}
