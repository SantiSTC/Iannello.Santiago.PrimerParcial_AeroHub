namespace Form_Aerolinea
{
    partial class FrmAgregarAvion
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
            txtMatricula = new TextBox();
            txtCapacidad = new TextBox();
            txtBanios = new TextBox();
            txtAsientos = new TextBox();
            lblMatricula = new Label();
            lblAsientos = new Label();
            lblBanios = new Label();
            lblCapacidad = new Label();
            lblInternet = new Label();
            lblComida = new Label();
            checkInternet = new CheckBox();
            checkComida = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(161, 1117);
            btnAgregar.Margin = new Padding(6, 8, 6, 8);
            btnAgregar.Size = new Size(153, 63);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(594, 1117);
            btnCancelar.Margin = new Padding(6, 8, 6, 8);
            btnCancelar.Size = new Size(153, 63);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(171, 56);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(309, 147);
            txtMatricula.Margin = new Padding(4, 5, 4, 5);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(141, 31);
            txtMatricula.TabIndex = 3;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(309, 397);
            txtCapacidad.Margin = new Padding(4, 5, 4, 5);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(141, 31);
            txtCapacidad.TabIndex = 4;
            // 
            // txtBanios
            // 
            txtBanios.Location = new Point(309, 320);
            txtBanios.Margin = new Padding(4, 5, 4, 5);
            txtBanios.Name = "txtBanios";
            txtBanios.Size = new Size(141, 31);
            txtBanios.TabIndex = 5;
            // 
            // txtAsientos
            // 
            txtAsientos.Location = new Point(309, 228);
            txtAsientos.Margin = new Padding(4, 5, 4, 5);
            txtAsientos.Name = "txtAsientos";
            txtAsientos.Size = new Size(141, 31);
            txtAsientos.TabIndex = 6;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatricula.Location = new Point(93, 147);
            lblMatricula.Margin = new Padding(4, 0, 4, 0);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(95, 24);
            lblMatricula.TabIndex = 9;
            lblMatricula.Text = "Matricula:";
            // 
            // lblAsientos
            // 
            lblAsientos.AutoSize = true;
            lblAsientos.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAsientos.Location = new Point(93, 228);
            lblAsientos.Margin = new Padding(4, 0, 4, 0);
            lblAsientos.Name = "lblAsientos";
            lblAsientos.Size = new Size(87, 24);
            lblAsientos.TabIndex = 10;
            lblAsientos.Text = "Asientos:";
            // 
            // lblBanios
            // 
            lblBanios.AutoSize = true;
            lblBanios.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanios.Location = new Point(93, 320);
            lblBanios.Margin = new Padding(4, 0, 4, 0);
            lblBanios.Name = "lblBanios";
            lblBanios.Size = new Size(66, 24);
            lblBanios.TabIndex = 11;
            lblBanios.Text = "Baños:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCapacidad.Location = new Point(93, 402);
            lblCapacidad.Margin = new Padding(4, 0, 4, 0);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(207, 28);
            lblCapacidad.TabIndex = 12;
            lblCapacidad.Text = "Capacidad de Bodega:";
            // 
            // lblInternet
            // 
            lblInternet.AutoSize = true;
            lblInternet.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInternet.Location = new Point(93, 487);
            lblInternet.Margin = new Padding(4, 0, 4, 0);
            lblInternet.Name = "lblInternet";
            lblInternet.Size = new Size(84, 28);
            lblInternet.TabIndex = 13;
            lblInternet.Text = "Internet:";
            // 
            // lblComida
            // 
            lblComida.AutoSize = true;
            lblComida.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComida.Location = new Point(93, 562);
            lblComida.Margin = new Padding(4, 0, 4, 0);
            lblComida.Name = "lblComida";
            lblComida.Size = new Size(84, 28);
            lblComida.TabIndex = 14;
            lblComida.Text = "Comida:";
            // 
            // checkInternet
            // 
            checkInternet.Location = new Point(309, 475);
            checkInternet.Margin = new Padding(4, 5, 4, 5);
            checkInternet.Name = "checkInternet";
            checkInternet.Size = new Size(149, 40);
            checkInternet.TabIndex = 39;
            // 
            // checkComida
            // 
            checkComida.Location = new Point(309, 550);
            checkComida.Margin = new Padding(4, 5, 4, 5);
            checkComida.Name = "checkComida";
            checkComida.Size = new Size(149, 40);
            checkComida.TabIndex = 38;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Location = new Point(-4, 740);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(641, 17);
            label1.TabIndex = 40;
            // 
            // FrmAgregarAvion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 750);
            Controls.Add(label1);
            Controls.Add(checkComida);
            Controls.Add(checkInternet);
            Controls.Add(lblComida);
            Controls.Add(lblInternet);
            Controls.Add(lblCapacidad);
            Controls.Add(lblBanios);
            Controls.Add(lblAsientos);
            Controls.Add(lblMatricula);
            Controls.Add(txtAsientos);
            Controls.Add(txtBanios);
            Controls.Add(txtCapacidad);
            Controls.Add(txtMatricula);
            Margin = new Padding(6, 8, 6, 8);
            Name = "FrmAgregarAvion";
            Text = "FrmAgregarAvion";
            Load += FrmAgregarAvion_Load;
            Controls.SetChildIndex(pictureBox2, 0);
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(txtMatricula, 0);
            Controls.SetChildIndex(txtCapacidad, 0);
            Controls.SetChildIndex(txtBanios, 0);
            Controls.SetChildIndex(txtAsientos, 0);
            Controls.SetChildIndex(lblMatricula, 0);
            Controls.SetChildIndex(lblAsientos, 0);
            Controls.SetChildIndex(lblBanios, 0);
            Controls.SetChildIndex(lblCapacidad, 0);
            Controls.SetChildIndex(lblInternet, 0);
            Controls.SetChildIndex(lblComida, 0);
            Controls.SetChildIndex(checkInternet, 0);
            Controls.SetChildIndex(checkComida, 0);
            Controls.SetChildIndex(label1, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMatricula;
        private Label lblAsientos;
        private Label lblBanios;
        private Label lblCapacidad;
        private Label lblInternet;
        private Label lblComida;
        protected TextBox txtMatricula;
        protected TextBox txtCapacidad;
        protected TextBox txtBanios;
        protected TextBox txtAsientos;
        protected CheckBox checkInternet;
        protected CheckBox checkComida;
        private Label label1;
    }
}