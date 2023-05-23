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
    public partial class FrmVenderViaje : Form
    {
        private bool flag;
        public FrmVenderViaje()
        {
            InitializeComponent();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (Validar.EsDni(this.txtDni.Text))
            {
                this.txtEdad.Enabled = true;
                this.txtNombre.Enabled = true;
                this.txtApellido.Enabled = true;
                this.chkComida.Enabled = true;
                this.chkInternet.Enabled = true;
                this.chkPremium.Enabled = true;
                this.cmbDestino.Enabled = true;
                this.cmbPartida.Enabled = true;
                this.mthFecha.Enabled = true;
                this.chkBodega.Enabled = true;
                this.chkDeMano.Enabled = true;

                if (!this.flag)
                {
                    foreach (Pasajero item in Listas.pasajeros)
                    {
                        if (item.Dni.ToString() == this.txtDni.Text)
                        {
                            txtApellido.Text = item.Apellido.ToString();
                            txtNombre.Text = item.Nombre.ToString();
                            txtEdad.Text = item.Edad.ToString();

                        }
                    }
                }
            }
            else 
            {
                MessageBox.Show("DNI Invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FrmVenderViaje_Load(object sender, EventArgs e)
        {
            this.txtEdad.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.chkComida.Enabled = false;
            this.chkInternet.Enabled = false;
            this.chkPremium.Enabled = false;
            this.cmbDestino.Enabled = false;
            this.cmbPartida.Enabled = false;
            this.mthFecha.Enabled = false;
            this.chkBodega.Enabled = false;
            this.chkDeMano.Enabled = false;
            this.flag = false;
        }

        private void CargarComboBoxes()
        {
            foreach (EDestinoNacional destino in Enum.GetValues(typeof(EDestinoNacional)))
            {
                this.cmbPartida.Items.Add(destino.ToString().Replace("_", " "));
            }

            this.cmbPartida.SelectedItem = EDestinoNacional.Buenos_Aires.ToString().Replace("_", " ");

            foreach (EDestinoNacional destino in Enum.GetValues(typeof(EDestinoNacional)))
            {
                if (destino.ToString().Replace("_", " ") != this.cmbPartida.SelectedItem.ToString().Replace("_", " "))
                {
                    this.cmbDestino.Items.Add(destino.ToString().Replace("_", " "));
                }
            }

            this.cmbDestino.SelectedIndex = 0;
            this.flag = true;
        }
    }
}
