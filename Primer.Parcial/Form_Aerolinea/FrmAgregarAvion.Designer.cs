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
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(129, 34);
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(216, 88);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 3;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(216, 238);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(100, 23);
            txtCapacidad.TabIndex = 4;
            // 
            // txtBanios
            // 
            txtBanios.Location = new Point(216, 192);
            txtBanios.Name = "txtBanios";
            txtBanios.Size = new Size(100, 23);
            txtBanios.TabIndex = 5;
            // 
            // txtAsientos
            // 
            txtAsientos.Location = new Point(216, 137);
            txtAsientos.Name = "txtAsientos";
            txtAsientos.Size = new Size(100, 23);
            txtAsientos.TabIndex = 6;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatricula.Location = new Point(65, 88);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(65, 15);
            lblMatricula.TabIndex = 9;
            lblMatricula.Text = "Matricula:";
            // 
            // lblAsientos
            // 
            lblAsientos.AutoSize = true;
            lblAsientos.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAsientos.Location = new Point(65, 137);
            lblAsientos.Name = "lblAsientos";
            lblAsientos.Size = new Size(57, 15);
            lblAsientos.TabIndex = 10;
            lblAsientos.Text = "Asientos:";
            // 
            // lblBanios
            // 
            lblBanios.AutoSize = true;
            lblBanios.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBanios.Location = new Point(65, 192);
            lblBanios.Name = "lblBanios";
            lblBanios.Size = new Size(44, 15);
            lblBanios.TabIndex = 11;
            lblBanios.Text = "Baños:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCapacidad.Location = new Point(65, 241);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(141, 17);
            lblCapacidad.TabIndex = 12;
            lblCapacidad.Text = "Capacidad de Bodega:";
            // 
            // lblInternet
            // 
            lblInternet.AutoSize = true;
            lblInternet.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInternet.Location = new Point(65, 292);
            lblInternet.Name = "lblInternet";
            lblInternet.Size = new Size(55, 17);
            lblInternet.TabIndex = 13;
            lblInternet.Text = "Internet:";
            // 
            // lblComida
            // 
            lblComida.AutoSize = true;
            lblComida.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComida.Location = new Point(65, 337);
            lblComida.Name = "lblComida";
            lblComida.Size = new Size(56, 17);
            lblComida.TabIndex = 14;
            lblComida.Text = "Comida:";
            // 
            // checkInternet
            // 
            checkInternet.Location = new Point(216, 285);
            checkInternet.Name = "checkInternet";
            checkInternet.Size = new Size(104, 24);
            checkInternet.TabIndex = 39;
            // 
            // checkComida
            // 
            checkComida.Location = new Point(216, 330);
            checkComida.Name = "checkComida";
            checkComida.Size = new Size(104, 24);
            checkComida.TabIndex = 38;
            // 
            // FrmAgregarAvion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
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
            Name = "FrmAgregarAvion";
            Text = "FrmAgregarAvion";
            Load += FrmAgregarAvion_Load;
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
    }
}