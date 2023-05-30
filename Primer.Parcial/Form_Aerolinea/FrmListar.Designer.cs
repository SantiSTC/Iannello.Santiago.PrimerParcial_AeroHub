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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListar));
            dgvLista = new DataGridView();
            btnCancelar = new Button();
            txtBuscador = new TextBox();
            btnAceptar = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToResizeColumns = false;
            dgvLista.AllowUserToResizeRows = false;
            dgvLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLista.BackgroundColor = SystemColors.Window;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(35, 71);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.RowHeadersWidth = 62;
            dgvLista.RowTemplate.Height = 25;
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(731, 346);
            dgvLista.TabIndex = 1;
            dgvLista.DoubleClick += dgvLista_DoubleClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(691, 428);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Volver";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscador.Location = new Point(548, 27);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = " Buscar destino";
            txtBuscador.Size = new Size(218, 23);
            txtBuscador.TabIndex = 3;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Location = new Point(595, 428);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(35, 420);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(258, 15);
            label2.TabIndex = 7;
            label2.Text = "Doble click sobre un viaje para ver sus pasajeros";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(523, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 25);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(35, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 52);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.HotTrack;
            label1.Location = new Point(-2, 461);
            label1.Name = "label1";
            label1.Size = new Size(804, 7);
            label1.TabIndex = 42;
            // 
            // FrmListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 467);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(txtBuscador);
            Controls.Add(btnCancelar);
            Controls.Add(dgvLista);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListar";
            Load += FrmListar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvLista;
        private Button btnCancelar;
        private TextBox txtBuscador;
        public Button btnAceptar;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}