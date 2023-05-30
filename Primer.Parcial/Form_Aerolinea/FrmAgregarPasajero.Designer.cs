namespace Form_Aerolinea
{
    partial class FrmAgregarPasajero
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtEdad = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblEdad = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.Location = new Point(128, 34);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Size = new Size(173, 26);
            lblTitulo.Text = "Agregar Pasajero";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Location = new Point(144, 1);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.Location = new Point(79, 283);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.Location = new Point(291, 283);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(217, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(217, 120);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDni.Location = new Point(217, 168);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEdad.Location = new Point(217, 221);
            txtEdad.MaximumSize = new Size(28, 23);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(28, 23);
            txtEdad.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(100, 80);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(100, 128);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Location = new Point(100, 176);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(28, 15);
            lblDni.TabIndex = 8;
            lblDni.Text = "Dni:";
            // 
            // lblEdad
            // 
            lblEdad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(100, 229);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 9;
            lblEdad.Text = "Edad:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.HotTrack;
            label1.Location = new Point(-3, 326);
            label1.Name = "label1";
            label1.Size = new Size(449, 10);
            label1.TabIndex = 41;
            // 
            // FrmAgregarPasajero
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(445, 334);
            Controls.Add(label1);
            Controls.Add(lblEdad);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtEdad);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmAgregarPasajero";
            Text = "FrmAgregarPasajero";
            Load += FrmAgregarPasajero_Load;
            Controls.SetChildIndex(pictureBox2, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtApellido, 0);
            Controls.SetChildIndex(txtDni, 0);
            Controls.SetChildIndex(txtEdad, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblApellido, 0);
            Controls.SetChildIndex(lblDni, 0);
            Controls.SetChildIndex(lblEdad, 0);
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(label1, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblEdad;
        protected TextBox txtNombre;
        protected TextBox txtApellido;
        protected TextBox txtDni;
        protected TextBox txtEdad;
        private Label label1;
    }
}