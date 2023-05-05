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
            lblUsuarioMenu.Location = new Point(12, 399);
            lblUsuarioMenu.Name = "lblUsuarioMenu";
            lblUsuarioMenu.Size = new Size(47, 15);
            lblUsuarioMenu.TabIndex = 1;
            lblUsuarioMenu.Text = "Usuario";
            // 
            // lblPerfilMenu
            // 
            lblPerfilMenu.AutoSize = true;
            lblPerfilMenu.Location = new Point(12, 423);
            lblPerfilMenu.Name = "lblPerfilMenu";
            lblPerfilMenu.Size = new Size(34, 15);
            lblPerfilMenu.TabIndex = 2;
            lblPerfilMenu.Text = "Perfil";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(748, 399);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(33, 15);
            lblHora.TabIndex = 3;
            lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(727, 423);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 458);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(lblPerfilMenu);
            Controls.Add(lblUsuarioMenu);
            Name = "FrmMenu";
            Text = "Form1";
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