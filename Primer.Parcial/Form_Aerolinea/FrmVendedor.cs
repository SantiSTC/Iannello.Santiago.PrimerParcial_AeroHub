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
    public partial class FrmVendedor : FrmMenu
    {
        public FrmVendedor(string nombre, string apellido, EPerfil perfil) : base(nombre, apellido, perfil)
        {
            InitializeComponent();
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void lnkPasajeros_Click(object sender, EventArgs e)
        {
            FrmCRUD fm = new FrmCRUD(3);
            fm.ShowDialog();
        }

        private void lnkListaViajes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmListar fm = new FrmListar(Listas.viajes);
            fm.ShowDialog();
        }

        private void lnkVenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmVenderViaje fm = new FrmVenderViaje();
            fm.ShowDialog();
        }
    }
}
