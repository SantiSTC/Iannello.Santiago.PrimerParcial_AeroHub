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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            label1 = new Label();
            lblUsuarioMenu = new Label();
            lblFecha = new Label();
            lblHora = new Label();
            lblPerfilMenu = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(-1, 419);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(816, 47);
            label1.TabIndex = 6;
            // 
            // lblUsuarioMenu
            // 
            lblUsuarioMenu.AutoSize = true;
            lblUsuarioMenu.BackColor = SystemColors.HotTrack;
            lblUsuarioMenu.ForeColor = SystemColors.Window;
            lblUsuarioMenu.Location = new Point(50, 422);
            lblUsuarioMenu.Name = "lblUsuarioMenu";
            lblUsuarioMenu.Size = new Size(47, 15);
            lblUsuarioMenu.TabIndex = 10;
            lblUsuarioMenu.Text = "Usuario";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = SystemColors.HotTrack;
            lblFecha.ForeColor = SystemColors.Window;
            lblFecha.Location = new Point(729, 437);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = SystemColors.HotTrack;
            lblHora.ForeColor = SystemColors.Window;
            lblHora.Location = new Point(750, 422);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(33, 15);
            lblHora.TabIndex = 8;
            lblHora.Text = "Hora";
            // 
            // lblPerfilMenu
            // 
            lblPerfilMenu.AutoSize = true;
            lblPerfilMenu.BackColor = SystemColors.HotTrack;
            lblPerfilMenu.ForeColor = SystemColors.Window;
            lblPerfilMenu.Location = new Point(50, 437);
            lblPerfilMenu.Name = "lblPerfilMenu";
            lblPerfilMenu.Size = new Size(34, 15);
            lblPerfilMenu.TabIndex = 7;
            lblPerfilMenu.Text = "Perfil";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HotTrack;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(8, 424);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 28);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 458);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuarioMenu);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(lblPerfilMenu);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += FrmMenu_FormClosing;
            Load += FrmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsuarioMenu;
        private Label lblFecha;
        private Label lblHora;
        private Label lblPerfilMenu;
        private PictureBox pictureBox1;
    }
}