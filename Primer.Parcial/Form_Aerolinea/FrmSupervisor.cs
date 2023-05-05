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

        private void MenuSupervisor_Load(object sender, EventArgs e)
        {

        }
    }
}
