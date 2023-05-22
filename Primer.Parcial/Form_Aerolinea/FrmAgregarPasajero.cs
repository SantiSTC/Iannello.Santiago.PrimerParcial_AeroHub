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
            if (!string.IsNullOrWhiteSpace(this.txtNombre.Text) && !string.IsNullOrWhiteSpace(this.txtApellido.Text) && !string.IsNullOrWhiteSpace(this.txtDni.Text) && !string.IsNullOrWhiteSpace(this.txtEdad.Text) && !string.IsNullOrWhiteSpace(this.txtPeso.Text))
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

                int dni;
                if (!int.TryParse(this.txtDni.Text, out dni))
                {
                    MessageBox.Show("El campo DNI debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int edad;
                if (!int.TryParse(this.txtEdad.Text, out edad))
                {
                    MessageBox.Show("El campo Edad debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float peso;
                if (!float.TryParse(this.txtPeso.Text, out peso))
                {
                    MessageBox.Show("El campo Peso debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Listas.pasajeros.Add(new Pasajero(this.txtNombre.Text, this.txtApellido.Text, dni, edad, aux, peso));
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
