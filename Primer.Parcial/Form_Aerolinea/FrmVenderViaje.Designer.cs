namespace Form_Aerolinea
{
    partial class FrmVenderViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenderViaje));
            btnAceptar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            label11 = new Label();
            lblfondoPasajero = new Label();
            label7 = new Label();
            txtEdad = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtDni = new TextBox();
            label3 = new Label();
            label12 = new Label();
            txtPeso = new TextBox();
            label10 = new Label();
            chkDeMano = new CheckBox();
            chkBodega = new CheckBox();
            label9 = new Label();
            lblFecha = new Label();
            mthFecha = new MonthCalendar();
            label8 = new Label();
            lblDestino = new Label();
            lblPartida = new Label();
            cmbDestino = new ComboBox();
            cmbPartida = new ComboBox();
            chkPremium = new CheckBox();
            label2 = new Label();
            chkComida = new CheckBox();
            chkInternet = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Location = new Point(223, 420);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(335, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 55);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(279, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(96, 33);
            lblLogin.TabIndex = 34;
            lblLogin.Text = "Vender";
            lblLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.BackColor = SystemColors.HotTrack;
            label11.Location = new Point(-13, 460);
            label11.Name = "label11";
            label11.Size = new Size(675, 7);
            label11.TabIndex = 42;
            // 
            // lblfondoPasajero
            // 
            lblfondoPasajero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblfondoPasajero.BackColor = SystemColors.Window;
            lblfondoPasajero.BorderStyle = BorderStyle.FixedSingle;
            lblfondoPasajero.Cursor = Cursors.Hand;
            lblfondoPasajero.Location = new Point(11, 67);
            lblfondoPasajero.Margin = new Padding(2, 0, 2, 0);
            lblfondoPasajero.Name = "lblfondoPasajero";
            lblfondoPasajero.Size = new Size(612, 80);
            lblfondoPasajero.TabIndex = 43;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(259, 73);
            label7.Name = "label7";
            label7.Size = new Size(135, 19);
            label7.TabIndex = 52;
            label7.Text = "Datos del pasajero";
            // 
            // txtEdad
            // 
            txtEdad.Anchor = AnchorStyles.Top;
            txtEdad.Location = new Point(577, 111);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(26, 23);
            txtEdad.TabIndex = 51;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(532, 114);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 50;
            label5.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.Location = new Point(406, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 49;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(343, 114);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 48;
            label6.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top;
            txtApellido.Location = new Point(233, 111);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 47;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(174, 114);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 46;
            label4.Text = "Apellido:";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Top;
            txtDni.Location = new Point(55, 111);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 45;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(17, 114);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 44;
            label3.Text = "DNI:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.BackColor = SystemColors.Window;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Cursor = Cursors.Hand;
            label12.Location = new Point(11, 165);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(612, 235);
            label12.TabIndex = 53;
            // 
            // txtPeso
            // 
            txtPeso.Anchor = AnchorStyles.Top;
            txtPeso.Location = new Point(315, 292);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(26, 23);
            txtPeso.TabIndex = 70;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(270, 294);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 69;
            label10.Text = "Peso:";
            // 
            // chkDeMano
            // 
            chkDeMano.Anchor = AnchorStyles.Top;
            chkDeMano.AutoSize = true;
            chkDeMano.Location = new Point(187, 294);
            chkDeMano.Name = "chkDeMano";
            chkDeMano.Size = new Size(74, 19);
            chkDeMano.TabIndex = 68;
            chkDeMano.Text = "De Mano";
            chkDeMano.UseVisualStyleBackColor = true;
            chkDeMano.CheckedChanged += chkDeMano_CheckedChanged;
            // 
            // chkBodega
            // 
            chkBodega.Anchor = AnchorStyles.Top;
            chkBodega.AutoSize = true;
            chkBodega.Location = new Point(97, 294);
            chkBodega.Name = "chkBodega";
            chkBodega.Size = new Size(66, 19);
            chkBodega.TabIndex = 67;
            chkBodega.Text = "Bodega";
            chkBodega.UseVisualStyleBackColor = true;
            chkBodega.CheckedChanged += chkDeMano_CheckedChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(24, 294);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 66;
            label9.Text = "Equipaje:";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top;
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(302, 212);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 65;
            lblFecha.Text = "Fecha:";
            // 
            // mthFecha
            // 
            mthFecha.Anchor = AnchorStyles.Top;
            mthFecha.Location = new Point(365, 212);
            mthFecha.Name = "mthFecha";
            mthFecha.TabIndex = 64;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(268, 169);
            label8.Name = "label8";
            label8.Size = new Size(109, 19);
            label8.TabIndex = 63;
            label8.Text = "Datos del viaje";
            // 
            // lblDestino
            // 
            lblDestino.Anchor = AnchorStyles.Top;
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(29, 249);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(50, 15);
            lblDestino.TabIndex = 62;
            lblDestino.Text = "Destino:";
            // 
            // lblPartida
            // 
            lblPartida.Anchor = AnchorStyles.Top;
            lblPartida.AutoSize = true;
            lblPartida.Location = new Point(34, 212);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(47, 15);
            lblPartida.TabIndex = 61;
            lblPartida.Text = "Partida:";
            // 
            // cmbDestino
            // 
            cmbDestino.Anchor = AnchorStyles.Top;
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.FlatStyle = FlatStyle.Popup;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(88, 247);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(181, 23);
            cmbDestino.TabIndex = 60;
            // 
            // cmbPartida
            // 
            cmbPartida.Anchor = AnchorStyles.Top;
            cmbPartida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartida.FlatStyle = FlatStyle.Popup;
            cmbPartida.FormattingEnabled = true;
            cmbPartida.Location = new Point(89, 210);
            cmbPartida.Name = "cmbPartida";
            cmbPartida.Size = new Size(181, 23);
            cmbPartida.TabIndex = 59;
            cmbPartida.SelectedIndexChanged += cmbPartida_SelectedIndexChanged;
            // 
            // chkPremium
            // 
            chkPremium.Anchor = AnchorStyles.Top;
            chkPremium.AutoSize = true;
            chkPremium.Location = new Point(97, 351);
            chkPremium.Name = "chkPremium";
            chkPremium.Size = new Size(15, 14);
            chkPremium.TabIndex = 58;
            chkPremium.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(21, 349);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 57;
            label2.Text = "Premium:";
            // 
            // chkComida
            // 
            chkComida.Anchor = AnchorStyles.Top;
            chkComida.AutoSize = true;
            chkComida.Location = new Point(187, 322);
            chkComida.Name = "chkComida";
            chkComida.Size = new Size(68, 19);
            chkComida.TabIndex = 56;
            chkComida.Text = "Comida";
            chkComida.UseVisualStyleBackColor = true;
            // 
            // chkInternet
            // 
            chkInternet.Anchor = AnchorStyles.Top;
            chkInternet.AutoSize = true;
            chkInternet.Location = new Point(97, 322);
            chkInternet.Name = "chkInternet";
            chkInternet.Size = new Size(67, 19);
            chkInternet.TabIndex = 55;
            chkInternet.Text = "Internet";
            chkInternet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(37, 322);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 54;
            label1.Text = "Desea:";
            // 
            // FrmVenderViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(634, 466);
            Controls.Add(txtPeso);
            Controls.Add(label10);
            Controls.Add(chkDeMano);
            Controls.Add(chkBodega);
            Controls.Add(label9);
            Controls.Add(lblFecha);
            Controls.Add(mthFecha);
            Controls.Add(label8);
            Controls.Add(lblDestino);
            Controls.Add(lblPartida);
            Controls.Add(cmbDestino);
            Controls.Add(cmbPartida);
            Controls.Add(chkPremium);
            Controls.Add(label2);
            Controls.Add(chkComida);
            Controls.Add(chkInternet);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(txtEdad);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(lblfondoPasajero);
            Controls.Add(label11);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVenderViaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta de viaje";
            Load += FrmVenderViaje_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private Label lblLogin;
        private Label label11;
        private Label lblfondoPasajero;
        private Label label7;
        private TextBox txtEdad;
        private Label label5;
        private TextBox txtNombre;
        private Label label6;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtDni;
        private Label label3;
        private Label label12;
        private TextBox txtPeso;
        private Label label10;
        private CheckBox chkDeMano;
        private CheckBox chkBodega;
        private Label label9;
        private Label lblFecha;
        protected MonthCalendar mthFecha;
        private Label label8;
        private Label lblDestino;
        private Label lblPartida;
        protected ComboBox cmbDestino;
        protected ComboBox cmbPartida;
        private CheckBox chkPremium;
        private Label label2;
        private CheckBox chkComida;
        private CheckBox chkInternet;
        private Label label1;
    }
}