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
            checkInternet = new CheckBox();
            checkComida = new CheckBox();
            lblMatricula = new Label();
            lblAsientos = new Label();
            lblBanios = new Label();
            lblCapacidad = new Label();
            lblInternet = new Label();
            lblComida = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(176, 19);
            // 
            // btnAgregar
            // 
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(208, 72);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 3;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(208, 222);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(100, 23);
            txtCapacidad.TabIndex = 4;
            // 
            // txtBanios
            // 
            txtBanios.Location = new Point(208, 176);
            txtBanios.Name = "txtBanios";
            txtBanios.Size = new Size(100, 23);
            txtBanios.TabIndex = 5;
            // 
            // txtAsientos
            // 
            txtAsientos.Location = new Point(208, 121);
            txtAsientos.Name = "txtAsientos";
            txtAsientos.Size = new Size(100, 23);
            txtAsientos.TabIndex = 6;
            // 
            // checkInternet
            // 
            checkInternet.AutoSize = true;
            checkInternet.Location = new Point(208, 276);
            checkInternet.Name = "checkInternet";
            checkInternet.Size = new Size(15, 14);
            checkInternet.TabIndex = 7;
            checkInternet.UseVisualStyleBackColor = true;
            // 
            // checkComida
            // 
            checkComida.AutoSize = true;
            checkComida.Location = new Point(208, 321);
            checkComida.Name = "checkComida";
            checkComida.Size = new Size(15, 14);
            checkComida.TabIndex = 8;
            checkComida.UseVisualStyleBackColor = true;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(63, 72);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 9;
            lblMatricula.Text = "Matricula:";
            // 
            // lblAsientos
            // 
            lblAsientos.AutoSize = true;
            lblAsientos.Location = new Point(63, 121);
            lblAsientos.Name = "lblAsientos";
            lblAsientos.Size = new Size(55, 15);
            lblAsientos.TabIndex = 10;
            lblAsientos.Text = "Asientos:";
            // 
            // lblBanios
            // 
            lblBanios.AutoSize = true;
            lblBanios.Location = new Point(63, 176);
            lblBanios.Name = "lblBanios";
            lblBanios.Size = new Size(42, 15);
            lblBanios.TabIndex = 11;
            lblBanios.Text = "Baños:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(63, 222);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(125, 15);
            lblCapacidad.TabIndex = 12;
            lblCapacidad.Text = "Capacidad de Bodega:";
            // 
            // lblInternet
            // 
            lblInternet.AutoSize = true;
            lblInternet.Location = new Point(63, 276);
            lblInternet.Name = "lblInternet";
            lblInternet.Size = new Size(51, 15);
            lblInternet.TabIndex = 13;
            lblInternet.Text = "Internet:";
            // 
            // lblComida
            // 
            lblComida.AutoSize = true;
            lblComida.Location = new Point(63, 321);
            lblComida.Name = "lblComida";
            lblComida.Size = new Size(52, 15);
            lblComida.TabIndex = 14;
            lblComida.Text = "Comida:";
            // 
            // FrmAgregarAvion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 450);
            Controls.Add(lblComida);
            Controls.Add(lblInternet);
            Controls.Add(lblCapacidad);
            Controls.Add(lblBanios);
            Controls.Add(lblAsientos);
            Controls.Add(lblMatricula);
            Controls.Add(checkComida);
            Controls.Add(checkInternet);
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
            Controls.SetChildIndex(checkInternet, 0);
            Controls.SetChildIndex(checkComida, 0);
            Controls.SetChildIndex(lblMatricula, 0);
            Controls.SetChildIndex(lblAsientos, 0);
            Controls.SetChildIndex(lblBanios, 0);
            Controls.SetChildIndex(lblCapacidad, 0);
            Controls.SetChildIndex(lblInternet, 0);
            Controls.SetChildIndex(lblComida, 0);
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