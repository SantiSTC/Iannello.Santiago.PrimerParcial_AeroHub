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
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtNombre.Text) && !string.IsNullOrWhiteSpace(this.txtApellido.Text) && !string.IsNullOrWhiteSpace(this.txtDni.Text) && !string.IsNullOrWhiteSpace(this.txtEdad.Text))
            {
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

                Listas.pasajeros.Add(new Pasajero(this.txtNombre.Text, this.txtApellido.Text, dni, edad, ETipoEquipaje.Ninguno, 0));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Asegurese de no dejar ningun campo vacio...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
