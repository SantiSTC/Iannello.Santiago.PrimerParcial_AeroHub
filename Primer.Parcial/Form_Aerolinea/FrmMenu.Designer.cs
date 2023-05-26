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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(-1, 698);
            label1.Name = "label1";
            label1.Size = new Size(1166, 78);
            label1.TabIndex = 6;
            // 
            // lblUsuarioMenu
            // 
            lblUsuarioMenu.AutoSize = true;
            lblUsuarioMenu.BackColor = SystemColors.HotTrack;
            lblUsuarioMenu.ForeColor = SystemColors.Window;
            lblUsuarioMenu.Location = new Point(71, 704);
            lblUsuarioMenu.Margin = new Padding(4, 0, 4, 0);
            lblUsuarioMenu.Name = "lblUsuarioMenu";
            lblUsuarioMenu.Size = new Size(72, 25);
            lblUsuarioMenu.TabIndex = 10;
            lblUsuarioMenu.Text = "Usuario";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = SystemColors.HotTrack;
            lblFecha.ForeColor = SystemColors.Window;
            lblFecha.Location = new Point(1042, 729);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = SystemColors.HotTrack;
            lblHora.ForeColor = SystemColors.Window;
            lblHora.Location = new Point(1072, 704);
            lblHora.Margin = new Padding(4, 0, 4, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(51, 25);
            lblHora.TabIndex = 8;
            lblHora.Text = "Hora";
            // 
            // lblPerfilMenu
            // 
            lblPerfilMenu.AutoSize = true;
            lblPerfilMenu.BackColor = SystemColors.HotTrack;
            lblPerfilMenu.ForeColor = SystemColors.Window;
            lblPerfilMenu.Location = new Point(71, 729);
            lblPerfilMenu.Margin = new Padding(4, 0, 4, 0);
            lblPerfilMenu.Name = "lblPerfilMenu";
            lblPerfilMenu.Size = new Size(50, 25);
            lblPerfilMenu.TabIndex = 7;
            lblPerfilMenu.Text = "Perfil";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.HotTrack;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(-1, -2);
            label2.Name = "label2";
            label2.Size = new Size(1166, 12);
            label2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HotTrack;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 707);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 47);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 763);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(lblUsuarioMenu);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(lblPerfilMenu);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
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
        private Label label2;
        private PictureBox pictureBox1;
    }
}