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
            chkDeMano = new CheckBox();
            chkBodega = new CheckBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblEdad = new Label();
            lblEquipaje = new Label();
            lblPeso = new Label();
            txtPeso = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(149, 9);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(32, 381);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(244, 381);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(149, 113);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(149, 161);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(149, 214);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(28, 23);
            txtEdad.TabIndex = 3;
            // 
            // chkDeMano
            // 
            chkDeMano.AutoSize = true;
            chkDeMano.Location = new Point(241, 271);
            chkDeMano.Name = "chkDeMano";
            chkDeMano.Size = new Size(74, 19);
            chkDeMano.TabIndex = 4;
            chkDeMano.Text = "De Mano";
            chkDeMano.UseVisualStyleBackColor = true;
            chkDeMano.CheckedChanged += chkDeMano_CheckedChanged;
            // 
            // chkBodega
            // 
            chkBodega.AutoSize = true;
            chkBodega.Location = new Point(149, 271);
            chkBodega.Name = "chkBodega";
            chkBodega.Size = new Size(86, 19);
            chkBodega.TabIndex = 5;
            chkBodega.Text = "De Bodega:";
            chkBodega.UseVisualStyleBackColor = true;
            chkBodega.CheckedChanged += chkBodega_CheckedChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(32, 121);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(32, 169);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(28, 15);
            lblDni.TabIndex = 8;
            lblDni.Text = "Dni:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(32, 222);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 9;
            lblEdad.Text = "Edad:";
            // 
            // lblEquipaje
            // 
            lblEquipaje.AutoSize = true;
            lblEquipaje.Location = new Point(32, 272);
            lblEquipaje.Name = "lblEquipaje";
            lblEquipaje.Size = new Size(55, 15);
            lblEquipaje.TabIndex = 10;
            lblEquipaje.Text = "Equipaje:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(32, 330);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(35, 15);
            lblPeso.TabIndex = 12;
            lblPeso.Text = "Peso:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(149, 322);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(28, 23);
            txtPeso.TabIndex = 11;
            // 
            // FrmAgregarPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 427);
            Controls.Add(lblPeso);
            Controls.Add(txtPeso);
            Controls.Add(lblEquipaje);
            Controls.Add(lblEdad);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(chkBodega);
            Controls.Add(chkDeMano);
            Controls.Add(txtEdad);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FrmAgregarPasajero";
            Text = "FrmAgregarPasajero";
            Load += FrmAgregarPasajero_Load;
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtApellido, 0);
            Controls.SetChildIndex(txtDni, 0);
            Controls.SetChildIndex(txtEdad, 0);
            Controls.SetChildIndex(chkDeMano, 0);
            Controls.SetChildIndex(chkBodega, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblApellido, 0);
            Controls.SetChildIndex(lblDni, 0);
            Controls.SetChildIndex(lblEdad, 0);
            Controls.SetChildIndex(lblEquipaje, 0);
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(txtPeso, 0);
            Controls.SetChildIndex(lblPeso, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblEdad;
        private Label lblEquipaje;
        private Label lblPeso;
        protected TextBox txtNombre;
        protected TextBox txtApellido;
        protected TextBox txtDni;
        protected TextBox txtEdad;
        protected CheckBox chkDeMano;
        protected CheckBox chkBodega;
        protected TextBox txtPeso;
    }
}