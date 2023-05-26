namespace Form_Aerolinea
{
    partial class FrmListar
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
            dgvLista = new DataGridView();
            btnCancelar = new Button();
            label1 = new Label();
            txtBuscador = new TextBox();
            btnAceptar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToResizeColumns = false;
            dgvLista.AllowUserToResizeRows = false;
            dgvLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLista.BackgroundColor = SystemColors.Control;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(50, 118);
            dgvLista.Margin = new Padding(4, 5, 4, 5);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.RowHeadersWidth = 62;
            dgvLista.RowTemplate.Height = 25;
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(1044, 577);
            dgvLista.TabIndex = 1;
            dgvLista.DoubleClick += dgvLista_DoubleClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(987, 720);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 38);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Volver";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 4;
            label1.Text = "Buscar viaje:";
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(161, 42);
            txtBuscador.Margin = new Padding(4, 5, 4, 5);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = " Ingresar Destino";
            txtBuscador.Size = new Size(310, 31);
            txtBuscador.TabIndex = 3;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(854, 720);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(107, 38);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(50, 700);
            label2.Name = "label2";
            label2.Size = new Size(393, 25);
            label2.TabIndex = 7;
            label2.Text = "Doble click sobre un viaje para ver sus pasajeros";
            // 
            // FrmListar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 778);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(txtBuscador);
            Controls.Add(btnCancelar);
            Controls.Add(dgvLista);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmListar";
            Text = "FrmListar";
            Load += FrmListar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvLista;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtBuscador;
        public Button btnAceptar;
        private Label label2;
    }
}