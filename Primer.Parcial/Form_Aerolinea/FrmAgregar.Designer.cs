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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregar));
            btnAgregar = new Button();
            btnCancelar = new Button();
            pictureBox2 = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Location = new Point(79, 402);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(291, 402);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(141, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(143, 29);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(141, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(80, 26);
            lblTitulo.TabIndex = 37;
            lblTitulo.Text = "Agregar";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmAgregar
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(454, 450);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected Label lblTitulo;
        protected PictureBox pictureBox2;
        protected Button btnAgregar;
        protected Button btnCancelar;
    }
}