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
            mthFecha = new MonthCalendar();
            cmbPartida = new ComboBox();
            cmbDestino = new ComboBox();
            lblPartida = new Label();
            lblDestino = new Label();
            lblFecha = new Label();
            cmbAvion = new ComboBox();
            lblAvion = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(70, 462);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(300, 462);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(147, 34);
            lblTitulo.Size = new Size(128, 26);
            lblTitulo.Text = "Agregar Viaje";
            // 
            // mthFecha
            // 
            mthFecha.Location = new Point(147, 257);
            mthFecha.Name = "mthFecha";
            mthFecha.TabIndex = 7;
            // 
            // cmbPartida
            // 
            cmbPartida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartida.FlatStyle = FlatStyle.Popup;
            cmbPartida.FormattingEnabled = true;
            cmbPartida.Location = new Point(147, 79);
            cmbPartida.Name = "cmbPartida";
            cmbPartida.Size = new Size(181, 23);
            cmbPartida.TabIndex = 10;
            cmbPartida.SelectedIndexChanged += cmbPartida_SelectedIndexChanged;
            // 
            // cmbDestino
            // 
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.FlatStyle = FlatStyle.Popup;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(147, 144);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(181, 23);
            cmbDestino.TabIndex = 11;
            // 
            // lblPartida
            // 
            lblPartida.AutoSize = true;
            lblPartida.Location = new Point(70, 87);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(47, 15);
            lblPartida.TabIndex = 12;
            lblPartida.Text = "Partida:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(70, 152);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(50, 15);
            lblDestino.TabIndex = 13;
            lblDestino.Text = "Destino:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(70, 257);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 15;
            lblFecha.Text = "Fecha:";
            // 
            // cmbAvion
            // 
            cmbAvion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvion.FlatStyle = FlatStyle.Popup;
            cmbAvion.FormattingEnabled = true;
            cmbAvion.Location = new Point(147, 203);
            cmbAvion.Name = "cmbAvion";
            cmbAvion.Size = new Size(181, 23);
            cmbAvion.TabIndex = 16;
            cmbAvion.SelectedIndexChanged += cmbAvion_SelectedIndexChanged;
            // 
            // lblAvion
            // 
            lblAvion.AutoSize = true;
            lblAvion.Location = new Point(70, 211);
            lblAvion.Name = "lblAvion";
            lblAvion.Size = new Size(41, 15);
            lblAvion.TabIndex = 17;
            lblAvion.Text = "Avion:";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Location = new Point(-2, 501);
            label1.Name = "label1";
            label1.Size = new Size(449, 10);
            label1.TabIndex = 41;
            // 
            // FrmAgregarViaje
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(445, 507);
            Controls.Add(label1);
            Controls.Add(lblAvion);
            Controls.Add(cmbAvion);
            Controls.Add(lblFecha);
            Controls.Add(lblDestino);
            Controls.Add(lblPartida);
            Controls.Add(cmbDestino);
            Controls.Add(cmbPartida);
            Controls.Add(mthFecha);
            Name = "FrmAgregarViaje";
            Text = "Agregar viaje";
            Load += FrmAgregarViaje_Load;
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(mthFecha, 0);
            Controls.SetChildIndex(cmbPartida, 0);
            Controls.SetChildIndex(cmbDestino, 0);
            Controls.SetChildIndex(lblPartida, 0);
            Controls.SetChildIndex(lblDestino, 0);
            Controls.SetChildIndex(lblFecha, 0);
            Controls.SetChildIndex(cmbAvion, 0);
            Controls.SetChildIndex(lblAvion, 0);
            Controls.SetChildIndex(label1, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPartida;
        private Label lblDestino;
        private Label lblFecha;
        private Label lblAvion;
        protected MonthCalendar mthFecha;
        protected ComboBox cmbPartida;
        protected ComboBox cmbDestino;
        protected ComboBox cmbAvion;
        private Label label1;
    }
}