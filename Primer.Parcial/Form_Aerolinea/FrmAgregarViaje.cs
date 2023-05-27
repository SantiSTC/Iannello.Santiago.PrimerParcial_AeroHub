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
                Aeronave avion = (Aeronave)this.cmbAvion.SelectedItem;

                Viaje.AgregarViaje(Listas.viajes, this.cmbPartida.SelectedItem.ToString(), this.cmbDestino.SelectedItem.ToString(), this.mthFecha.SelectionStart, avion, avion.Pasajeros);

                foreach (Aeronave item in Listas.aviones)
                {
                    if (item == avion)
                    {
                        item.Ocupado = true;
                        break;
                    }
                }

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

        private void CargarComboBoxes()
        { 
            foreach(Aeronave avion in Listas.aviones) 
            {
                if (!avion.Ocupado) 
                {
                    this.cmbAvion.Items.Add(avion);
                }
            }


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
    }
}
