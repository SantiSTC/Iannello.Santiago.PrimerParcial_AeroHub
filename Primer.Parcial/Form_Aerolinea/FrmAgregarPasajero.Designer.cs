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
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(213, 15);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(52, 471);
            btnAgregar.Margin = new Padding(6, 8, 6, 8);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(355, 471);
            btnCancelar.Margin = new Padding(6, 8, 6, 8);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(213, 108);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 31);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(213, 188);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(141, 31);
            txtApellido.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(213, 268);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(141, 31);
            txtDni.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(213, 357);
            txtEdad.Margin = new Padding(4, 5, 4, 5);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(38, 31);
            txtEdad.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(46, 122);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(46, 202);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(46, 282);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 25);
            lblDni.TabIndex = 8;
            lblDni.Text = "Dni:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(46, 370);
            lblEdad.Margin = new Padding(4, 0, 4, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(56, 25);
            lblEdad.TabIndex = 9;
            lblEdad.Text = "Edad:";
            // 
            // FrmAgregarPasajero
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 531);
            Controls.Add(lblEdad);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtEdad);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Margin = new Padding(6, 8, 6, 8);
            Name = "FrmAgregarPasajero";
            Text = "FrmAgregarPasajero";
            Load += FrmAgregarPasajero_Load;
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
    }
}