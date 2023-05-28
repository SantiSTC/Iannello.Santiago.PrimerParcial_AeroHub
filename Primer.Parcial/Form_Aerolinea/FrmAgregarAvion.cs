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
    public partial class FrmAgregarAvion : FrmAgregar
    {
        public FrmAgregarAvion()
        {
            InitializeComponent();
        }

        private void FrmAgregarAvion_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Agregar Aeronave";
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtMatricula.Text is not null || this.txtAsientos.Text is not null || this.txtBanios.Text is not null || this.txtCapacidad.Text is not null)
            {
                Aeronave.AgregarAeronave(Listas.aviones, this.txtMatricula.Text, int.Parse(this.txtAsientos.Text), int.Parse(this.txtBanios.Text), this.checkInternet.Checked, this.checkComida.Checked, float.Parse(this.txtCapacidad.Text));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Asegurese de no dejar ningun campo vacio...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
