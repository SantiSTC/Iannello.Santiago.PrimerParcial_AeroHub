namespace Form_Aerolinea
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Top;
            btnAceptar.BackColor = SystemColors.HotTrack;
            btnAceptar.ForeColor = SystemColors.ControlLightLight;
            btnAceptar.Location = new Point(167, 359);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(398, 38);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Ingresar a mi cuenta";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(167, 203);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Usuario";
            txtUsuario.Size = new Size(398, 31);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContrasenia.Location = new Point(167, 275);
            txtContrasenia.Margin = new Padding(4, 5, 4, 5);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PlaceholderText = " Contraseña";
            txtContrasenia.Size = new Size(398, 31);
            txtContrasenia.TabIndex = 4;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Calibri", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(238, 101);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(264, 54);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "Iniciar sesión";
            lblLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmLogin
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(741, 558);
            Controls.Add(lblLogin);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1622, 614);
            MinimumSize = new Size(755, 614);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private Label lblLogin;
    }
}