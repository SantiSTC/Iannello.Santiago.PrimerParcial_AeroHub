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
                if (Validar.esNombreOApellido(this.txtNombre.Text) && Validar.esNombreOApellido(this.txtApellido.Text))
                {
                    int dni;
                    if (!int.TryParse(this.txtDni.Text, out dni) && !Validar.EsDni(this.txtDni.Text))
                    {
                        MessageBox.Show("El campo DNI debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int edad;
                    if (!int.TryParse(this.txtEdad.Text, out edad) && !Validar.esEdad(this.txtEdad.Text))
                    {
                        MessageBox.Show("El campo Edad debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Listas.pasajeros.Add(new Pasajero(this.txtNombre.Text, this.txtApellido.Text, dni, edad, ETipoEquipaje.Ninguno, 0));
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("El nombre o el apellido son invalidos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
