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
    public partial class FrmAgregarViaje : FrmAgregar
    {
        private bool flag;
        List<Viaje> aux = Listas.viajes.OrderBy(v => v.Fecha).ToList();

        public FrmAgregarViaje()
        {
            InitializeComponent();
        }

        private void FrmAgregarViaje_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Agregar Viaje";
            this.Text = "Agregar Viaje";

            CargarComboBoxes();
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.cmbAvion.SelectedIndex == -1 || this.cmbDestino.SelectedIndex == -1 || this.cmbPartida.SelectedIndex == -1 || this.mthFecha.SelectionStart >= DateTime.Today)
            {
                if (!this.mthFecha.BoldedDates.Contains(this.mthFecha.SelectionStart))
                {
                    Aeronave avion = (Aeronave)this.cmbAvion.SelectedItem;

                    Viaje.AgregarViaje(Listas.viajes, this.cmbPartida.SelectedItem.ToString(), this.cmbDestino.SelectedItem.ToString(), this.mthFecha.SelectionStart, avion, avion.Pasajeros);

                    foreach (Viaje item in aux)
                    {
                        if (item.Avion == avion)
                        {
                            item.Avion.Ocupado = true;
                            break;
                        }
                    }

                    foreach (Viaje item in Listas.viajes)
                    {
                        foreach (Viaje viaje in aux)
                        {
                            if (item == viaje)
                            {
                                item.Avion.Ocupado = viaje.Avion.Ocupado;
                            }
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Esta fecha esta ocupada, intente con otra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void CargarComboBoxes()
        {

            this.cmbAvion.DataSource = Listas.aviones;

            foreach (EDestinoNacional destino in Enum.GetValues(typeof(EDestinoNacional)))
            {
                this.cmbPartida.Items.Add(destino.ToString().Replace("_", " "));
            }

            this.cmbPartida.SelectedItem = EDestinoNacional.Buenos_Aires.ToString().Replace("_", " ");

            foreach (EDestinoNacional destino in Enum.GetValues(typeof(EDestinoNacional)))
            {
                if (destino.ToString().Replace("_", " ") != cmbPartida.SelectedItem.ToString().Replace("_", " "))
                {
                    this.cmbDestino.Items.Add(destino.ToString().Replace("_", " "));
                }
            }

            this.cmbDestino.SelectedIndex = 0;
            this.flag = true;
        }

        private void cmbPartida_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cmbPartida.Items.Clear();
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

        private void cmbAvion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mthFecha.RemoveAllBoldedDates();

            Aeronave? avion = cmbAvion.SelectedItem as Aeronave;

            foreach (Viaje viaje in Listas.viajes)
            {
                if (viaje.Avion == avion)
                {
                    this.mthFecha.AddBoldedDate(viaje.Fecha);
                }
            }

            this.mthFecha.UpdateBoldedDates();
        }
    }
}
