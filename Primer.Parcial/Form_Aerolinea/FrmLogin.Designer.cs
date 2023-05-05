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
            lblUsuario = new Label();
            lblContrasenia = new Label();
            txtContrasenia = new TextBox();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Top;
            btnAceptar.Location = new Point(215, 233);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(192, 122);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(154, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(133, 125);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(53, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario: ";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(113, 168);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(73, 15);
            lblContrasenia.TabIndex = 5;
            lblContrasenia.Text = "Contraseña: ";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContrasenia.Location = new Point(192, 165);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(154, 23);
            txtContrasenia.TabIndex = 4;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(233, 51);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "Login";
            // 
            // FrmLogin
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 352);
            Controls.Add(lblLogin);
            Controls.Add(lblContrasenia);
            Controls.Add(txtContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(btnAceptar);
            MaximumSize = new Size(1142, 391);
            MinimumSize = new Size(535, 391);
            Name = "FrmLogin";
            Text = "Form1";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Label lblContrasenia;
        private TextBox txtContrasenia;
        private Label lblLogin;
    }
}