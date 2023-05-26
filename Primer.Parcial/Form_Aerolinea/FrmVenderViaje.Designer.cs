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
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            chkInternet = new CheckBox();
            chkComida = new CheckBox();
            label3 = new Label();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            txtEdad = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            chkPremium = new CheckBox();
            label2 = new Label();
            lblDestino = new Label();
            lblPartida = new Label();
            cmbDestino = new ComboBox();
            cmbPartida = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            lblFecha = new Label();
            mthFecha = new MonthCalendar();
            chkDeMano = new CheckBox();
            chkBodega = new CheckBox();
            label9 = new Label();
            txtPeso = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(321, 615);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(107, 38);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(451, 615);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 38);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 397);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 2;
            label1.Text = "Desea:";
            // 
            // chkInternet
            // 
            chkInternet.AutoSize = true;
            chkInternet.Location = new Point(127, 397);
            chkInternet.Margin = new Padding(4, 5, 4, 5);
            chkInternet.Name = "chkInternet";
            chkInternet.Size = new Size(99, 29);
            chkInternet.TabIndex = 3;
            chkInternet.Text = "Internet";
            chkInternet.UseVisualStyleBackColor = true;
            // 
            // chkComida
            // 
            chkComida.AutoSize = true;
            chkComida.Location = new Point(256, 397);
            chkComida.Margin = new Padding(4, 5, 4, 5);
            chkComida.Name = "chkComida";
            chkComida.Size = new Size(100, 29);
            chkComida.TabIndex = 4;
            chkComida.Text = "Comida";
            chkComida.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 77);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 10;
            label3.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(75, 71);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(141, 31);
            txtDni.TabIndex = 11;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(329, 71);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(141, 31);
            txtApellido.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 75);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 12;
            label4.Text = "Apellido:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(820, 71);
            txtEdad.Margin = new Padding(4, 5, 4, 5);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(35, 31);
            txtEdad.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(756, 74);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 16;
            label5.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(576, 69);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 31);
            txtNombre.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 77);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 14;
            label6.Text = "Nombre:";
            // 
            // chkPremium
            // 
            chkPremium.AutoSize = true;
            chkPremium.Location = new Point(127, 445);
            chkPremium.Margin = new Padding(4, 5, 4, 5);
            chkPremium.Name = "chkPremium";
            chkPremium.Size = new Size(22, 21);
            chkPremium.TabIndex = 19;
            chkPremium.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 441);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 18;
            label2.Text = "Premium:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(30, 275);
            lblDestino.Margin = new Padding(4, 0, 4, 0);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(77, 25);
            lblDestino.TabIndex = 23;
            lblDestino.Text = "Destino:";
            // 
            // lblPartida
            // 
            lblPartida.AutoSize = true;
            lblPartida.Location = new Point(37, 213);
            lblPartida.Margin = new Padding(4, 0, 4, 0);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(70, 25);
            lblPartida.TabIndex = 22;
            lblPartida.Text = "Partida:";
            // 
            // cmbDestino
            // 
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(115, 272);
            cmbDestino.Margin = new Padding(4, 5, 4, 5);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(257, 33);
            cmbDestino.TabIndex = 21;
            // 
            // cmbPartida
            // 
            cmbPartida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartida.FormattingEnabled = true;
            cmbPartida.Location = new Point(116, 210);
            cmbPartida.Margin = new Padding(4, 5, 4, 5);
            cmbPartida.Name = "cmbPartida";
            cmbPartida.Size = new Size(257, 33);
            cmbPartida.TabIndex = 20;
            cmbPartida.SelectedIndexChanged += cmbPartida_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 9);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(160, 25);
            label7.TabIndex = 24;
            label7.Text = "Datos del pasajero";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(399, 145);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 25;
            label8.Text = "Datos del viaje";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(420, 213);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(61, 25);
            lblFecha.TabIndex = 27;
            lblFecha.Text = "Fecha:";
            // 
            // mthFecha
            // 
            mthFecha.Location = new Point(510, 213);
            mthFecha.Margin = new Padding(13, 15, 13, 15);
            mthFecha.Name = "mthFecha";
            mthFecha.TabIndex = 26;
            // 
            // chkDeMano
            // 
            chkDeMano.AutoSize = true;
            chkDeMano.Location = new Point(256, 350);
            chkDeMano.Margin = new Padding(4, 5, 4, 5);
            chkDeMano.Name = "chkDeMano";
            chkDeMano.Size = new Size(111, 29);
            chkDeMano.TabIndex = 30;
            chkDeMano.Text = "De Mano";
            chkDeMano.UseVisualStyleBackColor = true;
            chkDeMano.CheckedChanged += chkDeMano_CheckedChanged;
            // 
            // chkBodega
            // 
            chkBodega.AutoSize = true;
            chkBodega.Location = new Point(127, 350);
            chkBodega.Margin = new Padding(4, 5, 4, 5);
            chkBodega.Name = "chkBodega";
            chkBodega.Size = new Size(99, 29);
            chkBodega.TabIndex = 29;
            chkBodega.Text = "Bodega";
            chkBodega.UseVisualStyleBackColor = true;
            chkBodega.CheckedChanged += chkDeMano_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 350);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 28;
            label9.Text = "Equipaje:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(438, 347);
            txtPeso.Margin = new Padding(4, 5, 4, 5);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(35, 31);
            txtPeso.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(374, 350);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(53, 25);
            label10.TabIndex = 31;
            label10.Text = "Peso:";
            // 
            // FrmVenderViaje
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 681);
            Controls.Add(txtPeso);
            Controls.Add(label10);
            Controls.Add(chkDeMano);
            Controls.Add(chkBodega);
            Controls.Add(label9);
            Controls.Add(lblFecha);
            Controls.Add(mthFecha);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblDestino);
            Controls.Add(lblPartida);
            Controls.Add(cmbDestino);
            Controls.Add(cmbPartida);
            Controls.Add(chkPremium);
            Controls.Add(label2);
            Controls.Add(txtEdad);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(chkComida);
            Controls.Add(chkInternet);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmVenderViaje";
            Text = "FrmVenderViaje";
            Load += FrmVenderViaje_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private CheckBox chkInternet;
        private CheckBox chkComida;
        private Label label3;
        private TextBox txtDni;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtEdad;
        private Label label5;
        private TextBox txtNombre;
        private Label label6;
        private CheckBox chkPremium;
        private Label label2;
        private Label lblDestino;
        private Label lblPartida;
        protected ComboBox cmbDestino;
        protected ComboBox cmbPartida;
        private Label label7;
        private Label label8;
        private Label lblFecha;
        protected MonthCalendar mthFecha;
        private CheckBox chkDeMano;
        private CheckBox chkBodega;
        private Label label9;
        private TextBox txtPeso;
        private Label label10;
    }
}