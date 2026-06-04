namespace pryBaseDeDatos
{
    partial class frmBusquedaCliente
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
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblLimiteR = new System.Windows.Forms.Label();
            this.lblDeudaR = new System.Windows.Forms.Label();
            this.lblNombreR = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Location = new System.Drawing.Point(33, 17);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(94, 13);
            this.lblCodigoCliente.TabIndex = 0;
            this.lblCodigoCliente.Text = "Codigo del cliente:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(222, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(147, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(155, 12);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(214, 20);
            this.txtCodigoCliente.TabIndex = 2;
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.lblLimiteR);
            this.gbDatosCliente.Controls.Add(this.lblDeudaR);
            this.gbDatosCliente.Controls.Add(this.lblNombreR);
            this.gbDatosCliente.Controls.Add(this.lblLimite);
            this.gbDatosCliente.Controls.Add(this.lblDeuda);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Location = new System.Drawing.Point(12, 85);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(361, 232);
            this.gbDatosCliente.TabIndex = 3;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del cliente";
            // 
            // lblLimiteR
            // 
            this.lblLimiteR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLimiteR.Location = new System.Drawing.Point(111, 143);
            this.lblLimiteR.Name = "lblLimiteR";
            this.lblLimiteR.Size = new System.Drawing.Size(218, 23);
            this.lblLimiteR.TabIndex = 5;
            // 
            // lblDeudaR
            // 
            this.lblDeudaR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudaR.Location = new System.Drawing.Point(111, 81);
            this.lblDeudaR.Name = "lblDeudaR";
            this.lblDeudaR.Size = new System.Drawing.Size(218, 23);
            this.lblDeudaR.TabIndex = 4;
            // 
            // lblNombreR
            // 
            this.lblNombreR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreR.Location = new System.Drawing.Point(111, 25);
            this.lblNombreR.Name = "lblNombreR";
            this.lblNombreR.Size = new System.Drawing.Size(218, 23);
            this.lblNombreR.TabIndex = 3;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(20, 153);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(88, 13);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Limite de Credito:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(20, 91);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 1;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 326);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCodigoCliente);
            this.Name = "frmBusquedaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Cliente";
//            this.Load += new System.EventHandler(this.frmBusquedaCliente_Load);
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.Label lblLimiteR;
        private System.Windows.Forms.Label lblDeudaR;
        private System.Windows.Forms.Label lblNombreR;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblNombre;
    }
}