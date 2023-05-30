namespace Form_Aerolinea
{
    partial class FrmModificarAvion
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = SystemColors.ScrollBar;
            txtMatricula.Enabled = false;
            txtMatricula.Location = new Point(233, 88);
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(233, 238);
            // 
            // txtBanios
            // 
            txtBanios.Location = new Point(233, 192);
            // 
            // txtAsientos
            // 
            txtAsientos.Location = new Point(233, 137);
            // 
            // checkInternet
            // 
            checkInternet.Location = new Point(233, 285);
            // 
            // checkComida
            // 
            checkComida.Location = new Point(233, 330);
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(118, 34);
            lblTitulo.Size = new Size(184, 26);
            lblTitulo.Text = "Modificar Aeronave";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(139, 3);
            // 
            // btnAgregar
            // 
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmModificarAvion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
            MinimumSize = new Size(443, 489);
            Name = "FrmModificarAvion";
            Text = "Modificar Avion";
            Load += FrmModificarAvion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}