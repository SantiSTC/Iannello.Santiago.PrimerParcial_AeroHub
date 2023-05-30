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
        private bool flag2;
        public FrmVenderViaje()
        {
            InitializeComponent();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (this.txtDni.Text.Length == 8)
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
                    this.btnAceptar.Enabled = true;
                    this.flag2 = false;

                    foreach (Pasajero item in Listas.pasajeros)
                    {
                        if (item.Dni.ToString() == this.txtDni.Text)
                        {
                            txtApellido.Text = item.Apellido.ToString();
                            txtNombre.Text = item.Nombre.ToString();
                            txtEdad.Text = item.Edad.ToString();

                            this.txtEdad.Enabled = false;
                            this.txtNombre.Enabled = false;
                            this.txtApellido.Enabled = false;
                            this.flag2 = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("DNI Invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
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
                this.txtPeso.Enabled = false;
                this.btnAceptar.Enabled = false;

                this.txtEdad.Text = "";
                this.txtNombre.Text = "";
                this.txtApellido.Text = "";
                this.chkComida.Checked = false;
                this.chkInternet.Checked = false;
                this.chkPremium.Checked = false;
                this.mthFecha.SelectionStart = DateTime.Now;
                this.chkBodega.Checked = false;
                this.chkDeMano.Checked = false;
                this.txtPeso.Text = "0";
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
            this.txtPeso.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.flag2 = false;

            this.txtPeso.Text = "0";

            CargarComboBoxes();
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

            this.cmbPartida.SelectedIndex = 0;
            this.flag = true;
        }

        private void cmbPartida_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbDestino.Items.Clear();

            if (this.cmbPartida.SelectedItem.ToString() == EDestinoNacional.Buenos_Aires.ToString().Replace("_", " "))
            {
                if (this.flag)
                {
                    foreach (EDestinoNacional destino in Enum.GetValues(typeof(EDestinoNacional)))
                    {
                        if (destino.ToString().Replace("_", " ") != cmbPartida.SelectedItem.ToString())
                        {
                            this.cmbDestino.Items.Add(destino.ToString().Replace("_", " "));
                        }
                    }
                }

                foreach (EDestinoInternacional destino in Enum.GetValues(typeof(EDestinoInternacional)))
                {
                    this.cmbDestino.Items.Add(destino);
                }
            }
            else
            {
                foreach (EDestinoNacional destino in Enum.GetValues(typeof(EDestinoNacional)))
                {
                    if (destino.ToString().Replace("_", " ") != cmbPartida.SelectedItem.ToString())
                    {
                        this.cmbDestino.Items.Add(destino.ToString().Replace("_", " "));
                    }
                }
            }

            this.cmbDestino.Items.Remove(EDestinoNacional.Buenos_Aires.ToString().Replace("_", " "));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool flag3 = false;

            List<Viaje> aux = new List<Viaje>();

            foreach (Viaje item in Listas.viajes)
            {
                if (item.CiudadDePartida.ToString().Replace("_", " ") == cmbPartida.SelectedItem.ToString() && item.CiudadDeDestino.ToString().Replace("_", " ") == cmbDestino.SelectedItem.ToString() && item.Fecha.Date == mthFecha.SelectionStart.Date && item.Avion.Comida == chkComida.Checked && item.Avion.Internet == chkInternet.Checked)
                {
                    aux.Add(item);
                }
            }

            FrmListar fm = new FrmListar(aux);
            fm.btnAceptar.Visible = true;
            if (fm.ShowDialog() is DialogResult.OK)
            {
                Viaje viaje = fm.ViajeDelForm;
                ETipoEquipaje auxEquipaje = ETipoEquipaje.Ninguno;
                Pasajero pasajero = new Pasajero();

                if (this.chkBodega.Checked && this.chkDeMano.Checked)
                {
                    auxEquipaje = ETipoEquipaje.Ambos;
                }
                else
                {
                    if (this.chkBodega.Checked)
                    {
                        auxEquipaje = ETipoEquipaje.DeBodega;
                    }
                    else
                    {
                        if (this.chkDeMano.Checked)
                        {
                            auxEquipaje = ETipoEquipaje.DeMano;
                        }
                    }
                }

                foreach (Pasajero item in viaje.Avion.Pasajeros)
                {
                    if (item.Dni == int.Parse(txtDni.Text))
                    {
                        flag3 = true;
                    }
                }

                if (!flag3)
                {
                    pasajero = new Pasajero(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), int.Parse(txtEdad.Text), auxEquipaje, float.Parse(txtPeso.Text));
                    pasajero.EsPremium = chkPremium.Checked;

                    if (pasajero.EsPremium)
                    {
                        if (viaje.AsientosPremium > 0)
                        {
                            this.AgregarPasajeroAlViaje(viaje, pasajero, auxEquipaje);
                        }
                        else
                        {
                            MessageBox.Show($"No hay mas asientos PREMIUM disponibles para este viaje. Intente con clase TURISTA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (viaje.AsientosTurista > 0)
                        {
                            this.AgregarPasajeroAlViaje(viaje, pasajero, auxEquipaje);
                        }
                        else
                        {
                            MessageBox.Show($"No hay mas asientos TURISTA disponibles para este viaje. Intente con clase PREMIUM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"El pasajero/a {txtNombre.Text} {txtApellido.Text} ya se encuentra en el viaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!flag2)
                {
                    pasajero = new Pasajero(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), int.Parse(txtEdad.Text), auxEquipaje, float.Parse(txtPeso.Text));
                    pasajero.EsPremium = chkPremium.Checked;
                    Listas.pasajeros.Add(pasajero);
                }

                this.btnAceptar.Visible = false;
                this.Close();
            }
        }

        private void chkDeMano_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBodega.Checked || chkDeMano.Checked)
            {
                this.txtPeso.Enabled = true;
            }
            else
            {
                this.txtPeso.Enabled = false;
                this.txtPeso.Text = "0";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AgregarPasajeroAlViaje(Viaje viaje, Pasajero pasajero, ETipoEquipaje auxEquipaje)
        {
            foreach (Viaje item in Listas.viajes)
            {
                if (item.Avion == viaje.Avion)
                {
                    item.Avion += pasajero;

                    if (pasajero.EsPremium)
                    {
                        item.AsientosPremium = item.AsientosPremium - 1;
                    }
                    else
                    {
                        item.AsientosTurista = item.AsientosTurista - 1;
                    }

                    break;
                }
            }

            foreach (Aeronave avion in Listas.aviones)
            {
                if (avion == viaje.Avion)
                {
                    avion.Pasajeros.Add(pasajero);
                    break;
                }
            }

            foreach (Viaje item in Listas.viajes)
            {
                if (item == viaje)
                {
                    item.Pasajeros.Add(pasajero);
                }
            }


        }
    }
}
