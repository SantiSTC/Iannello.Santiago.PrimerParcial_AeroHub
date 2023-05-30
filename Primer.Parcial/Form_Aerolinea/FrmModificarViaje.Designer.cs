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
            Entidades.Aeronave aeronave1 = new Entidades.Aeronave();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarViaje));
            Entidades.Aeronave aeronave2 = new Entidades.Aeronave();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblPartida
            // 
            lblPartida.Location = new Point(32, 87);
            // 
            // lblDestino
            // 
            lblDestino.Location = new Point(32, 152);
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(32, 257);
            // 
            // lblAvion
            // 
            lblAvion.Location = new Point(32, 211);
            // 
            // mthFecha
            // 
            mthFecha.Location = new Point(109, 257);
            // 
            // cmbPartida
            // 
            cmbPartida.Items.AddRange(new object[] { "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", "Buenos Aires", "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", "Buenos Aires", "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", "Buenos Aires", "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", "Buenos Aires", "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", "Buenos Aires", "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", "Buenos Aires" });
            cmbPartida.Location = new Point(109, 79);
            // 
            // cmbDestino
            // 
            cmbDestino.Items.AddRange(new object[] { EDestinoInternacional.Recife, EDestinoInternacional.Roma, EDestinoInternacional.Acapulco, EDestinoInternacional.Miami, "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", EDestinoInternacional.Recife, EDestinoInternacional.Roma, EDestinoInternacional.Acapulco, EDestinoInternacional.Miami, "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", EDestinoInternacional.Recife, EDestinoInternacional.Roma, EDestinoInternacional.Acapulco, EDestinoInternacional.Miami, "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", EDestinoInternacional.Recife, EDestinoInternacional.Roma, EDestinoInternacional.Acapulco, EDestinoInternacional.Miami, "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", EDestinoInternacional.Recife, EDestinoInternacional.Roma, EDestinoInternacional.Acapulco, EDestinoInternacional.Miami, "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia", EDestinoInternacional.Recife, EDestinoInternacional.Roma, EDestinoInternacional.Acapulco, EDestinoInternacional.Miami, "Santa Rosa", "Bariloche", "Corrientes", "Cordoba", "Jujuy", "Mendoza", "Neuquen", "Posadas", "Iguazu", "Salta", "Santiago Del Estero", "Trelew", "Tucuman", "Puerto Madryn", "Ushuahia" });
            cmbDestino.Location = new Point(109, 144);
            // 
            // cmbAvion
            // 
            aeronave1.CantidadAsientos = 222;
            aeronave1.CantidadBanios = 2;
            aeronave1.CapacidadBodega = 2222F;
            aeronave1.Comida = true;
            aeronave1.Internet = true;
            aeronave1.Matricula = "sas222ss";
            aeronave1.Ocupado = false;
            aeronave2.CantidadAsientos = 333;
            aeronave2.CantidadBanios = 3;
            aeronave2.CapacidadBodega = 3333F;
            aeronave2.Comida = true;
            aeronave2.Internet = true;
            aeronave2.Matricula = "sas333ss";
            aeronave2.Ocupado = false;
            cmbAvion.Items.AddRange(new object[] { aeronave1, aeronave2 });
            cmbAvion.Location = new Point(109, 203);
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Size = new Size(141, 26);
            lblTitulo.Text = "Modificar viaje";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(123, 1);
            // 
            // btnAgregar
            // 
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(251, 455);
            // 
            // FrmModificarViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 513);
            MinimumSize = new Size(396, 552);
            Name = "FrmModificarViaje";
            Text = "Modificar viaje";
            Load += FrmModificarViaje_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}