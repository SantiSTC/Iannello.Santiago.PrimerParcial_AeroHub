﻿namespace Form_Aerolinea
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
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.Location = new Point(165, 9);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 462);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(267, 462);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mthFecha
            // 
            mthFecha.Location = new Point(94, 254);
            mthFecha.Name = "mthFecha";
            mthFecha.TabIndex = 7;
            // 
            // cmbPartida
            // 
            cmbPartida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartida.FormattingEnabled = true;
            cmbPartida.Location = new Point(94, 66);
            cmbPartida.Name = "cmbPartida";
            cmbPartida.Size = new Size(181, 23);
            cmbPartida.TabIndex = 10;
            cmbPartida.SelectedIndexChanged += cmbPartida_SelectedIndexChanged;
            // 
            // cmbDestino
            // 
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(94, 131);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(181, 23);
            cmbDestino.TabIndex = 11;
            // 
            // lblPartida
            // 
            lblPartida.AutoSize = true;
            lblPartida.Location = new Point(17, 74);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(47, 15);
            lblPartida.TabIndex = 12;
            lblPartida.Text = "Partida:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(17, 139);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(50, 15);
            lblDestino.TabIndex = 13;
            lblDestino.Text = "Destino:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(17, 254);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 15;
            lblFecha.Text = "Fecha:";
            // 
            // cmbAvion
            // 
            cmbAvion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvion.FormattingEnabled = true;
            cmbAvion.Location = new Point(94, 190);
            cmbAvion.Name = "cmbAvion";
            cmbAvion.Size = new Size(181, 23);
            cmbAvion.TabIndex = 16;
            // 
            // lblAvion
            // 
            lblAvion.AutoSize = true;
            lblAvion.Location = new Point(17, 198);
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
            ClientSize = new Size(383, 507);
            Controls.Add(lblAvion);
            Controls.Add(cmbAvion);
            Controls.Add(lblFecha);
            Controls.Add(lblDestino);
            Controls.Add(lblPartida);
            Controls.Add(cmbDestino);
            Controls.Add(cmbPartida);
            Controls.Add(mthFecha);
            Name = "FrmAgregarViaje";
            Text = "A";
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
    }
}