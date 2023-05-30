namespace Form_Aerolinea
{
    partial class FrmSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupervisor));
            pictureBox2 = new PictureBox();
            lblLogin = new Label();
            lblDescEstadisticas = new Label();
            iconoEstadisticas = new PictureBox();
            lblEstadisticas = new Label();
            lblDescPasajero = new Label();
            iconoPasajero = new PictureBox();
            lblPasajeros = new Label();
            lblFondoEstadistica = new Label();
            lblfondoPasajero = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoEstadisticas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoPasajero).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-3, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 50);
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(359, 12);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(88, 33);
            lblLogin.TabIndex = 34;
            lblLogin.Text = "MENÚ";
            lblLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDescEstadisticas
            // 
            lblDescEstadisticas.AutoSize = true;
            lblDescEstadisticas.Cursor = Cursors.Hand;
            lblDescEstadisticas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescEstadisticas.ForeColor = SystemColors.ControlDarkDark;
            lblDescEstadisticas.Location = new Point(106, 188);
            lblDescEstadisticas.Margin = new Padding(2, 0, 2, 0);
            lblDescEstadisticas.Name = "lblDescEstadisticas";
            lblDescEstadisticas.Size = new Size(319, 19);
            lblDescEstadisticas.TabIndex = 43;
            lblDescEstadisticas.Text = "Se podrán visualizar distintas estadisticas historicas";
            lblDescEstadisticas.MouseEnter += lblEstadistica_MouseEnter;
            lblDescEstadisticas.MouseLeave += lblEstadistica_MouseLeave;
            // 
            // iconoEstadisticas
            // 
            iconoEstadisticas.BackgroundImage = (Image)resources.GetObject("iconoEstadisticas.BackgroundImage");
            iconoEstadisticas.BackgroundImageLayout = ImageLayout.Zoom;
            iconoEstadisticas.Cursor = Cursors.Hand;
            iconoEstadisticas.Location = new Point(43, 166);
            iconoEstadisticas.Margin = new Padding(2);
            iconoEstadisticas.Name = "iconoEstadisticas";
            iconoEstadisticas.Size = new Size(49, 43);
            iconoEstadisticas.TabIndex = 42;
            iconoEstadisticas.TabStop = false;
            iconoEstadisticas.MouseEnter += lblEstadistica_MouseEnter;
            iconoEstadisticas.MouseLeave += lblEstadistica_MouseLeave;
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Cursor = Cursors.Hand;
            lblEstadisticas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadisticas.Location = new Point(106, 166);
            lblEstadisticas.Margin = new Padding(2, 0, 2, 0);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(175, 21);
            lblEstadisticas.TabIndex = 41;
            lblEstadisticas.Text = "Estadisticas historicas";
            lblEstadisticas.MouseEnter += lblEstadistica_MouseEnter;
            lblEstadisticas.MouseLeave += lblEstadistica_MouseLeave;
            // 
            // lblDescPasajero
            // 
            lblDescPasajero.AutoSize = true;
            lblDescPasajero.Cursor = Cursors.Hand;
            lblDescPasajero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescPasajero.ForeColor = SystemColors.ControlDarkDark;
            lblDescPasajero.Location = new Point(106, 106);
            lblDescPasajero.Margin = new Padding(2, 0, 2, 0);
            lblDescPasajero.Name = "lblDescPasajero";
            lblDescPasajero.Size = new Size(545, 19);
            lblDescPasajero.TabIndex = 40;
            lblDescPasajero.Text = "Se podrá ver la lista de pasajeros, ademas de agregar, modificar o eliminar a un pasajero";
            lblDescPasajero.MouseEnter += lblfondoPasajero_MouseEnter;
            lblDescPasajero.MouseLeave += lblfondoPasajero_MouseLeave;
            // 
            // iconoPasajero
            // 
            iconoPasajero.BackColor = SystemColors.Window;
            iconoPasajero.BackgroundImage = Properties.Resources.pasajero;
            iconoPasajero.BackgroundImageLayout = ImageLayout.Zoom;
            iconoPasajero.Cursor = Cursors.Hand;
            iconoPasajero.Location = new Point(43, 84);
            iconoPasajero.Margin = new Padding(2);
            iconoPasajero.Name = "iconoPasajero";
            iconoPasajero.Size = new Size(49, 43);
            iconoPasajero.TabIndex = 39;
            iconoPasajero.TabStop = false;
            iconoPasajero.MouseEnter += lblfondoPasajero_MouseEnter;
            iconoPasajero.MouseLeave += lblfondoPasajero_MouseLeave;
            // 
            // lblPasajeros
            // 
            lblPasajeros.AutoSize = true;
            lblPasajeros.Cursor = Cursors.Hand;
            lblPasajeros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasajeros.Location = new Point(106, 84);
            lblPasajeros.Margin = new Padding(2, 0, 2, 0);
            lblPasajeros.Name = "lblPasajeros";
            lblPasajeros.Size = new Size(82, 21);
            lblPasajeros.TabIndex = 38;
            lblPasajeros.Text = "Pasajeros";
            lblPasajeros.MouseEnter += lblfondoPasajero_MouseEnter;
            lblPasajeros.MouseLeave += lblfondoPasajero_MouseLeave;
            // 
            // lblFondoEstadistica
            // 
            lblFondoEstadistica.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFondoEstadistica.BackColor = SystemColors.Window;
            lblFondoEstadistica.BorderStyle = BorderStyle.FixedSingle;
            lblFondoEstadistica.Cursor = Cursors.Hand;
            lblFondoEstadistica.Location = new Point(30, 155);
            lblFondoEstadistica.Margin = new Padding(2, 0, 2, 0);
            lblFondoEstadistica.Name = "lblFondoEstadistica";
            lblFondoEstadistica.Size = new Size(754, 69);
            lblFondoEstadistica.TabIndex = 37;
            lblFondoEstadistica.Click += lblFondoEstadistica_Click;
            lblFondoEstadistica.MouseEnter += lblEstadistica_MouseEnter;
            lblFondoEstadistica.MouseLeave += lblEstadistica_MouseLeave;
            // 
            // lblfondoPasajero
            // 
            lblfondoPasajero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblfondoPasajero.BackColor = SystemColors.Window;
            lblfondoPasajero.BorderStyle = BorderStyle.FixedSingle;
            lblfondoPasajero.Cursor = Cursors.Hand;
            lblfondoPasajero.Location = new Point(30, 72);
            lblfondoPasajero.Margin = new Padding(2, 0, 2, 0);
            lblfondoPasajero.Name = "lblfondoPasajero";
            lblfondoPasajero.Size = new Size(754, 69);
            lblfondoPasajero.TabIndex = 36;
            lblfondoPasajero.Click += lblfondoPasajero_Click;
            lblfondoPasajero.MouseEnter += lblfondoPasajero_MouseEnter;
            lblfondoPasajero.MouseLeave += lblfondoPasajero_MouseLeave;
            // 
            // FrmSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(814, 458);
            Controls.Add(lblDescEstadisticas);
            Controls.Add(iconoEstadisticas);
            Controls.Add(lblEstadisticas);
            Controls.Add(lblDescPasajero);
            Controls.Add(iconoPasajero);
            Controls.Add(lblPasajeros);
            Controls.Add(lblFondoEstadistica);
            Controls.Add(lblfondoPasajero);
            Controls.Add(pictureBox2);
            Controls.Add(lblLogin);
            MaximumSize = new Size(830, 497);
            Name = "FrmSupervisor";
            Text = "Supervisor";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoEstadisticas).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoPasajero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label lblLogin;
        private Label lblDescEstadisticas;
        private PictureBox iconoEstadisticas;
        private Label lblEstadisticas;
        private Label lblDescPasajero;
        private PictureBox iconoPasajero;
        private Label lblPasajeros;
        private Label lblFondoEstadistica;
        private Label lblfondoPasajero;
    }
}