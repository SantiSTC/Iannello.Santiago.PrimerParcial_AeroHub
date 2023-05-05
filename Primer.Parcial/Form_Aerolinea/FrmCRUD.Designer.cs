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
            dvgLista = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgLista).BeginInit();
            SuspendLayout();
            // 
            // dvgLista
            // 
            dvgLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgLista.BackgroundColor = SystemColors.ControlLightLight;
            dvgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgLista.Location = new Point(12, 12);
            dvgLista.Name = "dvgLista";
            dvgLista.ReadOnly = true;
            dvgLista.RowTemplate.Height = 25;
            dvgLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgLista.Size = new Size(645, 344);
            dvgLista.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(400, 381);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(492, 381);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(583, 381);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 431);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dvgLista);
            Name = "FrmCRUD";
            Text = "FrmCRUD";
            Load += FrmCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dvgLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgLista;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}