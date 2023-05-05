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
    }
}
