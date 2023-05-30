namespace Form_Aerolinea
{
    partial class FrmResultadosEstadistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResultadosEstadistica));
            rchEstadistica = new RichTextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rchEstadistica
            // 
            rchEstadistica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rchEstadistica.BackColor = SystemColors.Window;
            rchEstadistica.BorderStyle = BorderStyle.FixedSingle;
            rchEstadistica.Location = new Point(12, 56);
            rchEstadistica.Name = "rchEstadistica";
            rchEstadistica.ReadOnly = true;
            rchEstadistica.Size = new Size(304, 353);
            rchEstadistica.TabIndex = 0;
            rchEstadistica.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(74, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 35);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 18);
            label1.TabIndex = 27;
            label1.Text = "Resultados";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = SystemColors.HotTrack;
            label2.Location = new Point(-8, 416);
            label2.Name = "label2";
            label2.Size = new Size(342, 7);
            label2.TabIndex = 42;
            // 
            // FrmResultadosEstadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(328, 421);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(rchEstadistica);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(344, 460);
            Name = "FrmResultadosEstadistica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultados";
            Load += FrmResultadosEstadistica_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rchEstadistica;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}