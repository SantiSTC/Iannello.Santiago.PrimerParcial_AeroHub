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
        private Object? obj;

        public FrmCRUD()
        {
            InitializeComponent();
        }

        public FrmCRUD(int option) : this()
        {
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
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            switch (this.obj.GetType().Name)
            {
                case "Aeronave":
                    FrmAgregarAvion fm = new FrmAgregarAvion();
                    fm.ShowDialog();
                    break;
                case "Viaje":
                    foreach (Aeronave avion in Listas.aviones) 
                    {
                        if (!avion.Ocupado) 
                        {
                            contador++;
                        }
                    }

                    if (contador > 0)
                    {
                        FrmAgregarViaje fm2 = new FrmAgregarViaje();
                        fm2.ShowDialog();
                    }
                    else 
                    {
                        MessageBox.Show("No hay aviones disponibles para un nuevo viaje.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    break;
                case "Pasajero":
                    FrmAgregarPasajero fm3 = new FrmAgregarPasajero();
                    fm3.ShowDialog();
                    break;
            }
            ActualizarGrid();
        }

        private void CrearGrid()
        {
            dgvLista.Rows.Clear();

            for (int i = 0; i < this.obj.GetType().GetProperties().Length; i++)
            {
                string columna = this.obj.GetType().GetProperties()[i].Name;
                dgvLista.Columns.Add(columna, columna);
            }

            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            dgvLista.Rows.Clear();

            switch (this.obj.GetType().Name)
            {
                case "Aeronave":
                    foreach (Aeronave item in Listas.aviones)
                    {
                        string[] fila = new string[dgvLista.Columns.Count];

                        for (int i = 0; i < dgvLista.Columns.Count; i++)
                        {
                            if (dgvLista.Columns[i].Name is not "Pasajeros")
                            {
                                fila[i] = (item.GetType().GetProperty(dgvLista.Columns[i].Name).GetValue(item)).ToString();
                            }
                            else
                            {
                                dgvLista.Columns.RemoveAt(i);
                            }
                        }

                        dgvLista.Rows.Add(fila);
                    }
                    break;
                case "Viaje":
                    foreach (Viaje item in Listas.viajes)
                    {
                        string[] fila = new string[dgvLista.Columns.Count];

                        for (int i = 0; i < dgvLista.Columns.Count; i++)
                        {
                            if (dgvLista.Columns[i].Name is "Fecha")
                            {
                                fila[i] = $"{((DateTime)item.GetType().GetProperty(dgvLista.Columns[i].Name).GetValue(item)).Day}/{((DateTime)item.GetType().GetProperty(dgvLista.Columns[i].Name).GetValue(item)).Month}/{((DateTime)item.GetType().GetProperty(dgvLista.Columns[i].Name).GetValue(item)).Year}";
                            }
                            else
                            {
                                fila[i] = (item.GetType().GetProperty(dgvLista.Columns[i].Name).GetValue(item)).ToString();
                            }
                        }

                        dgvLista.Rows.Add(fila);
                    }
                    break;
                case "Pasajero":
                    foreach (Pasajero item in Listas.pasajeros)
                    {
                        string[] fila = new string[dgvLista.Columns.Count];

                        for (int i = 0; i < dgvLista.Columns.Count; i++)
                        {
                            fila[i] = (item.GetType().GetProperty(dgvLista.Columns[i].Name).GetValue(item)).ToString();
                        }

                        dgvLista.Rows.Add(fila);
                    }
                    break;
            }

            if (this.dgvLista.Rows.Count <= 1)
            {
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }
            else
            {
                this.btnEliminar.Enabled = true;
                this.btnModificar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (this.obj.GetType().Name)
            {
                case "Aeronave":
                    if (dgvLista.SelectedRows.Count > 0)
                    {
                        DataGridViewRow fila = dgvLista.SelectedRows[0];
                        string? matricula = fila.Cells["Matricula"].Value.ToString();

                        foreach (Aeronave avion in Listas.aviones)
                        {
                            if (avion.Matricula == matricula)
                            {
                                Listas.aviones.Remove(avion);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se debera elegir una fila a eliminar...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Viaje":
                    if (dgvLista.SelectedRows.Count > 0)
                    {
                        DataGridViewRow fila = dgvLista.SelectedRows[0];
                        Aeronave avion = new Aeronave();
                        foreach (Aeronave item in Listas.aviones)
                        {
                            if (item.Matricula == fila.Cells["Avion"].Value.ToString())
                            {
                                avion = item;
                                break;
                            }
                        }
                        string[] fecha = fila.Cells["Fecha"].Value.ToString().Split('/');

                        Viaje viaje = new Viaje(fila.Cells["CiudadDePartida"].Value.ToString(), fila.Cells["CiudadDeDestino"].Value.ToString(), new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0])), avion, avion.CantidadAsientos, avion.Pasajeros);

                        foreach (Viaje item in Listas.viajes)
                        {
                            if (item == viaje)
                            {
                                Listas.viajes.Remove(viaje);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se debera elegir una fila a eliminar...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Pasajero":
                    if (dgvLista.SelectedRows.Count > 0)
                    {
                        DataGridViewRow fila = dgvLista.SelectedRows[0];

                        foreach (Pasajero item in Listas.pasajeros)
                        {
                            if (item.Dni.ToString() == fila.Cells["Dni"].Value.ToString())
                            {
                                Listas.pasajeros.Remove(item);
                                break;
                            }
                        }

                        foreach (Aeronave avion in Listas.aviones) 
                        {
                            foreach (Pasajero pasajero in avion.Pasajeros) 
                            {
                                if (pasajero.Dni.ToString() == fila.Cells["Dni"].Value.ToString()) 
                                {
                                    avion.Pasajeros.Remove(pasajero);
                                    break;
                                }
                            }
                        }

                        foreach (Viaje viaje in Listas.viajes) 
                        {
                            foreach (Pasajero pasajero in viaje.Avion.Pasajeros)
                            {
                                if (pasajero.Dni.ToString() == fila.Cells["Dni"].Value.ToString())
                                {
                                    viaje.Avion.Pasajeros.Remove(pasajero);
                                    break;
                                }
                            }
                        }  

                    }
                    else
                    {
                        MessageBox.Show("Se debera elegir una fila a eliminar...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    break;
            }

            ActualizarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            switch (this.obj.GetType().Name)
            {
                case "Aeronave":
                    if (dgvLista.SelectedRows.Count > 0)
                    {
                        DataGridViewRow fila = dgvLista.SelectedRows[0];
                        string matricula = fila.Cells["Matricula"].Value.ToString();

                        FrmModificarAvion fm = new FrmModificarAvion(matricula);
                        fm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Se debera elegir una fila a modificar...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Viaje":
                    if (dgvLista.SelectedRows.Count > 0)
                    {
                        DataGridViewRow fila = dgvLista.SelectedRows[0];
                        Aeronave avion = new Aeronave();
                        foreach (Aeronave item in Listas.aviones)
                        {
                            if (item.Matricula == fila.Cells["Avion"].Value.ToString())
                            {
                                avion = item;
                            }
                        }
                        string[] fecha = fila.Cells["Fecha"].Value.ToString().Split('/');

                        Viaje viaje = new Viaje(fila.Cells["CiudadDePartida"].Value.ToString(), fila.Cells["CiudadDeDestino"].Value.ToString(), new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0])), avion, avion.CantidadAsientos, avion.Pasajeros);

                        FrmModificarViaje fm = new FrmModificarViaje(viaje);
                        fm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Se debera elegir una fila a modificar...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "Pasajero":
                    if (dgvLista.SelectedRows.Count > 0)
                    {
                        DataGridViewRow fila = dgvLista.SelectedRows[0];
                        int dni = int.Parse(fila.Cells["Dni"].Value.ToString());

                        FrmModificarPasajero fm = new FrmModificarPasajero(dni);
                        fm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Se debera elegir una fila a modificar...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }

            ActualizarGrid();
        }
    }
}
