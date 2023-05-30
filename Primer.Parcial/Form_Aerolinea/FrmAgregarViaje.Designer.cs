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
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.Location = new Point(125, 35);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Size = new Size(193, 30);
            lblTitulo.Text = "Agregar Viaje";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Location = new Point(147, 1);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.Location = new Point(70, 455);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.Location = new Point(297, 455);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mthFecha
            // 
            mthFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mthFecha.Location = new Point(147, 257);
            mthFecha.Name = "mthFecha";
            mthFecha.TabIndex = 7;
            // 
            // cmbPartida
            // 
            cmbPartida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            cmbDestino.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            lblPartida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPartida.AutoSize = true;
            lblPartida.Location = new Point(70, 87);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(47, 15);
            lblPartida.TabIndex = 12;
            lblPartida.Text = "Partida:";
            // 
            // lblDestino
            // 
            lblDestino.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(70, 152);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(50, 15);
            lblDestino.TabIndex = 13;
            lblDestino.Text = "Destino:";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(70, 257);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 15;
            lblFecha.Text = "Fecha:";
            // 
            // cmbAvion
            // 
            cmbAvion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            lblAvion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAvion.AutoSize = true;
            lblAvion.Location = new Point(70, 211);
            lblAvion.Name = "lblAvion";
            lblAvion.Size = new Size(41, 15);
            lblAvion.TabIndex = 17;
            lblAvion.Text = "Avion:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.HotTrack;
            label1.Location = new Point(-2, 501);
            label1.Name = "label1";
            label1.Size = new Size(449, 10);
            label1.TabIndex = 41;
            // 
            // FrmAgregarViaje
            // 
            AcceptButton = btnAgregar;
            AutoScaleMode = AutoScaleMode.Inherit;
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
            Margin = new Padding(4, 5, 4, 5);
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