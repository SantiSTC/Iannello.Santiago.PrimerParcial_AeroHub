namespace Form_Aerolinea
{
    partial class FrmAgregarViaje
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
            txtCantidad = new TextBox();
            mthFecha = new MonthCalendar();
            cmbPartida = new ComboBox();
            cmbDestino = new ComboBox();
            lblPartida = new Label();
            lblDestino = new Label();
            lblCantidad = new Label();
            lblFecha = new Label();
            cmbAvion = new ComboBox();
            lblAvion = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(239, 9);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(438, 286);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(438, 348);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(332, 71);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(29, 23);
            txtCantidad.TabIndex = 5;
            // 
            // mthFecha
            // 
            mthFecha.Location = new Point(111, 209);
            mthFecha.Name = "mthFecha";
            mthFecha.TabIndex = 7;
            // 
            // cmbPartida
            // 
            cmbPartida.FormattingEnabled = true;
            cmbPartida.Location = new Point(94, 71);
            cmbPartida.Name = "cmbPartida";
            cmbPartida.Size = new Size(121, 23);
            cmbPartida.TabIndex = 10;
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(94, 131);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(121, 23);
            cmbDestino.TabIndex = 11;
            // 
            // lblPartida
            // 
            lblPartida.AutoSize = true;
            lblPartida.Location = new Point(23, 76);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(47, 15);
            lblPartida.TabIndex = 12;
            lblPartida.Text = "Partida:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(23, 139);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(50, 15);
            lblDestino.TabIndex = 13;
            lblDestino.Text = "Destino:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(255, 76);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 14;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(23, 209);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 15;
            lblFecha.Text = "Fecha:";
            // 
            // cmbAvion
            // 
            cmbAvion.FormattingEnabled = true;
            cmbAvion.Location = new Point(332, 131);
            cmbAvion.Name = "cmbAvion";
            cmbAvion.Size = new Size(181, 23);
            cmbAvion.TabIndex = 16;
            // 
            // lblAvion
            // 
            lblAvion.AutoSize = true;
            lblAvion.Location = new Point(255, 139);
            lblAvion.Name = "lblAvion";
            lblAvion.Size = new Size(41, 15);
            lblAvion.TabIndex = 17;
            lblAvion.Text = "Avion:";
            // 
            // FrmAgregarViaje
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(546, 396);
            Controls.Add(lblAvion);
            Controls.Add(cmbAvion);
            Controls.Add(lblFecha);
            Controls.Add(lblCantidad);
            Controls.Add(lblDestino);
            Controls.Add(lblPartida);
            Controls.Add(cmbDestino);
            Controls.Add(cmbPartida);
            Controls.Add(mthFecha);
            Controls.Add(txtCantidad);
            Name = "FrmAgregarViaje";
            Text = "FrmAgregarViaje";
            Load += FrmAgregarViaje_Load;
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(txtCantidad, 0);
            Controls.SetChildIndex(mthFecha, 0);
            Controls.SetChildIndex(cmbPartida, 0);
            Controls.SetChildIndex(cmbDestino, 0);
            Controls.SetChildIndex(lblPartida, 0);
            Controls.SetChildIndex(lblDestino, 0);
            Controls.SetChildIndex(lblCantidad, 0);
            Controls.SetChildIndex(lblFecha, 0);
            Controls.SetChildIndex(cmbAvion, 0);
            Controls.SetChildIndex(lblAvion, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantidad;
        private MonthCalendar mthFecha;
        private ComboBox cmbPartida;
        private ComboBox cmbDestino;
        private Label lblPartida;
        private Label lblDestino;
        private Label lblCantidad;
        private Label lblFecha;
        private ComboBox cmbAvion;
        private Label lblAvion;
    }
}