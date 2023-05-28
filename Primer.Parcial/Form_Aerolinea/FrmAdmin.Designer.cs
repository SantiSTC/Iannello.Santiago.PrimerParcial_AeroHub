namespace Form_Aerolinea
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            pictureBox2 = new PictureBox();
            lblDescViaje = new Label();
            iconoViaje = new PictureBox();
            lblViaje = new Label();
            lblDescAeronave = new Label();
            iconoAeronave = new PictureBox();
            lblAeronave = new Label();
            lblFondoViaje = new Label();
            lblLogin = new Label();
            lblfondoAeronave = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoViaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoAeronave).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-1, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 50);
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // lblDescViaje
            // 
            lblDescViaje.AutoSize = true;
            lblDescViaje.Cursor = Cursors.Hand;
            lblDescViaje.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescViaje.ForeColor = SystemColors.ControlDarkDark;
            lblDescViaje.Location = new Point(105, 186);
            lblDescViaje.Margin = new Padding(2, 0, 2, 0);
            lblDescViaje.Name = "lblDescViaje";
            lblDescViaje.Size = new Size(486, 19);
            lblDescViaje.TabIndex = 32;
            lblDescViaje.Text = "Se podrá ver la lista de viajes, ademas de agregar, modificar o eliminar un viaje";
            lblDescViaje.Click += lblFondoViaje_Click;
            lblDescViaje.MouseEnter += lblFondoViaje_MouseEnter;
            lblDescViaje.MouseLeave += lblFondoViaje_MouseLeave;
            // 
            // iconoViaje
            // 
            iconoViaje.BackgroundImage = (Image)resources.GetObject("iconoViaje.BackgroundImage");
            iconoViaje.BackgroundImageLayout = ImageLayout.Zoom;
            iconoViaje.Cursor = Cursors.Hand;
            iconoViaje.Location = new Point(42, 164);
            iconoViaje.Margin = new Padding(2);
            iconoViaje.Name = "iconoViaje";
            iconoViaje.Size = new Size(49, 43);
            iconoViaje.TabIndex = 31;
            iconoViaje.TabStop = false;
            iconoViaje.Click += lblFondoViaje_Click;
            iconoViaje.MouseEnter += lblFondoViaje_MouseEnter;
            iconoViaje.MouseLeave += lblFondoViaje_MouseLeave;
            // 
            // lblViaje
            // 
            lblViaje.AutoSize = true;
            lblViaje.Cursor = Cursors.Hand;
            lblViaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblViaje.Location = new Point(105, 164);
            lblViaje.Margin = new Padding(2, 0, 2, 0);
            lblViaje.Name = "lblViaje";
            lblViaje.Size = new Size(56, 21);
            lblViaje.TabIndex = 30;
            lblViaje.Text = "Viajes";
            lblViaje.Click += lblFondoViaje_Click;
            lblViaje.MouseEnter += lblFondoViaje_MouseEnter;
            lblViaje.MouseLeave += lblFondoViaje_MouseLeave;
            // 
            // lblDescAeronave
            // 
            lblDescAeronave.AutoSize = true;
            lblDescAeronave.Cursor = Cursors.Hand;
            lblDescAeronave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescAeronave.ForeColor = SystemColors.ControlDarkDark;
            lblDescAeronave.Location = new Point(105, 103);
            lblDescAeronave.Margin = new Padding(2, 0, 2, 0);
            lblDescAeronave.Name = "lblDescAeronave";
            lblDescAeronave.Size = new Size(551, 19);
            lblDescAeronave.TabIndex = 29;
            lblDescAeronave.Text = "Se podrá ver la lista de aeronaves, ademas de agregar, modificar o eliminar una aeronave";
            lblDescAeronave.Click += lblfondoAeronave_Click;
            lblDescAeronave.MouseEnter += lblfondoAeronave_MouseEnter;
            lblDescAeronave.MouseLeave += lblfondoAeronave_MouseLeave;
            // 
            // iconoAeronave
            // 
            iconoAeronave.BackColor = SystemColors.Window;
            iconoAeronave.BackgroundImage = (Image)resources.GetObject("iconoAeronave.BackgroundImage");
            iconoAeronave.BackgroundImageLayout = ImageLayout.Zoom;
            iconoAeronave.Cursor = Cursors.Hand;
            iconoAeronave.Location = new Point(42, 81);
            iconoAeronave.Margin = new Padding(2);
            iconoAeronave.Name = "iconoAeronave";
            iconoAeronave.Size = new Size(49, 43);
            iconoAeronave.TabIndex = 28;
            iconoAeronave.TabStop = false;
            iconoAeronave.Click += lblfondoAeronave_Click;
            iconoAeronave.MouseEnter += lblfondoAeronave_MouseEnter;
            iconoAeronave.MouseLeave += lblfondoAeronave_MouseLeave;
            // 
            // lblAeronave
            // 
            lblAeronave.AutoSize = true;
            lblAeronave.Cursor = Cursors.Hand;
            lblAeronave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAeronave.Location = new Point(105, 81);
            lblAeronave.Margin = new Padding(2, 0, 2, 0);
            lblAeronave.Name = "lblAeronave";
            lblAeronave.Size = new Size(90, 21);
            lblAeronave.TabIndex = 27;
            lblAeronave.Text = "Aeronaves";
            lblAeronave.Click += lblfondoAeronave_Click;
            lblAeronave.MouseEnter += lblfondoAeronave_MouseEnter;
            lblAeronave.MouseLeave += lblfondoAeronave_MouseLeave;
            // 
            // lblFondoViaje
            // 
            lblFondoViaje.BackColor = SystemColors.Window;
            lblFondoViaje.BorderStyle = BorderStyle.FixedSingle;
            lblFondoViaje.Cursor = Cursors.Hand;
            lblFondoViaje.Location = new Point(29, 152);
            lblFondoViaje.Margin = new Padding(2, 0, 2, 0);
            lblFondoViaje.Name = "lblFondoViaje";
            lblFondoViaje.Size = new Size(754, 69);
            lblFondoViaje.TabIndex = 26;
            lblFondoViaje.Click += lblFondoViaje_Click;
            lblFondoViaje.MouseEnter += lblFondoViaje_MouseEnter;
            lblFondoViaje.MouseLeave += lblFondoViaje_MouseLeave;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(354, 12);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(88, 33);
            lblLogin.TabIndex = 25;
            lblLogin.Text = "MENÚ";
            lblLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblfondoAeronave
            // 
            lblfondoAeronave.BackColor = SystemColors.Window;
            lblfondoAeronave.BorderStyle = BorderStyle.FixedSingle;
            lblfondoAeronave.Cursor = Cursors.Hand;
            lblfondoAeronave.Location = new Point(29, 69);
            lblfondoAeronave.Margin = new Padding(2, 0, 2, 0);
            lblfondoAeronave.Name = "lblfondoAeronave";
            lblfondoAeronave.Size = new Size(754, 69);
            lblfondoAeronave.TabIndex = 24;
            lblfondoAeronave.Click += lblfondoAeronave_Click;
            lblfondoAeronave.MouseEnter += lblfondoAeronave_MouseEnter;
            lblfondoAeronave.MouseLeave += lblfondoAeronave_MouseLeave;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(814, 458);
            Controls.Add(pictureBox2);
            Controls.Add(lblDescViaje);
            Controls.Add(iconoViaje);
            Controls.Add(lblViaje);
            Controls.Add(lblDescAeronave);
            Controls.Add(iconoAeronave);
            Controls.Add(lblAeronave);
            Controls.Add(lblFondoViaje);
            Controls.Add(lblLogin);
            Controls.Add(lblfondoAeronave);
            Name = "FrmAdmin";
            Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoViaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoAeronave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label lblDescViaje;
        private PictureBox iconoViaje;
        private Label lblViaje;
        private Label lblDescAeronave;
        private PictureBox iconoAeronave;
        private Label lblAeronave;
        private Label lblFondoViaje;
        private Label lblLogin;
        private Label lblfondoAeronave;
    }
}