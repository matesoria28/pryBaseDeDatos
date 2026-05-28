namespace pryBaseDeDatos
{
    partial class frmAgregarCliente
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
            this.gbCargaDatos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblAutomobil = new System.Windows.Forms.Label();
            this.cmbAutomobil = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.gbCargaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCargaDatos
            // 
            this.gbCargaDatos.Controls.Add(this.btnCargar);
            this.gbCargaDatos.Controls.Add(this.txtLimite);
            this.gbCargaDatos.Controls.Add(this.txtNombre);
            this.gbCargaDatos.Controls.Add(this.cmbAutomobil);
            this.gbCargaDatos.Controls.Add(this.lblAutomobil);
            this.gbCargaDatos.Controls.Add(this.lblLimite);
            this.gbCargaDatos.Controls.Add(this.lblNombre);
            this.gbCargaDatos.Location = new System.Drawing.Point(13, 13);
            this.gbCargaDatos.Name = "gbCargaDatos";
            this.gbCargaDatos.Size = new System.Drawing.Size(395, 263);
            this.gbCargaDatos.TabIndex = 0;
            this.gbCargaDatos.TabStop = false;
            this.gbCargaDatos.Text = "Carga de Datos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre y Apellido:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(19, 99);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(88, 13);
            this.lblLimite.TabIndex = 1;
            this.lblLimite.Text = "Limite de Credito:";
            // 
            // lblAutomobil
            // 
            this.lblAutomobil.AutoSize = true;
            this.lblAutomobil.Location = new System.Drawing.Point(19, 163);
            this.lblAutomobil.Name = "lblAutomobil";
            this.lblAutomobil.Size = new System.Drawing.Size(56, 13);
            this.lblAutomobil.TabIndex = 2;
            this.lblAutomobil.Text = "Automobil:";
            // 
            // cmbAutomobil
            // 
            this.cmbAutomobil.FormattingEnabled = true;
            this.cmbAutomobil.Location = new System.Drawing.Point(123, 155);
            this.cmbAutomobil.Name = "cmbAutomobil";
            this.cmbAutomobil.Size = new System.Drawing.Size(260, 21);
            this.cmbAutomobil.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(123, 91);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(161, 20);
            this.txtLimite.TabIndex = 5;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(273, 221);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(110, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 290);
            this.Controls.Add(this.gbCargaDatos);
            this.Name = "frmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.gbCargaDatos.ResumeLayout(false);
            this.gbCargaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargaDatos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbAutomobil;
        private System.Windows.Forms.Label lblAutomobil;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblNombre;
    }
}