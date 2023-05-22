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
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.BackgroundColor = SystemColors.Control;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(35, 71);
            dgvLista.Name = "dgvLista";
            dgvLista.RowTemplate.Height = 25;
            dgvLista.Size = new Size(731, 346);
            dgvLista.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(691, 432);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Volver";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVerPasajeros
            // 
            btnVerPasajeros.Location = new Point(619, 25);
            btnVerPasajeros.Name = "btnVerPasajeros";
            btnVerPasajeros.Size = new Size(147, 23);
            btnVerPasajeros.TabIndex = 5;
            btnVerPasajeros.Text = "Ver Pasajeros";
            btnVerPasajeros.UseVisualStyleBackColor = true;
            btnVerPasajeros.Click += btnVerPasajeros_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Buscar viaje:";
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(113, 25);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = " Ingresar Destino";
            txtBuscador.Size = new Size(218, 23);
            txtBuscador.TabIndex = 3;
            // 
            // FrmListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(btnVerPasajeros);
            Controls.Add(label1);
            Controls.Add(txtBuscador);
            Controls.Add(btnCancelar);
            Controls.Add(dgvLista);
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
    }
}