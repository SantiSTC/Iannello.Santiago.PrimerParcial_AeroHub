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
    public partial class FrmResultadosEstadistica : Form
    {
        private string cadenaAMostrar;

        public FrmResultadosEstadistica(string cadena)
        {
            InitializeComponent();
            this.cadenaAMostrar = cadena;
        }

        private void FrmResultadosEstadistica_Load(object sender, EventArgs e)
        {
            this.rchEstadistica.Text = cadenaAMostrar;
        }
    }
}
