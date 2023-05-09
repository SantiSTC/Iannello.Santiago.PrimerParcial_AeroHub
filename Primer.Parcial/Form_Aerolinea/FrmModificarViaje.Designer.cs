namespace Form_Aerolinea
{
    partial class FrmModificarViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarViaje));
            Entidades.Aeronave aeronave1 = new Entidades.Aeronave();
            Entidades.Aeronave aeronave2 = new Entidades.Aeronave();
            SuspendLayout();
            // 
            // cmbPartida
            // 
            cmbPartida.Items.AddRange(new object[] { "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", "Buenos Aires" });
            // 
            // cmbDestino
            // 
            cmbDestino.Items.AddRange(new object[] { EDestinoInternacional.Recife, EDestinoInternacional.Roma, EDestinoInternacional.Acapulco, EDestinoInternacional.Miami, "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia" });
            // 
            // cmbAvion
            // 
            aeronave1.CantidadAsientos = 222;
            aeronave1.CantidadBanios = 2;
            aeronave1.CapacidadBodega = 2222F;
            aeronave1.Comida = true;
            aeronave1.Internet = true;
            aeronave1.Matricula = "sas222ss";
            aeronave2.CantidadAsientos = 333;
            aeronave2.CantidadBanios = 3;
            aeronave2.CapacidadBodega = 3333F;
            aeronave2.Comida = true;
            aeronave2.Internet = true;
            aeronave2.Matricula = "sas333ss";
            cmbAvion.Items.AddRange(new object[] { aeronave1, aeronave2 });
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(139, 9);
            lblTitulo.Size = new Size(77, 15);
            lblTitulo.Text = "Agregar Viaje";
            // 
            // btnAgregar
            // 
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmModificarViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 513);
            Name = "FrmModificarViaje";
            Text = "FrmModificarViaje";
            Load += FrmModificarViaje_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}