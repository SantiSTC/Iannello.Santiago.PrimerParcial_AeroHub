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
    public partial class FrmModificarPasajero : FrmAgregarPasajero
    {
        private int dni;
        public FrmModificarPasajero(int dni)
        {
            InitializeComponent();
            this.dni = dni;
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Pasajero item in Listas.pasajeros) 
            {
                if (item.Dni == dni) 
                {
                    item.TipoEquipaje = ETipoEquipaje.Ninguno;
                    item.Dni = int.Parse(this.txtDni.Text);
                    item.Nombre = this.txtNombre.Text;
                    item.Apellido = this.txtApellido.Text;
                    item.Edad = int.Parse(this.txtEdad.Text);
                }
            }

            DialogResult = DialogResult.OK;
        }

        private void FrmModificarPasajero_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = "Modificar Pasajero";
            this.btnAgregar.Text = "Modificar";

            foreach (Pasajero item in Listas.pasajeros)
            {
                if (item.Dni == dni)
                {
                    this.txtDni.Text = item.Dni.ToString();
                    this.txtNombre.Text = item.Nombre.ToString();
                    this.txtApellido.Text = item.Apellido.ToString();
                    this.txtEdad.Text = item.Edad.ToString();
                    break;
                }
            }

            this.txtDni.Enabled = false;
        }
    }
}
