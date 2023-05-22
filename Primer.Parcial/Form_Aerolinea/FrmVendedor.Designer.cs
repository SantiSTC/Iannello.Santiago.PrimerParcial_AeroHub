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
            lnkPasajeros.Location = new Point(140, 114);
            lnkPasajeros.Name = "lnkPasajeros";
            lnkPasajeros.Size = new Size(56, 15);
            lnkPasajeros.TabIndex = 0;
            lnkPasajeros.TabStop = true;
            lnkPasajeros.Text = "Pasajeros";
            lnkPasajeros.Click += lnkPasajeros_Click;
            // 
            // lnkListaViajes
            // 
            lnkListaViajes.AutoSize = true;
            lnkListaViajes.Location = new Point(448, 114);
            lnkListaViajes.Name = "lnkListaViajes";
            lnkListaViajes.Size = new Size(100, 15);
            lnkListaViajes.TabIndex = 1;
            lnkListaViajes.TabStop = true;
            lnkListaViajes.Text = "Viajes disponibles";
            lnkListaViajes.LinkClicked += lnkListaViajes_LinkClicked;
            // 
            // lnkEstadisticas
            // 
            lnkEstadisticas.AutoSize = true;
            lnkEstadisticas.Location = new Point(140, 249);
            lnkEstadisticas.Name = "lnkEstadisticas";
            lnkEstadisticas.Size = new Size(122, 15);
            lnkEstadisticas.TabIndex = 2;
            lnkEstadisticas.TabStop = true;
            lnkEstadisticas.Text = "Estadisticas Historicas";
            // 
            // lnkVenta
            // 
            lnkVenta.AutoSize = true;
            lnkVenta.Location = new Point(469, 249);
            lnkVenta.Name = "lnkVenta";
            lnkVenta.Size = new Size(79, 15);
            lnkVenta.TabIndex = 3;
            lnkVenta.TabStop = true;
            lnkVenta.Text = "Venta de viaje";
            // 
            // FrmVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 450);
            Controls.Add(lnkVenta);
            Controls.Add(lnkEstadisticas);
            Controls.Add(lnkListaViajes);
            Controls.Add(lnkPasajeros);
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