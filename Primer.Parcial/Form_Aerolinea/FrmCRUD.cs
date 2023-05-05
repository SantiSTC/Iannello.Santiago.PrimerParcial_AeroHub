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
    public partial class FrmCRUD : Form
    {
        private Object obj;

        public FrmCRUD(int option)
        {
            InitializeComponent();

            switch (option) 
            {
                case 1:
                    this.obj = new Aeronave();
                break;
                case 2:
                    this.obj = new Viaje();
                break;
                case 3:
                    this.obj = new Pasajero();
                break;
            }
        }

        private void FrmCRUD_Load(object sender, EventArgs e)
        {
            CrearGrid();
            dvgLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            switch (this.obj.GetType().Name)
            {
                case "Aeronave":
                    FrmAgregarAvion fm = new FrmAgregarAvion();
                    fm.ShowDialog();
                    break;
                case "Viaje":
                    FrmAgregarViaje fm2 = new FrmAgregarViaje();
                    fm2.ShowDialog();
                    break;
                case "Pasajero":

                    break;
            }
            ActualizarGrid();
        }

        private void CrearGrid()
        {
            dvgLista.Rows.Clear();

            for (int i = 0; i < this.obj.GetType().GetProperties().Length; i++)
            {
                string columna = this.obj.GetType().GetProperties()[i].Name;
                dvgLista.Columns.Add(columna, columna);
            }

            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            dvgLista.Rows.Clear();

            switch (this.obj.GetType().Name) 
            {
                case "Aeronave":
                    foreach (Aeronave item in Listas.aviones)
                    {
                        string[] fila = new string[dvgLista.Columns.Count];

                        for (int i = 0; i < dvgLista.Columns.Count; i++)
                        {
                            fila[i] = (item.GetType().GetProperty(dvgLista.Columns[i].Name).GetValue(item)).ToString();
                        }

                        dvgLista.Rows.Add(fila);
                    }
                break;
                case "Viaje":
                    foreach (Viaje item in Listas.viajes)
                    {
                        string[] fila = new string[dvgLista.Columns.Count];

                        for (int i = 0; i < dvgLista.Columns.Count; i++)
                        {
                            fila[i] = (item.GetType().GetProperty(dvgLista.Columns[i].Name).GetValue(item)).ToString();
                        }

                        dvgLista.Rows.Add(fila);
                    }
                break;
                case "Pasajero":
                    foreach (Pasajero item in Listas.pasajeros)
                    {
                        string[] fila = new string[dvgLista.Columns.Count];

                        for (int i = 0; i < dvgLista.Columns.Count; i++)
                        {
                            fila[i] = (item.GetType().GetProperty(dvgLista.Columns[i].Name).GetValue(item)).ToString();
                        }

                        dvgLista.Rows.Add(fila);
                    }
                break;
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgLista.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dvgLista.SelectedRows[0];
                string? matricula = fila.Cells["Matricula"].Value.ToString();

                foreach (Aeronave avion in Listas.aviones)
                {
                    if (avion.Matricula == matricula)
                    {
                        Listas.aviones.Remove(avion);
                        break;
                    }
                }

                ActualizarGrid();
            }
            else
            {
                MessageBox.Show("Se debera elegir una fila a eliminar...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dvgLista.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dvgLista.SelectedRows[0];
                string? matricula = fila.Cells["Matricula"].Value.ToString();

                FrmModificarAvion fm = new FrmModificarAvion(matricula);
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se debera elegir una fila a modificar...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            ActualizarGrid();
        }
    }
}
