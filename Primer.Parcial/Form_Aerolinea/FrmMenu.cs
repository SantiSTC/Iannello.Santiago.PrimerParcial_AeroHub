﻿using System;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu() { }
        public FrmMenu(string nombre, string apellido, EPerfil perfil)
        {
            InitializeComponent();

            lblUsuarioMenu.Text = nombre;
            lblUsuarioMenu.Text += " " + apellido;
            lblPerfilMenu.Text = perfil.ToString();
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

    }
}