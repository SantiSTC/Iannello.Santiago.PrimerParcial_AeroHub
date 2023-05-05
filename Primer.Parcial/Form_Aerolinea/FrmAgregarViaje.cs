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
        public FrmAgregarViaje()
        {
            InitializeComponent();
        }

        private void FrmAgregarViaje_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Agregar Viaje";

            CargarComboBoxes();
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.cmbAvion.SelectedIndex == -1 || this.cmbDestino.SelectedIndex == -1 || this.cmbPartida.SelectedIndex == -1 || this.txtCantidad is not null || this.mthFecha.SelectionStart >= DateTime.Today)
            {
                Viaje.AgregarViaje(Listas.viajes, this.cmbPartida.SelectedItem.ToString(), this.cmbDestino.SelectedItem.ToString(), this.mthFecha.SelectionStart, (Aeronave)this.cmbAvion.SelectedItem, int.Parse(this.txtCantidad.Text), Listas.pasajeros);
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
            foreach (Aeronave avion in Listas.aviones)
            {
                this.cmbAvion.Items.Add(avion);
            }

            this.cmbPartida.DataSource = (Enum.GetValues(typeof(EDestinoNacional)));

            if (this.cmbPartida.SelectedItem is EDestinoNacional.BuenosAires)
            {
                Array nacionales = Enum.GetValues(typeof(EDestinoNacional));
                Array internacionales = Enum.GetValues(typeof(EDestinoInternacional));

                List<Object> destinos = new List<Object>((IEnumerable<object>)nacionales);
                destinos.AddRange((IEnumerable<object>)internacionales);

                this.cmbDestino.DataSource = destinos;
            }

            this.cmbAvion.SelectionStart = 0;

        }
    }
}
