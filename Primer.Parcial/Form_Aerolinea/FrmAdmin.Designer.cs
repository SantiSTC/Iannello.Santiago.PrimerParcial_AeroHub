namespace Form_Aerolinea
{
    partial class FrmAdmin
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
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(193, 258);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Viajes";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(503, 258);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(62, 15);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Aeronaves";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 121);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 2;
            label1.Text = "Crear - Modificar - Eliminar";
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Name = "FrmAdmin";
            Text = "MenuAdmin";
            Load += MenuAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label1;
    }
}