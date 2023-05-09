using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Aerolinea
{
    public partial class FrmModificarViaje : FrmAgregarViaje
    {
        private Viaje viaje;

        public FrmModificarViaje(Viaje v)
        {
            InitializeComponent();

            this.viaje = v;
        }

        private void FrmModificarViaje_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Modificar Viaje";
            this.btnAgregar.Text = "Modificar";

            foreach (Viaje viaje in Listas.viajes)
            {
                if (viaje == this.viaje)
                {
                    this.cmbPartida.SelectedItem = viaje.CiudadDePartida;
                    this.cmbDestino.SelectedItem = viaje.CiudadDeDestino;
                    this.cmbAvion.SelectedItem = viaje.Avion;
                    this.mthFecha.SelectionStart = viaje.Fecha;
                    break;
                }
            }

            this.cmbPartida.Enabled = false;
            this.cmbDestino.Enabled = false;
            this.cmbAvion.Enabled = false;
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Viaje viaje in Listas.viajes) 
            {
                if(viaje == this.viaje) 
                {
                    viaje.Fecha = this.mthFecha.SelectionStart;
                    break;
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
