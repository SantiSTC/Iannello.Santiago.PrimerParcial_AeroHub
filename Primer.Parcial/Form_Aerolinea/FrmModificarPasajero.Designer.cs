﻿namespace Form_Aerolinea
{
    partial class FrmModificarPasajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(79, 282);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(291, 282);
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.Location = new Point(118, 34);
            lblTitulo.Size = new Size(187, 35);
            lblTitulo.Text = "Modificar Pasajero";
            // 
            // FrmModificarPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 332);
            Name = "FrmModificarPasajero";
            Text = "FrmModificarPasajero";
            Load += FrmModificarPasajero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}