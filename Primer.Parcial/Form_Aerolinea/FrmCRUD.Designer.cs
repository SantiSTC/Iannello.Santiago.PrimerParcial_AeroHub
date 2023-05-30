namespace Form_Aerolinea
{
    partial class FrmCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCRUD));
            dgvLista = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToResizeColumns = false;
            dgvLista.AllowUserToResizeRows = false;
            dgvLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLista.BackgroundColor = SystemColors.ControlLightLight;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(23, 45);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.RowHeadersWidth = 62;
            dgvLista.RowTemplate.Height = 25;
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(623, 340);
            dgvLista.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Location = new Point(397, 398);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Location = new Point(485, 398);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(572, 398);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(23, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 37);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.HotTrack;
            label1.Location = new Point(-2, 433);
            label1.Name = "label1";
            label1.Size = new Size(675, 7);
            label1.TabIndex = 41;
            // 
            // FrmCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(669, 437);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvLista);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCRUD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado";
            Load += FrmCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLista;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private PictureBox pictureBox1;
        private Label label1;
    }
}