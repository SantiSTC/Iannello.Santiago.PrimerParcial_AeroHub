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
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            string cadena = "";

            //foreach (string item in Estadistica.ObtenerDestinosOrdenadosPorFacturacion()) 
            //{
            //    cadena += item + "\n";
            //}

            //MessageBox.Show($"{cadena}");

            //foreach (KeyValuePair<string, int> item in Estadistica.ObtenerHorasDeVueloPorAeronave()) 
            //{
            //    cadena += $"Aeronave: {item.Key} - {item.Value}hs.\n";
            //}
            //MessageBox.Show($"{cadena}");

            foreach (KeyValuePair<string, float> item in Estadistica.ObtenerGananciasTotalesSegunServicio())
            {
                cadena += $"{item.Key}: ${item.Value}.\n";
            }
            MessageBox.Show($"{cadena}");


        }
    }
}
