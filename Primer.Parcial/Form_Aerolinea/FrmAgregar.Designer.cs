namespace Form_Aerolinea
{
    partial class FrmAgregar
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
            lblTitulo = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(203, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "label1";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(79, 402);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(291, 402);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTitulo);
            Name = "FrmAgregar";
            Text = "Agregar";
            Load += Agregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label lblTitulo;
        protected Button btnAgregar;
        protected Button btnCancelar;
    }
}