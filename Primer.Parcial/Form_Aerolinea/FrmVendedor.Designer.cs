namespace Form_Aerolinea
{
    partial class FrmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedor));
            lblfondoPasajero = new Label();
            lblLogin = new Label();
            lblFondoViaje = new Label();
            lblFondoVenta = new Label();
            lblFondoEstadistica = new Label();
            lblPasajeros = new Label();
            iconoPasajero = new PictureBox();
            lblDescPasajero = new Label();
            lblDescViaje = new Label();
            iconoViaje = new PictureBox();
            lblViaje = new Label();
            lblDescVenta = new Label();
            iconoVenta = new PictureBox();
            lblVenta = new Label();
            lblDescEstadisticas = new Label();
            iconoEstadisticas = new PictureBox();
            lblEstadisticas = new Label();
            ((System.ComponentModel.ISupportInitialize)iconoPasajero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoViaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoEstadisticas).BeginInit();
            SuspendLayout();
            // 
            // lblfondoPasajero
            // 
            lblfondoPasajero.BackColor = SystemColors.Window;
            lblfondoPasajero.BorderStyle = BorderStyle.FixedSingle;
            lblfondoPasajero.Cursor = Cursors.Hand;
            lblfondoPasajero.Location = new Point(43, 98);
            lblfondoPasajero.Name = "lblfondoPasajero";
            lblfondoPasajero.Size = new Size(1076, 113);
            lblfondoPasajero.TabIndex = 4;
            lblfondoPasajero.Click += lblPasajeros_Click;
            lblfondoPasajero.MouseEnter += label1_MouseEnter;
            lblfondoPasajero.MouseLeave += lblfondoPasajero_MouseLeave;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Calibri", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(504, 9);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(140, 54);
            lblLogin.TabIndex = 7;
            lblLogin.Text = "MENU";
            lblLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFondoViaje
            // 
            lblFondoViaje.BackColor = SystemColors.Window;
            lblFondoViaje.BorderStyle = BorderStyle.FixedSingle;
            lblFondoViaje.Cursor = Cursors.Hand;
            lblFondoViaje.Location = new Point(43, 236);
            lblFondoViaje.Name = "lblFondoViaje";
            lblFondoViaje.Size = new Size(1076, 113);
            lblFondoViaje.TabIndex = 8;
            lblFondoViaje.Click += lblViaje_Click;
            lblFondoViaje.MouseEnter += lblFondoViaje_MouseEnter;
            lblFondoViaje.MouseLeave += lblFondoViaje_MouseLeave;
            // 
            // lblFondoVenta
            // 
            lblFondoVenta.BackColor = SystemColors.Window;
            lblFondoVenta.BorderStyle = BorderStyle.FixedSingle;
            lblFondoVenta.Cursor = Cursors.Hand;
            lblFondoVenta.Location = new Point(43, 372);
            lblFondoVenta.Name = "lblFondoVenta";
            lblFondoVenta.Size = new Size(1076, 113);
            lblFondoVenta.TabIndex = 9;
            lblFondoVenta.Click += lblVenta_Click;
            lblFondoVenta.MouseEnter += lblFondoVenta_MouseEnter;
            lblFondoVenta.MouseLeave += lblFondoVenta_MouseLeave;
            // 
            // lblFondoEstadistica
            // 
            lblFondoEstadistica.BackColor = SystemColors.Window;
            lblFondoEstadistica.BorderStyle = BorderStyle.FixedSingle;
            lblFondoEstadistica.Cursor = Cursors.Hand;
            lblFondoEstadistica.Location = new Point(43, 510);
            lblFondoEstadistica.Name = "lblFondoEstadistica";
            lblFondoEstadistica.Size = new Size(1076, 113);
            lblFondoEstadistica.TabIndex = 10;
            lblFondoEstadistica.MouseEnter += lblEstadistica_MouseEnter;
            lblFondoEstadistica.MouseLeave += lblEstadistica_MouseLeave;
            // 
            // lblPasajeros
            // 
            lblPasajeros.AutoSize = true;
            lblPasajeros.Cursor = Cursors.Hand;
            lblPasajeros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasajeros.Location = new Point(151, 118);
            lblPasajeros.Name = "lblPasajeros";
            lblPasajeros.Size = new Size(121, 32);
            lblPasajeros.TabIndex = 11;
            lblPasajeros.Text = "Pasajeros";
            lblPasajeros.Click += lblPasajeros_Click;
            lblPasajeros.MouseEnter += label1_MouseEnter;
            lblPasajeros.MouseLeave += lblfondoPasajero_MouseLeave;
            // 
            // iconoPasajero
            // 
            iconoPasajero.BackColor = SystemColors.Window;
            iconoPasajero.BackgroundImage = Properties.Resources.pasajero;
            iconoPasajero.BackgroundImageLayout = ImageLayout.Zoom;
            iconoPasajero.Cursor = Cursors.Hand;
            iconoPasajero.Location = new Point(62, 118);
            iconoPasajero.Name = "iconoPasajero";
            iconoPasajero.Size = new Size(70, 71);
            iconoPasajero.TabIndex = 12;
            iconoPasajero.TabStop = false;
            iconoPasajero.Click += lblPasajeros_Click;
            iconoPasajero.MouseEnter += label1_MouseEnter;
            iconoPasajero.MouseLeave += lblfondoPasajero_MouseLeave;
            // 
            // lblDescPasajero
            // 
            lblDescPasajero.AutoSize = true;
            lblDescPasajero.Cursor = Cursors.Hand;
            lblDescPasajero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescPasajero.ForeColor = SystemColors.ControlDarkDark;
            lblDescPasajero.Location = new Point(151, 155);
            lblDescPasajero.Name = "lblDescPasajero";
            lblDescPasajero.Size = new Size(778, 28);
            lblDescPasajero.TabIndex = 13;
            lblDescPasajero.Text = "Se podrá ver la lista de pasajeros, ademas de agregar, modificar o eliminar a un pasajero";
            lblDescPasajero.Click += lblPasajeros_Click;
            lblDescPasajero.MouseEnter += label1_MouseEnter;
            lblDescPasajero.MouseLeave += lblfondoPasajero_MouseLeave;
            // 
            // lblDescViaje
            // 
            lblDescViaje.AutoSize = true;
            lblDescViaje.Cursor = Cursors.Hand;
            lblDescViaje.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescViaje.ForeColor = SystemColors.ControlDarkDark;
            lblDescViaje.Location = new Point(151, 293);
            lblDescViaje.Name = "lblDescViaje";
            lblDescViaje.Size = new Size(695, 28);
            lblDescViaje.TabIndex = 16;
            lblDescViaje.Text = "Se podrá ver la lista de viajes, ademas de agregar, modificar o eliminar un viaje";
            lblDescViaje.Click += lblViaje_Click;
            lblDescViaje.MouseEnter += lblFondoViaje_MouseEnter;
            lblDescViaje.MouseLeave += lblFondoViaje_MouseLeave;
            // 
            // iconoViaje
            // 
            iconoViaje.BackgroundImage = (Image)resources.GetObject("iconoViaje.BackgroundImage");
            iconoViaje.BackgroundImageLayout = ImageLayout.Zoom;
            iconoViaje.Cursor = Cursors.Hand;
            iconoViaje.Location = new Point(62, 256);
            iconoViaje.Name = "iconoViaje";
            iconoViaje.Size = new Size(70, 71);
            iconoViaje.TabIndex = 15;
            iconoViaje.TabStop = false;
            iconoViaje.Click += lblViaje_Click;
            iconoViaje.MouseEnter += lblFondoViaje_MouseEnter;
            iconoViaje.MouseLeave += lblFondoViaje_MouseLeave;
            // 
            // lblViaje
            // 
            lblViaje.AutoSize = true;
            lblViaje.Cursor = Cursors.Hand;
            lblViaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblViaje.Location = new Point(151, 256);
            lblViaje.Name = "lblViaje";
            lblViaje.Size = new Size(81, 32);
            lblViaje.TabIndex = 14;
            lblViaje.Text = "Viajes";
            lblViaje.Click += lblViaje_Click;
            lblViaje.MouseEnter += lblFondoViaje_MouseEnter;
            lblViaje.MouseLeave += lblFondoViaje_MouseLeave;
            // 
            // lblDescVenta
            // 
            lblDescVenta.AutoSize = true;
            lblDescVenta.Cursor = Cursors.Hand;
            lblDescVenta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescVenta.ForeColor = SystemColors.ControlDarkDark;
            lblDescVenta.Location = new Point(151, 429);
            lblDescVenta.Name = "lblDescVenta";
            lblDescVenta.Size = new Size(332, 28);
            lblDescVenta.TabIndex = 19;
            lblDescVenta.Text = "Se podrá vender un viaje a un cliente";
            lblDescVenta.Click += lblVenta_Click;
            lblDescVenta.MouseEnter += lblFondoVenta_MouseEnter;
            lblDescVenta.MouseLeave += lblFondoVenta_MouseLeave;
            // 
            // iconoVenta
            // 
            iconoVenta.BackgroundImage = (Image)resources.GetObject("iconoVenta.BackgroundImage");
            iconoVenta.BackgroundImageLayout = ImageLayout.Zoom;
            iconoVenta.Cursor = Cursors.Hand;
            iconoVenta.Location = new Point(62, 392);
            iconoVenta.Name = "iconoVenta";
            iconoVenta.Size = new Size(70, 71);
            iconoVenta.TabIndex = 18;
            iconoVenta.TabStop = false;
            iconoVenta.Click += lblVenta_Click;
            iconoVenta.MouseEnter += lblFondoVenta_MouseEnter;
            iconoVenta.MouseLeave += lblFondoVenta_MouseLeave;
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Cursor = Cursors.Hand;
            lblVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVenta.Location = new Point(151, 392);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(78, 32);
            lblVenta.TabIndex = 17;
            lblVenta.Text = "Venta";
            lblVenta.Click += lblVenta_Click;
            lblVenta.MouseEnter += lblFondoVenta_MouseEnter;
            lblVenta.MouseLeave += lblFondoVenta_MouseLeave;
            // 
            // lblDescEstadisticas
            // 
            lblDescEstadisticas.AutoSize = true;
            lblDescEstadisticas.Cursor = Cursors.Hand;
            lblDescEstadisticas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescEstadisticas.ForeColor = SystemColors.ControlDarkDark;
            lblDescEstadisticas.Location = new Point(151, 565);
            lblDescEstadisticas.Name = "lblDescEstadisticas";
            lblDescEstadisticas.Size = new Size(456, 28);
            lblDescEstadisticas.TabIndex = 22;
            lblDescEstadisticas.Text = "Se podrán visualizar distintas estadisticas historicas";
            lblDescEstadisticas.MouseEnter += lblEstadistica_MouseEnter;
            lblDescEstadisticas.MouseLeave += lblEstadistica_MouseLeave;
            // 
            // iconoEstadisticas
            // 
            iconoEstadisticas.BackgroundImage = (Image)resources.GetObject("iconoEstadisticas.BackgroundImage");
            iconoEstadisticas.BackgroundImageLayout = ImageLayout.Zoom;
            iconoEstadisticas.Cursor = Cursors.Hand;
            iconoEstadisticas.Location = new Point(62, 528);
            iconoEstadisticas.Name = "iconoEstadisticas";
            iconoEstadisticas.Size = new Size(70, 71);
            iconoEstadisticas.TabIndex = 21;
            iconoEstadisticas.TabStop = false;
            iconoEstadisticas.MouseEnter += lblEstadistica_MouseEnter;
            iconoEstadisticas.MouseLeave += lblEstadistica_MouseLeave;
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Cursor = Cursors.Hand;
            lblEstadisticas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadisticas.Location = new Point(151, 528);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(261, 32);
            lblEstadisticas.TabIndex = 20;
            lblEstadisticas.Text = "Estadisticas historicas";
            lblEstadisticas.MouseEnter += lblEstadistica_MouseEnter;
            lblEstadisticas.MouseLeave += lblEstadistica_MouseLeave;
            // 
            // FrmVendedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1163, 763);
            Controls.Add(lblDescEstadisticas);
            Controls.Add(iconoEstadisticas);
            Controls.Add(lblEstadisticas);
            Controls.Add(lblDescVenta);
            Controls.Add(iconoVenta);
            Controls.Add(lblVenta);
            Controls.Add(lblDescViaje);
            Controls.Add(iconoViaje);
            Controls.Add(lblViaje);
            Controls.Add(lblDescPasajero);
            Controls.Add(iconoPasajero);
            Controls.Add(lblPasajeros);
            Controls.Add(lblFondoEstadistica);
            Controls.Add(lblFondoVenta);
            Controls.Add(lblFondoViaje);
            Controls.Add(lblLogin);
            Controls.Add(lblfondoPasajero);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmVendedor";
            Text = "Menu Vendedor";
            Load += FrmVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)iconoPasajero).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoViaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoEstadisticas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblfondoPasajero;
        private Label lblLogin;
        private Label lblFondoViaje;
        private Label lblFondoVenta;
        private Label lblFondoEstadistica;
        private Label lblPasajeros;
        private PictureBox iconoPasajero;
        private Label lblDescPasajero;
        private Label lblDescViaje;
        private PictureBox iconoViaje;
        private Label lblViaje;
        private Label lblDescVenta;
        private PictureBox iconoVenta;
        private Label lblVenta;
        private Label lblDescEstadisticas;
        private PictureBox iconoEstadisticas;
        private Label lblEstadisticas;
    }
}