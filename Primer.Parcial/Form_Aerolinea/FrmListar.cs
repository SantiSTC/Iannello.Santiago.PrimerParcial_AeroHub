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
    public partial class FrmListar : Form
    {
        private int option;
        private List<Pasajero>? listaP;
        private List<Viaje>? listaV;

        public FrmListar()
        {
            InitializeComponent();
            this.btnAceptar.Visible = false;
        }

        public FrmListar(List<Viaje> lista) : this()
        {
            this.option = 0;
            this.listaV = lista;
        }

        public FrmListar(int option, List<Pasajero> lista) : this()
        {
            this.option = option;
            this.listaP = lista;
        }

        public Viaje ViajeDelForm
        {
            get
            {
                Viaje viaje = new Viaje();
                Viaje viajeAux = new Viaje();

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

                    viajeAux = new Viaje(fila.Cells["CiudadDePartida"].Value.ToString(), fila.Cells["CiudadDeDestino"].Value.ToString(), new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0])), avion, avion.CantidadAsientos, avion.Pasajeros);

                    foreach(Viaje item in Listas.viajes)
                    {
                        if(item == viajeAux)
                        {
                            viaje = item;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Se debera elegir una fila a eliminar...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return viaje;
            }
        }

        private void FrmListar_Load(object sender, EventArgs e)
        {
            if (this.option == 0)
            {
                CrearGrid(this.listaV);
            }
            else
            {
                CrearGrid(this.listaP);
            }
        }

        private void CrearGrid(List<Viaje> lista)
        {
            dgvLista.Rows.Clear();

            for (int i = 0; i < (new Viaje()).GetType().GetProperties().Length; i++)
            {
                string columna = (new Viaje()).GetType().GetProperties()[i].Name;
                dgvLista.Columns.Add(columna, columna);
            }

            ActualizarGrid(lista);
        }

        private void CrearGrid(List<Pasajero> lista)
        {
            dgvLista.Rows.Clear();
            dgvLista.DoubleClick -= dgvLista_DoubleClick;
            label2.Visible = false;

            for (int i = 0; i < (new Pasajero()).GetType().GetProperties().Length; i++)
            {
                string columna = (new Pasajero()).GetType().GetProperties()[i].Name;
                dgvLista.Columns.Add(columna, columna);
            }

            ActualizarGrid(lista);
        }

        private void ActualizarGrid(List<Viaje> lista)
        {
            dgvLista.Rows.Clear();

            foreach (Viaje item in lista)
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
        }

        private void ActualizarGrid(List<Pasajero> lista)
        {
            dgvLista.Rows.Clear();

            foreach (Pasajero item in lista)
            {
                string[] fila = new string[dgvLista.Columns.Count];

                for (int i = 0; i < dgvLista.Columns.Count; i++)
                {
                    fila[i] = (item.GetType().GetProperty(dgvLista.Columns[i].Name).GetValue(item)).ToString();
                }

                dgvLista.Rows.Add(fila);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            List<Viaje> aux = new List<Viaje>();

            foreach (Viaje item in Listas.viajes)
            {
                if (item.CiudadDeDestino.ToLower().Contains(txtBuscador.Text.ToLower()))
                {
                    aux.Add(item);
                }
            }

            ActualizarGrid(aux);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.dgvLista.SelectedRows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvLista.SelectedRows.Count > 0)
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

                //avion.Pasajeros.Add(new Pasajero("Santiago", "Ianello", 43212312, 22, ETipoEquipaje.Ambos, 12));

                FrmListar fm2 = new FrmListar(1, avion.Pasajeros);
                fm2.label1.Text = "";
                fm2.txtBuscador.Visible = false;
                fm2.txtBuscador.Location = new Point(133, 25);
                fm2.dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                fm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se debera elegir un viaje...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
