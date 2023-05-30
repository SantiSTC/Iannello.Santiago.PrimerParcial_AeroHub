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
    public partial class FrmEstadisticas : Form
    {
        private string cadena;
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void lblfondoRecaudacion_Click(object sender, EventArgs e)
        {
            this.cadena = "La recaudacion total es de: $";
            this.cadena += Estadistica.ObtenerRecaudacion().ToString();

            FrmResultadosEstadistica fm = new FrmResultadosEstadistica(this.cadena);
            fm.FormClosed += FrmEstadisticas_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void lblFondoFacturacion_Click(object sender, EventArgs e)
        {
            this.cadena = "Destinos ordenados por facturacion: \n\n";

            foreach (string item in Estadistica.ObtenerDestinosOrdenadosPorFacturacion())
            {
                this.cadena += item + "\n";
            }

            FrmResultadosEstadistica fm = new FrmResultadosEstadistica(this.cadena);
            fm.FormClosed += FrmEstadisticas_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void lblFondoHoras_Click(object sender, EventArgs e)
        {
            this.cadena = "Horas de vuelo por aeronave: \n\n";

            foreach (KeyValuePair<string, int> item in Estadistica.ObtenerHorasDeVueloPorAeronave())
            {
                this.cadena += $"Aeronave: {item.Key} - {item.Value}hs.\n";
            }

            FrmResultadosEstadistica fm = new FrmResultadosEstadistica(this.cadena);
            fm.FormClosed += FrmEstadisticas_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void lblFondoGananciaPS_Click(object sender, EventArgs e)
        {
            this.cadena = "Ganancias totales segun servicio: \n\n";

            foreach (KeyValuePair<string, float> item in Estadistica.ObtenerGananciasTotalesSegunServicio())
            {
                cadena += $"{item.Key}: ${item.Value}.\n";
            }

            FrmResultadosEstadistica fm = new FrmResultadosEstadistica(this.cadena);
            fm.FormClosed += FrmEstadisticas_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void lblFondoPasajeros_Click(object sender, EventArgs e)
        {
            this.cadena = "Pasajeros por vuelo: \n\n";

            foreach (KeyValuePair<string, int> item in Estadistica.ObtenerCantidadDePasajerosPorVuelo())
            {
                cadena += $"{item.Key}: {item.Value} pasajeros.\n";
            }

            FrmResultadosEstadistica fm = new FrmResultadosEstadistica(this.cadena);
            fm.FormClosed += FrmEstadisticas_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void lblFondoDestino_Click(object sender, EventArgs e)
        {
            this.cadena = $"El destino mas elegido es: {Estadistica.ObtenerDestinoMasElegido()}";

            FrmResultadosEstadistica fm = new FrmResultadosEstadistica(this.cadena);
            fm.FormClosed += FrmEstadisticas_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void lblFondoFrecuentes_Click(object sender, EventArgs e)
        {
            this.cadena = "Pasajeros frecuentes: \n\n";

            foreach (KeyValuePair<string, int> item in Estadistica.ObtenerPasajerosFrecuentes())
            {
                cadena += $"{item.Key}: {item.Value} viajes.\n";
            }

            FrmResultadosEstadistica fm = new FrmResultadosEstadistica(this.cadena);
            fm.FormClosed += FrmEstadisticas_FormClosed;
            this.Hide();
            fm.ShowDialog();
        }

        private void lblfondoRecaudacion_MouseEnter(object sender, EventArgs e)
        {
            lblfondoRecaudacion.BackColor = SystemColors.HotTrack;
            lblRecaudacion.BackColor = SystemColors.HotTrack;
            lblDescRecaudacion.BackColor = SystemColors.HotTrack;
            iconoRecaudacion.BackColor = SystemColors.HotTrack;
            lblRecaudacion.ForeColor = SystemColors.Window;
            lblDescRecaudacion.ForeColor = SystemColors.Window;
        }

        private void lblfondoRecaudacion_MouseLeave(object sender, EventArgs e)
        {
            lblfondoRecaudacion.BackColor = SystemColors.Window;
            lblRecaudacion.BackColor = SystemColors.Window;
            lblDescRecaudacion.BackColor = SystemColors.Window;
            iconoRecaudacion.BackColor = SystemColors.Window;
            lblRecaudacion.ForeColor = SystemColors.ControlText;
            lblDescRecaudacion.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lblFondoPasajeros_MouseEnter(object sender, EventArgs e)
        {
            lblFondoPasajeros.BackColor = SystemColors.HotTrack;
            lblPasajeros.BackColor = SystemColors.HotTrack;
            lblDescPasajeros.BackColor = SystemColors.HotTrack;
            iconoPasajeros.BackColor = SystemColors.HotTrack;
            lblPasajeros.ForeColor = SystemColors.Window;
            lblDescPasajeros.ForeColor = SystemColors.Window;
        }

        private void lblFondoPasajeros_MouseLeave(object sender, EventArgs e)
        {
            lblFondoPasajeros.BackColor = SystemColors.Window;
            lblPasajeros.BackColor = SystemColors.Window;
            lblDescPasajeros.BackColor = SystemColors.Window;
            iconoPasajeros.BackColor = SystemColors.Window;
            lblPasajeros.ForeColor = SystemColors.ControlText;
            lblDescPasajeros.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lblFondoDestino_MouseEnter(object sender, EventArgs e)
        {
            lblFondoDestino.BackColor = SystemColors.HotTrack;
            lblDestino.BackColor = SystemColors.HotTrack;
            lblDescDestino.BackColor = SystemColors.HotTrack;
            iconoDestino.BackColor = SystemColors.HotTrack;
            lblDestino.ForeColor = SystemColors.Window;
            lblDescDestino.ForeColor = SystemColors.Window;
        }

        private void lblFondoDestino_MouseLeave(object sender, EventArgs e)
        {
            lblFondoDestino.BackColor = SystemColors.Window;
            lblDestino.BackColor = SystemColors.Window;
            lblDescDestino.BackColor = SystemColors.Window;
            iconoDestino.BackColor = SystemColors.Window;
            lblDestino.ForeColor = SystemColors.ControlText;
            lblDescDestino.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lblFondoFacturacion_MouseEnter(object sender, EventArgs e)
        {
            lblFondoFacturacion.BackColor = SystemColors.HotTrack;
            lblFacturacion.BackColor = SystemColors.HotTrack;
            lblDescFacturacion.BackColor = SystemColors.HotTrack;
            iconoFacturacion.BackColor = SystemColors.HotTrack;
            lblFacturacion.ForeColor = SystemColors.Window;
            lblDescFacturacion.ForeColor = SystemColors.Window;
        }

        private void lblFondoFacturacion_MouseLeave(object sender, EventArgs e)
        {
            lblFondoFacturacion.BackColor = SystemColors.Window;
            lblFacturacion.BackColor = SystemColors.Window;
            lblDescFacturacion.BackColor = SystemColors.Window;
            iconoFacturacion.BackColor = SystemColors.Window;
            lblFacturacion.ForeColor = SystemColors.ControlText;
            lblDescFacturacion.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lblFondoGananciaPS_MouseEnter(object sender, EventArgs e)
        {
            lblFondoGananciaPS.BackColor = SystemColors.HotTrack;
            lblGananciaPS.BackColor = SystemColors.HotTrack;
            lblDescGananciaPS.BackColor = SystemColors.HotTrack;
            iconoGananciaPS.BackColor = SystemColors.HotTrack;
            lblGananciaPS.ForeColor = SystemColors.Window;
            lblDescGananciaPS.ForeColor = SystemColors.Window;
        }

        private void lblFondoGananciaPS_MouseLeave(object sender, EventArgs e)
        {
            lblFondoGananciaPS.BackColor = SystemColors.Window;
            lblGananciaPS.BackColor = SystemColors.Window;
            lblDescGananciaPS.BackColor = SystemColors.Window;
            iconoGananciaPS.BackColor = SystemColors.Window;
            lblGananciaPS.ForeColor = SystemColors.ControlText;
            lblDescGananciaPS.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lblFondoHoras_MouseEnter(object sender, EventArgs e)
        {
            lblFondoHoras.BackColor = SystemColors.HotTrack;
            lblHoras.BackColor = SystemColors.HotTrack;
            lblDescHoras.BackColor = SystemColors.HotTrack;
            iconoHoras.BackColor = SystemColors.HotTrack;
            lblHoras.ForeColor = SystemColors.Window;
            lblDescHoras.ForeColor = SystemColors.Window;
        }

        private void lblFondoHoras_MouseLeave(object sender, EventArgs e)
        {
            lblFondoHoras.BackColor = SystemColors.Window;
            lblHoras.BackColor = SystemColors.Window;
            lblDescHoras.BackColor = SystemColors.Window;
            iconoHoras.BackColor = SystemColors.Window;
            lblHoras.ForeColor = SystemColors.ControlText;
            lblDescHoras.ForeColor = SystemColors.ControlDarkDark;
        }

        private void lblFondoFrecuentes_MouseEnter(object sender, EventArgs e)
        {
            lblFondoFrecuentes.BackColor = SystemColors.HotTrack;
            lblFrecuentes.BackColor = SystemColors.HotTrack;
            lblDescFrecuentes.BackColor = SystemColors.HotTrack;
            iconoFrecuentes.BackColor = SystemColors.HotTrack;
            lblFrecuentes.ForeColor = SystemColors.Window;
            lblDescFrecuentes.ForeColor = SystemColors.Window;
        }

        private void lblFondoFrecuentes_MouseLeave(object sender, EventArgs e)
        {
            lblFondoFrecuentes.BackColor = SystemColors.Window;
            lblFrecuentes.BackColor = SystemColors.Window;
            lblDescFrecuentes.BackColor = SystemColors.Window;
            iconoFrecuentes.BackColor = SystemColors.Window;
            lblFrecuentes.ForeColor = SystemColors.ControlText;
            lblDescFrecuentes.ForeColor = SystemColors.ControlDarkDark;
        }
        private void FrmEstadisticas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}
