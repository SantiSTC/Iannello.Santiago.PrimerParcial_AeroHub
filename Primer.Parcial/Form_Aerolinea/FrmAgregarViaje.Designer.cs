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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(100, 759);
            btnAgregar.Margin = new Padding(6, 8, 6, 8);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(429, 759);
            btnCancelar.Margin = new Padding(6, 8, 6, 8);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.Location = new Point(178, 58);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Size = new Size(276, 50);
            lblTitulo.Text = "Agregar Viaje";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(210, 2);
            pictureBox2.Margin = new Padding(6, 8, 6, 8);
            // 
            // mthFecha
            // 
            mthFecha.Location = new Point(210, 428);
            mthFecha.Margin = new Padding(13, 15, 13, 15);
            mthFecha.Name = "mthFecha";
            mthFecha.TabIndex = 7;
            // 
            // cmbPartida
            // 
            cmbPartida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartida.FlatStyle = FlatStyle.Popup;
            cmbPartida.FormattingEnabled = true;
            cmbPartida.Location = new Point(210, 132);
            cmbPartida.Margin = new Padding(4, 5, 4, 5);
            cmbPartida.Name = "cmbPartida";
            cmbPartida.Size = new Size(257, 33);
            cmbPartida.TabIndex = 10;
            cmbPartida.SelectedIndexChanged += cmbPartida_SelectedIndexChanged;
            // 
            // cmbDestino
            // 
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.FlatStyle = FlatStyle.Popup;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(210, 240);
            cmbDestino.Margin = new Padding(4, 5, 4, 5);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(257, 33);
            cmbDestino.TabIndex = 11;
            // 
            // lblPartida
            // 
            lblPartida.AutoSize = true;
            lblPartida.Location = new Point(100, 145);
            lblPartida.Margin = new Padding(4, 0, 4, 0);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(70, 25);
            lblPartida.TabIndex = 12;
            lblPartida.Text = "Partida:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(100, 253);
            lblDestino.Margin = new Padding(4, 0, 4, 0);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(77, 25);
            lblDestino.TabIndex = 13;
            lblDestino.Text = "Destino:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(100, 428);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(61, 25);
            lblFecha.TabIndex = 15;
            lblFecha.Text = "Fecha:";
            // 
            // cmbAvion
            // 
            cmbAvion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvion.FlatStyle = FlatStyle.Popup;
            cmbAvion.FormattingEnabled = true;
            cmbAvion.Location = new Point(210, 338);
            cmbAvion.Margin = new Padding(4, 5, 4, 5);
            cmbAvion.Name = "cmbAvion";
            cmbAvion.Size = new Size(257, 33);
            cmbAvion.TabIndex = 16;
            cmbAvion.SelectedIndexChanged += cmbAvion_SelectedIndexChanged;
            // 
            // lblAvion
            // 
            lblAvion.AutoSize = true;
            lblAvion.Location = new Point(100, 352);
            lblAvion.Margin = new Padding(4, 0, 4, 0);
            lblAvion.Name = "lblAvion";
            lblAvion.Size = new Size(62, 25);
            lblAvion.TabIndex = 17;
            lblAvion.Text = "Avion:";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Location = new Point(-3, 835);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(641, 17);
            label1.TabIndex = 41;
            // 
            // FrmAgregarViaje
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(636, 845);
            Controls.Add(label1);
            Controls.Add(lblAvion);
            Controls.Add(cmbAvion);
            Controls.Add(lblFecha);
            Controls.Add(lblDestino);
            Controls.Add(lblPartida);
            Controls.Add(cmbDestino);
            Controls.Add(cmbPartida);
            Controls.Add(mthFecha);
            Margin = new Padding(6, 8, 6, 8);
            Name = "FrmAgregarViaje";
            Text = "Agregar viaje";
            Load += FrmAgregarViaje_Load;
            Controls.SetChildIndex(pictureBox2, 0);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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