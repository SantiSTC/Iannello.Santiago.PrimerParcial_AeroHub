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
    public partial class FrmAgregarPasajero : FrmAgregar
    {
        public FrmAgregarPasajero()
        {
            InitializeComponent();
        }

        private void FrmAgregarPasajero_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Agregar Pasajero";
            this.txtPeso.Enabled = false;
            this.txtPeso.Text = "0";
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre is not null && this.txtApellido is not null && this.txtDni is not null && this.txtEdad is not null && this.txtPeso is not null)
            {
                ETipoEquipaje aux = ETipoEquipaje.Ninguno;
                if (this.chkBodega.Checked && this.chkDeMano.Checked)
                {
                    aux = ETipoEquipaje.Ambos;
                }
                else
                {
                    if (this.chkDeMano.Checked)
                    {
                        aux = ETipoEquipaje.DeMano;
                    }
                    else
                    {
                        if (this.chkBodega.Checked)
                        {
                            aux = ETipoEquipaje.DeBodega;
                        }
                    }
                }

                Listas.pasajeros.Add(new Pasajero(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text), int.Parse(this.txtEdad.Text), aux, float.Parse(this.txtPeso.Text)));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Asegurese de no dejar ningun campo vacio...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkBodega_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkBodega.Checked || this.chkDeMano.Checked)
            {
                this.txtPeso.Enabled = true;
            }
            else
            {
                this.txtPeso.Enabled = false;
                this.txtPeso.Text = "0";
            }
        }

        private void chkDeMano_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkBodega.Checked || this.chkDeMano.Checked)
            {
                this.txtPeso.Enabled = true;
            }
            else
            {
                this.txtPeso.Enabled = false;
                this.txtPeso.Text = "0";
            }
        }
    }
}
