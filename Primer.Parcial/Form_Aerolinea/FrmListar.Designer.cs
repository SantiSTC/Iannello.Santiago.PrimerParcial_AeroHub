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
            btnVerPasajeros = new Button();
            label1 = new Label();
            txtBuscador = new TextBox();
            btnAceptar = new Button();
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
            dgvLista.Size = new Size(1044, 577);
            dgvLista.TabIndex = 1;
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
            // btnVerPasajeros
            // 
            btnVerPasajeros.Location = new Point(884, 42);
            btnVerPasajeros.Margin = new Padding(4, 5, 4, 5);
            btnVerPasajeros.Name = "btnVerPasajeros";
            btnVerPasajeros.Size = new Size(210, 38);
            btnVerPasajeros.TabIndex = 5;
            btnVerPasajeros.Text = "Ver Pasajeros";
            btnVerPasajeros.UseVisualStyleBackColor = true;
            btnVerPasajeros.Click += btnVerPasajeros_Click;
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
            // FrmListar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 778);
            Controls.Add(btnAceptar);
            Controls.Add(btnVerPasajeros);
            Controls.Add(label1);
            Controls.Add(txtBuscador);
            Controls.Add(btnCancelar);
            Controls.Add(dgvLista);
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
        private Button btnVerPasajeros;
        private Label label1;
        private TextBox txtBuscador;
        public Button btnAceptar;
    }
}