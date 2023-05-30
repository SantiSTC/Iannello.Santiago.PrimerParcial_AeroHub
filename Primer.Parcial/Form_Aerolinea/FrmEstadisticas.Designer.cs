namespace Form_Aerolinea
{
    partial class FrmEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            panel1 = new Panel();
            lblDescFrecuentes = new Label();
            lblDescHoras = new Label();
            lblDescGananciaPS = new Label();
            lblDescFacturacion = new Label();
            lblDescDestino = new Label();
            lblDescPasajeros = new Label();
            lblDescRecaudacion = new Label();
            lblFrecuentes = new Label();
            lblHoras = new Label();
            lblGananciaPS = new Label();
            lblFacturacion = new Label();
            lblDestino = new Label();
            lblPasajeros = new Label();
            iconoFrecuentes = new PictureBox();
            iconoHoras = new PictureBox();
            iconoGananciaPS = new PictureBox();
            iconoFacturacion = new PictureBox();
            iconoRecaudacion = new PictureBox();
            iconoPasajeros = new PictureBox();
            iconoDestino = new PictureBox();
            lblRecaudacion = new Label();
            lblFondoFrecuentes = new Label();
            lblFondoHoras = new Label();
            lblFondoGananciaPS = new Label();
            lblFondoFacturacion = new Label();
            lblFondoDestino = new Label();
            lblFondoPasajeros = new Label();
            lblfondoRecaudacion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconoFrecuentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoHoras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoGananciaPS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoFacturacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoRecaudacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoPasajeros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoDestino).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-1, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 83);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(474, 38);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(217, 50);
            lblLogin.TabIndex = 24;
            lblLogin.Text = "Estadísticas";
            lblLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(lblDescFrecuentes);
            panel1.Controls.Add(lblDescHoras);
            panel1.Controls.Add(lblDescGananciaPS);
            panel1.Controls.Add(lblDescFacturacion);
            panel1.Controls.Add(lblDescDestino);
            panel1.Controls.Add(lblDescPasajeros);
            panel1.Controls.Add(lblDescRecaudacion);
            panel1.Controls.Add(lblFrecuentes);
            panel1.Controls.Add(lblHoras);
            panel1.Controls.Add(lblGananciaPS);
            panel1.Controls.Add(lblFacturacion);
            panel1.Controls.Add(lblDestino);
            panel1.Controls.Add(lblPasajeros);
            panel1.Controls.Add(iconoFrecuentes);
            panel1.Controls.Add(iconoHoras);
            panel1.Controls.Add(iconoGananciaPS);
            panel1.Controls.Add(iconoFacturacion);
            panel1.Controls.Add(iconoRecaudacion);
            panel1.Controls.Add(iconoPasajeros);
            panel1.Controls.Add(iconoDestino);
            panel1.Controls.Add(lblRecaudacion);
            panel1.Controls.Add(lblFondoFrecuentes);
            panel1.Controls.Add(lblFondoHoras);
            panel1.Controls.Add(lblFondoGananciaPS);
            panel1.Controls.Add(lblFondoFacturacion);
            panel1.Controls.Add(lblFondoDestino);
            panel1.Controls.Add(lblFondoPasajeros);
            panel1.Controls.Add(lblfondoRecaudacion);
            panel1.Location = new Point(-1, 113);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1137, 717);
            panel1.TabIndex = 26;
            // 
            // lblDescFrecuentes
            // 
            lblDescFrecuentes.AutoSize = true;
            lblDescFrecuentes.Cursor = Cursors.Hand;
            lblDescFrecuentes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescFrecuentes.ForeColor = SystemColors.ControlDarkDark;
            lblDescFrecuentes.Location = new Point(113, 907);
            lblDescFrecuentes.Name = "lblDescFrecuentes";
            lblDescFrecuentes.Size = new Size(565, 28);
            lblDescFrecuentes.TabIndex = 43;
            lblDescFrecuentes.Text = "Lista de pasajeros ordenada segun cantidad de viajes realizados";
            lblDescFrecuentes.Click += lblFondoFrecuentes_Click;
            lblDescFrecuentes.MouseEnter += lblFondoFrecuentes_MouseEnter;
            lblDescFrecuentes.MouseLeave += lblFondoFrecuentes_MouseLeave;
            // 
            // lblDescHoras
            // 
            lblDescHoras.AutoSize = true;
            lblDescHoras.Cursor = Cursors.Hand;
            lblDescHoras.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescHoras.ForeColor = SystemColors.ControlDarkDark;
            lblDescHoras.Location = new Point(113, 772);
            lblDescHoras.Name = "lblDescHoras";
            lblDescHoras.Size = new Size(477, 28);
            lblDescHoras.TabIndex = 42;
            lblDescHoras.Text = "Cantidad de horas de vuelo realizadas por cada avion";
            lblDescHoras.Click += lblFondoHoras_Click;
            lblDescHoras.MouseEnter += lblFondoHoras_MouseEnter;
            lblDescHoras.MouseLeave += lblFondoHoras_MouseLeave;
            // 
            // lblDescGananciaPS
            // 
            lblDescGananciaPS.AutoSize = true;
            lblDescGananciaPS.Cursor = Cursors.Hand;
            lblDescGananciaPS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescGananciaPS.ForeColor = SystemColors.ControlDarkDark;
            lblDescGananciaPS.Location = new Point(113, 633);
            lblDescGananciaPS.Name = "lblDescGananciaPS";
            lblDescGananciaPS.Size = new Size(557, 28);
            lblDescGananciaPS.TabIndex = 41;
            lblDescGananciaPS.Text = "Cantidad recaudada segun servicio de cabotaje o internacional";
            lblDescGananciaPS.Click += lblFondoGananciaPS_Click;
            lblDescGananciaPS.MouseEnter += lblFondoGananciaPS_MouseEnter;
            lblDescGananciaPS.MouseLeave += lblFondoGananciaPS_MouseLeave;
            // 
            // lblDescFacturacion
            // 
            lblDescFacturacion.AutoSize = true;
            lblDescFacturacion.Cursor = Cursors.Hand;
            lblDescFacturacion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescFacturacion.ForeColor = SystemColors.ControlDarkDark;
            lblDescFacturacion.Location = new Point(113, 498);
            lblDescFacturacion.Name = "lblDescFacturacion";
            lblDescFacturacion.Size = new Size(339, 28);
            lblDescFacturacion.TabIndex = 40;
            lblDescFacturacion.Text = "Cantidad recaudada por cada destino";
            lblDescFacturacion.Click += lblFondoFacturacion_Click;
            lblDescFacturacion.MouseEnter += lblFondoFacturacion_MouseEnter;
            lblDescFacturacion.MouseLeave += lblFondoFacturacion_MouseLeave;
            // 
            // lblDescDestino
            // 
            lblDescDestino.AutoSize = true;
            lblDescDestino.Cursor = Cursors.Hand;
            lblDescDestino.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescDestino.ForeColor = SystemColors.ControlDarkDark;
            lblDescDestino.Location = new Point(113, 360);
            lblDescDestino.Name = "lblDescDestino";
            lblDescDestino.Size = new Size(344, 28);
            lblDescDestino.TabIndex = 39;
            lblDescDestino.Text = "El destino mas elegido por los clientes";
            lblDescDestino.Click += lblFondoDestino_Click;
            lblDescDestino.MouseEnter += lblFondoDestino_MouseEnter;
            lblDescDestino.MouseLeave += lblFondoDestino_MouseLeave;
            // 
            // lblDescPasajeros
            // 
            lblDescPasajeros.AutoSize = true;
            lblDescPasajeros.Cursor = Cursors.Hand;
            lblDescPasajeros.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescPasajeros.ForeColor = SystemColors.ControlDarkDark;
            lblDescPasajeros.Location = new Point(113, 222);
            lblDescPasajeros.Name = "lblDescPasajeros";
            lblDescPasajeros.Size = new Size(294, 28);
            lblDescPasajeros.TabIndex = 38;
            lblDescPasajeros.Text = "Cantidad de pasajeros por vuelo";
            lblDescPasajeros.Click += lblFondoPasajeros_Click;
            lblDescPasajeros.MouseEnter += lblFondoPasajeros_MouseEnter;
            lblDescPasajeros.MouseLeave += lblFondoPasajeros_MouseLeave;
            // 
            // lblDescRecaudacion
            // 
            lblDescRecaudacion.AutoSize = true;
            lblDescRecaudacion.Cursor = Cursors.Hand;
            lblDescRecaudacion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescRecaudacion.ForeColor = SystemColors.ControlDarkDark;
            lblDescRecaudacion.Location = new Point(113, 87);
            lblDescRecaudacion.Name = "lblDescRecaudacion";
            lblDescRecaudacion.Size = new Size(317, 28);
            lblDescRecaudacion.TabIndex = 37;
            lblDescRecaudacion.Text = "Total recaudado en todos los viajes";
            lblDescRecaudacion.Click += lblfondoRecaudacion_Click;
            lblDescRecaudacion.MouseEnter += lblfondoRecaudacion_MouseEnter;
            lblDescRecaudacion.MouseLeave += lblfondoRecaudacion_MouseLeave;
            // 
            // lblFrecuentes
            // 
            lblFrecuentes.AutoSize = true;
            lblFrecuentes.Cursor = Cursors.Hand;
            lblFrecuentes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFrecuentes.Location = new Point(113, 867);
            lblFrecuentes.Name = "lblFrecuentes";
            lblFrecuentes.Size = new Size(248, 32);
            lblFrecuentes.TabIndex = 36;
            lblFrecuentes.Text = "Pasajeros frecuentes";
            lblFrecuentes.Click += lblFondoFrecuentes_Click;
            lblFrecuentes.MouseEnter += lblFondoFrecuentes_MouseEnter;
            lblFrecuentes.MouseLeave += lblFondoFrecuentes_MouseLeave;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Cursor = Cursors.Hand;
            lblHoras.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoras.Location = new Point(113, 732);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(345, 32);
            lblHoras.TabIndex = 35;
            lblHoras.Text = "Horas de vuelo por aeronave";
            lblHoras.Click += lblFondoHoras_Click;
            lblHoras.MouseEnter += lblFondoHoras_MouseEnter;
            lblHoras.MouseLeave += lblFondoHoras_MouseLeave;
            // 
            // lblGananciaPS
            // 
            lblGananciaPS.AutoSize = true;
            lblGananciaPS.Cursor = Cursors.Hand;
            lblGananciaPS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGananciaPS.Location = new Point(113, 593);
            lblGananciaPS.Name = "lblGananciaPS";
            lblGananciaPS.Size = new Size(386, 32);
            lblGananciaPS.TabIndex = 34;
            lblGananciaPS.Text = "Ganancias totales segun servicio";
            lblGananciaPS.Click += lblFondoGananciaPS_Click;
            lblGananciaPS.MouseEnter += lblFondoGananciaPS_MouseEnter;
            lblGananciaPS.MouseLeave += lblFondoGananciaPS_MouseLeave;
            // 
            // lblFacturacion
            // 
            lblFacturacion.AutoSize = true;
            lblFacturacion.Cursor = Cursors.Hand;
            lblFacturacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFacturacion.Location = new Point(113, 458);
            lblFacturacion.Name = "lblFacturacion";
            lblFacturacion.Size = new Size(284, 32);
            lblFacturacion.TabIndex = 33;
            lblFacturacion.Text = "Facturacion de destinos";
            lblFacturacion.Click += lblFondoFacturacion_Click;
            lblFacturacion.MouseEnter += lblFondoFacturacion_MouseEnter;
            lblFacturacion.MouseLeave += lblFondoFacturacion_MouseLeave;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Cursor = Cursors.Hand;
            lblDestino.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestino.Location = new Point(113, 320);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(247, 32);
            lblDestino.TabIndex = 32;
            lblDestino.Text = "Destino mas elegido";
            lblDestino.Click += lblFondoDestino_Click;
            lblDestino.MouseEnter += lblFondoDestino_MouseEnter;
            lblDestino.MouseLeave += lblFondoDestino_MouseLeave;
            // 
            // lblPasajeros
            // 
            lblPasajeros.AutoSize = true;
            lblPasajeros.Cursor = Cursors.Hand;
            lblPasajeros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasajeros.Location = new Point(113, 182);
            lblPasajeros.Name = "lblPasajeros";
            lblPasajeros.Size = new Size(238, 32);
            lblPasajeros.TabIndex = 31;
            lblPasajeros.Text = "Pasajeros por vuelo";
            lblPasajeros.Click += lblFondoPasajeros_Click;
            lblPasajeros.MouseEnter += lblFondoPasajeros_MouseEnter;
            lblPasajeros.MouseLeave += lblFondoPasajeros_MouseLeave;
            // 
            // iconoFrecuentes
            // 
            iconoFrecuentes.BackColor = SystemColors.Window;
            iconoFrecuentes.BackgroundImage = (Image)resources.GetObject("iconoFrecuentes.BackgroundImage");
            iconoFrecuentes.BackgroundImageLayout = ImageLayout.Zoom;
            iconoFrecuentes.Cursor = Cursors.Hand;
            iconoFrecuentes.Location = new Point(30, 867);
            iconoFrecuentes.Name = "iconoFrecuentes";
            iconoFrecuentes.Size = new Size(77, 72);
            iconoFrecuentes.TabIndex = 30;
            iconoFrecuentes.TabStop = false;
            iconoFrecuentes.Click += lblFondoFrecuentes_Click;
            iconoFrecuentes.MouseEnter += lblFondoFrecuentes_MouseEnter;
            iconoFrecuentes.MouseLeave += lblFondoFrecuentes_MouseLeave;
            // 
            // iconoHoras
            // 
            iconoHoras.BackColor = SystemColors.Window;
            iconoHoras.BackgroundImage = (Image)resources.GetObject("iconoHoras.BackgroundImage");
            iconoHoras.BackgroundImageLayout = ImageLayout.Zoom;
            iconoHoras.Cursor = Cursors.Hand;
            iconoHoras.Location = new Point(30, 732);
            iconoHoras.Name = "iconoHoras";
            iconoHoras.Size = new Size(77, 72);
            iconoHoras.TabIndex = 29;
            iconoHoras.TabStop = false;
            iconoHoras.Click += lblFondoHoras_Click;
            iconoHoras.MouseEnter += lblFondoHoras_MouseEnter;
            iconoHoras.MouseLeave += lblFondoHoras_MouseLeave;
            // 
            // iconoGananciaPS
            // 
            iconoGananciaPS.BackColor = SystemColors.Window;
            iconoGananciaPS.BackgroundImage = (Image)resources.GetObject("iconoGananciaPS.BackgroundImage");
            iconoGananciaPS.BackgroundImageLayout = ImageLayout.Zoom;
            iconoGananciaPS.Cursor = Cursors.Hand;
            iconoGananciaPS.Location = new Point(30, 593);
            iconoGananciaPS.Name = "iconoGananciaPS";
            iconoGananciaPS.Size = new Size(77, 72);
            iconoGananciaPS.TabIndex = 28;
            iconoGananciaPS.TabStop = false;
            iconoGananciaPS.Click += lblFondoGananciaPS_Click;
            iconoGananciaPS.MouseEnter += lblFondoGananciaPS_MouseEnter;
            iconoGananciaPS.MouseLeave += lblFondoGananciaPS_MouseLeave;
            // 
            // iconoFacturacion
            // 
            iconoFacturacion.BackColor = SystemColors.Window;
            iconoFacturacion.BackgroundImage = (Image)resources.GetObject("iconoFacturacion.BackgroundImage");
            iconoFacturacion.BackgroundImageLayout = ImageLayout.Zoom;
            iconoFacturacion.Cursor = Cursors.Hand;
            iconoFacturacion.Location = new Point(30, 458);
            iconoFacturacion.Name = "iconoFacturacion";
            iconoFacturacion.Size = new Size(77, 72);
            iconoFacturacion.TabIndex = 27;
            iconoFacturacion.TabStop = false;
            iconoFacturacion.Click += lblFondoFacturacion_Click;
            iconoFacturacion.MouseEnter += lblFondoFacturacion_MouseEnter;
            iconoFacturacion.MouseLeave += lblFondoFacturacion_MouseLeave;
            // 
            // iconoRecaudacion
            // 
            iconoRecaudacion.BackColor = SystemColors.Window;
            iconoRecaudacion.BackgroundImage = (Image)resources.GetObject("iconoRecaudacion.BackgroundImage");
            iconoRecaudacion.BackgroundImageLayout = ImageLayout.Zoom;
            iconoRecaudacion.Cursor = Cursors.Hand;
            iconoRecaudacion.Location = new Point(30, 47);
            iconoRecaudacion.Name = "iconoRecaudacion";
            iconoRecaudacion.Size = new Size(77, 72);
            iconoRecaudacion.TabIndex = 23;
            iconoRecaudacion.TabStop = false;
            iconoRecaudacion.Click += lblfondoRecaudacion_Click;
            iconoRecaudacion.MouseEnter += lblfondoRecaudacion_MouseEnter;
            iconoRecaudacion.MouseLeave += lblfondoRecaudacion_MouseLeave;
            // 
            // iconoPasajeros
            // 
            iconoPasajeros.BackColor = SystemColors.Window;
            iconoPasajeros.BackgroundImage = (Image)resources.GetObject("iconoPasajeros.BackgroundImage");
            iconoPasajeros.BackgroundImageLayout = ImageLayout.Zoom;
            iconoPasajeros.Cursor = Cursors.Hand;
            iconoPasajeros.Location = new Point(30, 182);
            iconoPasajeros.Name = "iconoPasajeros";
            iconoPasajeros.Size = new Size(77, 72);
            iconoPasajeros.TabIndex = 22;
            iconoPasajeros.TabStop = false;
            iconoPasajeros.Click += lblFondoPasajeros_Click;
            iconoPasajeros.MouseEnter += lblFondoPasajeros_MouseEnter;
            iconoPasajeros.MouseLeave += lblFondoPasajeros_MouseLeave;
            // 
            // iconoDestino
            // 
            iconoDestino.BackColor = SystemColors.Window;
            iconoDestino.BackgroundImage = (Image)resources.GetObject("iconoDestino.BackgroundImage");
            iconoDestino.BackgroundImageLayout = ImageLayout.Zoom;
            iconoDestino.Cursor = Cursors.Hand;
            iconoDestino.Location = new Point(30, 320);
            iconoDestino.Name = "iconoDestino";
            iconoDestino.Size = new Size(77, 72);
            iconoDestino.TabIndex = 21;
            iconoDestino.TabStop = false;
            iconoDestino.Click += lblFondoDestino_Click;
            iconoDestino.MouseEnter += lblFondoDestino_MouseEnter;
            iconoDestino.MouseLeave += lblFondoDestino_MouseLeave;
            // 
            // lblRecaudacion
            // 
            lblRecaudacion.AutoSize = true;
            lblRecaudacion.Cursor = Cursors.Hand;
            lblRecaudacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecaudacion.Location = new Point(113, 47);
            lblRecaudacion.Name = "lblRecaudacion";
            lblRecaudacion.Size = new Size(159, 32);
            lblRecaudacion.TabIndex = 19;
            lblRecaudacion.Text = "Recaudación";
            lblRecaudacion.Click += lblfondoRecaudacion_Click;
            lblRecaudacion.MouseEnter += lblfondoRecaudacion_MouseEnter;
            lblRecaudacion.MouseLeave += lblfondoRecaudacion_MouseLeave;
            // 
            // lblFondoFrecuentes
            // 
            lblFondoFrecuentes.BackColor = SystemColors.Window;
            lblFondoFrecuentes.BorderStyle = BorderStyle.FixedSingle;
            lblFondoFrecuentes.Cursor = Cursors.Hand;
            lblFondoFrecuentes.Location = new Point(13, 850);
            lblFondoFrecuentes.Name = "lblFondoFrecuentes";
            lblFondoFrecuentes.Size = new Size(1079, 114);
            lblFondoFrecuentes.TabIndex = 17;
            lblFondoFrecuentes.Click += lblFondoFrecuentes_Click;
            lblFondoFrecuentes.MouseEnter += lblFondoFrecuentes_MouseEnter;
            lblFondoFrecuentes.MouseLeave += lblFondoFrecuentes_MouseLeave;
            // 
            // lblFondoHoras
            // 
            lblFondoHoras.BackColor = SystemColors.Window;
            lblFondoHoras.BorderStyle = BorderStyle.FixedSingle;
            lblFondoHoras.Cursor = Cursors.Hand;
            lblFondoHoras.Location = new Point(13, 712);
            lblFondoHoras.Name = "lblFondoHoras";
            lblFondoHoras.Size = new Size(1079, 114);
            lblFondoHoras.TabIndex = 16;
            lblFondoHoras.Click += lblFondoHoras_Click;
            lblFondoHoras.MouseEnter += lblFondoHoras_MouseEnter;
            lblFondoHoras.MouseLeave += lblFondoHoras_MouseLeave;
            // 
            // lblFondoGananciaPS
            // 
            lblFondoGananciaPS.BackColor = SystemColors.Window;
            lblFondoGananciaPS.BorderStyle = BorderStyle.FixedSingle;
            lblFondoGananciaPS.Cursor = Cursors.Hand;
            lblFondoGananciaPS.Location = new Point(13, 572);
            lblFondoGananciaPS.Name = "lblFondoGananciaPS";
            lblFondoGananciaPS.Size = new Size(1079, 114);
            lblFondoGananciaPS.TabIndex = 15;
            lblFondoGananciaPS.Click += lblFondoGananciaPS_Click;
            lblFondoGananciaPS.MouseEnter += lblFondoGananciaPS_MouseEnter;
            lblFondoGananciaPS.MouseLeave += lblFondoGananciaPS_MouseLeave;
            // 
            // lblFondoFacturacion
            // 
            lblFondoFacturacion.BackColor = SystemColors.Window;
            lblFondoFacturacion.BorderStyle = BorderStyle.FixedSingle;
            lblFondoFacturacion.Cursor = Cursors.Hand;
            lblFondoFacturacion.Location = new Point(13, 437);
            lblFondoFacturacion.Name = "lblFondoFacturacion";
            lblFondoFacturacion.Size = new Size(1079, 114);
            lblFondoFacturacion.TabIndex = 14;
            lblFondoFacturacion.Click += lblFondoFacturacion_Click;
            lblFondoFacturacion.MouseEnter += lblFondoFacturacion_MouseEnter;
            lblFondoFacturacion.MouseLeave += lblFondoFacturacion_MouseLeave;
            // 
            // lblFondoDestino
            // 
            lblFondoDestino.BackColor = SystemColors.Window;
            lblFondoDestino.BorderStyle = BorderStyle.FixedSingle;
            lblFondoDestino.Cursor = Cursors.Hand;
            lblFondoDestino.Location = new Point(13, 298);
            lblFondoDestino.Name = "lblFondoDestino";
            lblFondoDestino.Size = new Size(1079, 114);
            lblFondoDestino.TabIndex = 13;
            lblFondoDestino.Click += lblFondoDestino_Click;
            lblFondoDestino.MouseEnter += lblFondoDestino_MouseEnter;
            lblFondoDestino.MouseLeave += lblFondoDestino_MouseLeave;
            // 
            // lblFondoPasajeros
            // 
            lblFondoPasajeros.BackColor = SystemColors.Window;
            lblFondoPasajeros.BorderStyle = BorderStyle.FixedSingle;
            lblFondoPasajeros.Cursor = Cursors.Hand;
            lblFondoPasajeros.Location = new Point(13, 163);
            lblFondoPasajeros.Name = "lblFondoPasajeros";
            lblFondoPasajeros.Size = new Size(1079, 114);
            lblFondoPasajeros.TabIndex = 12;
            lblFondoPasajeros.Click += lblFondoPasajeros_Click;
            lblFondoPasajeros.MouseEnter += lblFondoPasajeros_MouseEnter;
            lblFondoPasajeros.MouseLeave += lblFondoPasajeros_MouseLeave;
            // 
            // lblfondoRecaudacion
            // 
            lblfondoRecaudacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblfondoRecaudacion.BackColor = SystemColors.Window;
            lblfondoRecaudacion.BorderStyle = BorderStyle.FixedSingle;
            lblfondoRecaudacion.Cursor = Cursors.Hand;
            lblfondoRecaudacion.Location = new Point(13, 25);
            lblfondoRecaudacion.Name = "lblfondoRecaudacion";
            lblfondoRecaudacion.Size = new Size(1079, 114);
            lblfondoRecaudacion.TabIndex = 11;
            lblfondoRecaudacion.Click += lblfondoRecaudacion_Click;
            lblfondoRecaudacion.MouseEnter += lblfondoRecaudacion_MouseEnter;
            lblfondoRecaudacion.MouseLeave += lblfondoRecaudacion_MouseLeave;
            // 
            // FrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1139, 850);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmEstadisticas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadisticas";
            Load += FrmEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconoFrecuentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoHoras).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoGananciaPS).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoFacturacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoRecaudacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoPasajeros).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoDestino).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblLogin;
        private Panel panel1;
        private Label lblFondoFrecuentes;
        private Label lblFondoHoras;
        private Label lblFondoGananciaPS;
        private Label lblFondoFacturacion;
        private Label lblFondoDestino;
        private Label lblFondoPasajeros;
        private Label lblfondoRecaudacion;
        private Label lblRecaudacion;
        private PictureBox iconoDestino;
        private PictureBox iconoFrecuentes;
        private PictureBox iconoHoras;
        private PictureBox iconoGananciaPS;
        private PictureBox iconoFacturacion;
        private PictureBox iconoRecaudacion;
        private PictureBox iconoPasajeros;
        private Label lblFrecuentes;
        private Label lblHoras;
        private Label lblGananciaPS;
        private Label lblFacturacion;
        private Label lblDestino;
        private Label lblPasajeros;
        private Label lblDescRecaudacion;
        private Label lblDescFrecuentes;
        private Label lblDescHoras;
        private Label lblDescGananciaPS;
        private Label lblDescFacturacion;
        private Label lblDescDestino;
        private Label lblDescPasajeros;
    }
}