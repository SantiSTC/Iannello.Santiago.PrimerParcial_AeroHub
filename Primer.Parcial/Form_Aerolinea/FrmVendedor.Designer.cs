namespace Form_Aerolinea
{
    partial class FrmVendedor
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
            lnkPasajeros = new LinkLabel();
            lnkListaViajes = new LinkLabel();
            lnkEstadisticas = new LinkLabel();
            lnkVenta = new LinkLabel();
            SuspendLayout();
            // 
            // lnkPasajeros
            // 
            lnkPasajeros.AutoSize = true;
            lnkPasajeros.Location = new Point(200, 190);
            lnkPasajeros.Margin = new Padding(4, 0, 4, 0);
            lnkPasajeros.Name = "lnkPasajeros";
            lnkPasajeros.Size = new Size(85, 25);
            lnkPasajeros.TabIndex = 0;
            lnkPasajeros.TabStop = true;
            lnkPasajeros.Text = "Pasajeros";
            lnkPasajeros.Click += lnkPasajeros_Click;
            // 
            // lnkListaViajes
            // 
            lnkListaViajes.AutoSize = true;
            lnkListaViajes.Location = new Point(640, 190);
            lnkListaViajes.Margin = new Padding(4, 0, 4, 0);
            lnkListaViajes.Name = "lnkListaViajes";
            lnkListaViajes.Size = new Size(153, 25);
            lnkListaViajes.TabIndex = 1;
            lnkListaViajes.TabStop = true;
            lnkListaViajes.Text = "Viajes disponibles";
            lnkListaViajes.LinkClicked += lnkListaViajes_LinkClicked;
            // 
            // lnkEstadisticas
            // 
            lnkEstadisticas.AutoSize = true;
            lnkEstadisticas.Location = new Point(200, 415);
            lnkEstadisticas.Margin = new Padding(4, 0, 4, 0);
            lnkEstadisticas.Name = "lnkEstadisticas";
            lnkEstadisticas.Size = new Size(184, 25);
            lnkEstadisticas.TabIndex = 2;
            lnkEstadisticas.TabStop = true;
            lnkEstadisticas.Text = "Estadisticas Historicas";
            // 
            // lnkVenta
            // 
            lnkVenta.AutoSize = true;
            lnkVenta.Location = new Point(670, 415);
            lnkVenta.Margin = new Padding(4, 0, 4, 0);
            lnkVenta.Name = "lnkVenta";
            lnkVenta.Size = new Size(121, 25);
            lnkVenta.TabIndex = 3;
            lnkVenta.TabStop = true;
            lnkVenta.Text = "Venta de viaje";
            lnkVenta.LinkClicked += lnkVenta_LinkClicked;
            // 
            // FrmVendedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 750);
            Controls.Add(lnkVenta);
            Controls.Add(lnkEstadisticas);
            Controls.Add(lnkListaViajes);
            Controls.Add(lnkPasajeros);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmVendedor";
            Text = "FrmVendedor";
            Load += FrmVendedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnkPasajeros;
        private LinkLabel lnkListaViajes;
        private LinkLabel lnkEstadisticas;
        private LinkLabel lnkVenta;
    }
}