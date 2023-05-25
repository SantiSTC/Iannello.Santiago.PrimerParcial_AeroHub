namespace Form_Aerolinea
{
    partial class FrmMenu
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
            lblUsuarioMenu = new Label();
            lblPerfilMenu = new Label();
            lblHora = new Label();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // lblUsuarioMenu
            // 
            lblUsuarioMenu.AutoSize = true;
            lblUsuarioMenu.Location = new Point(17, 665);
            lblUsuarioMenu.Margin = new Padding(4, 0, 4, 0);
            lblUsuarioMenu.Name = "lblUsuarioMenu";
            lblUsuarioMenu.Size = new Size(72, 25);
            lblUsuarioMenu.TabIndex = 1;
            lblUsuarioMenu.Text = "Usuario";
            // 
            // lblPerfilMenu
            // 
            lblPerfilMenu.AutoSize = true;
            lblPerfilMenu.Location = new Point(17, 705);
            lblPerfilMenu.Margin = new Padding(4, 0, 4, 0);
            lblPerfilMenu.Name = "lblPerfilMenu";
            lblPerfilMenu.Size = new Size(50, 25);
            lblPerfilMenu.TabIndex = 2;
            lblPerfilMenu.Text = "Perfil";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(1069, 665);
            lblHora.Margin = new Padding(4, 0, 4, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(51, 25);
            lblHora.TabIndex = 3;
            lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1039, 705);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 763);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(lblPerfilMenu);
            Controls.Add(lblUsuarioMenu);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMenu";
            Text = "Form1";
            FormClosing += FrmMenu_FormClosing;
            Load += FrmMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsuarioMenu;
        private Label lblPerfilMenu;
        private Label lblHora;
        private Label lblFecha;
    }
}