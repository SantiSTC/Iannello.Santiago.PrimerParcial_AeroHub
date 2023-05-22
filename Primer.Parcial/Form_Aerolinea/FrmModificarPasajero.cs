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
                    item.PesoEquipaje = float.Parse(this.txtPeso.Text);

                    if (this.chkBodega.Checked && this.chkDeMano.Checked)
                    {
                        item.TipoEquipaje = ETipoEquipaje.Ambos;
                    }
                    else 
                    {
                        if (this.chkBodega.Checked)
                        {
                            item.TipoEquipaje = ETipoEquipaje.DeBodega;
                        }
                        else 
                        {
                            if (this.chkDeMano.Checked) 
                            {
                                item.TipoEquipaje = ETipoEquipaje.DeMano;
                            }
                        }
                    }
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
                    this.txtPeso.Text = item.PesoEquipaje.ToString();

                    if (item.TipoEquipaje == ETipoEquipaje.Ambos)
                    {
                        this.chkDeMano.Checked = true;
                        this.chkBodega.Checked = true;
                    }
                    else
                    {
                        if (item.TipoEquipaje == ETipoEquipaje.DeMano)
                        {
                            this.chkDeMano.Checked = true;
                        }
                        else
                        {
                            if (item.TipoEquipaje == ETipoEquipaje.DeBodega)
                            {
                                this.chkBodega.Checked = true;
                            }
                        }
                    }
                    break;
                }
            }

            this.txtDni.Enabled = false;
        }
    }
}
