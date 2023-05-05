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
    public partial class FrmModificarAvion : FrmAgregarAvion
    {
        private string matricula;
        public FrmModificarAvion(string matriculaParam)
        {
            InitializeComponent();
            this.matricula = matriculaParam;
        }

        private void FrmModificarAvion_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Modificar Aeronave";
            this.btnAgregar.Text = "Modificar";

            foreach (Aeronave avion in Listas.aviones)
            {
                if (avion.Matricula == this.matricula)
                {
                    this.txtMatricula.Text = avion.Matricula;
                    this.txtAsientos.Text = avion.CantidadAsientos.ToString();
                    this.txtBanios.Text = avion.CantidadBanios.ToString();
                    this.txtCapacidad.Text = avion.CapacidadBodega.ToString();
                    this.checkInternet.Checked = avion.Internet;
                    this.checkComida.Checked = avion.Comida;
                    break;
                }
            }
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Aeronave avion in Listas.aviones)
            {
                if (avion.Matricula == this.matricula)
                {
                    avion.CantidadAsientos = int.Parse(this.txtAsientos.Text);
                    avion.CantidadBanios = int.Parse(this.txtBanios.Text);
                    avion.CapacidadBodega = float.Parse(this.txtCapacidad.Text);
                    avion.Internet = this.checkInternet.Checked;
                    avion.Comida = this.checkComida.Checked;
                    break;
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
