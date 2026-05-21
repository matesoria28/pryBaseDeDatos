namespace pryBaseDeDatos
{
    partial class frmClientesDeudores
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
            this.gbListadoClientes = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblPromedio2 = new System.Windows.Forms.Label();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnReportar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListadoClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListadoClientes
            // 
            this.gbListadoClientes.Controls.Add(this.btnReportar);
            this.gbListadoClientes.Controls.Add(this.btnListar);
            this.gbListadoClientes.Controls.Add(this.lblPromedio2);
            this.gbListadoClientes.Controls.Add(this.lblCantidad2);
            this.gbListadoClientes.Controls.Add(this.lblTotal2);
            this.gbListadoClientes.Controls.Add(this.lblPromedio);
            this.gbListadoClientes.Controls.Add(this.lblCantidad);
            this.gbListadoClientes.Controls.Add(this.lblTotal);
            this.gbListadoClientes.Controls.Add(this.dgvClientes);
            this.gbListadoClientes.Location = new System.Drawing.Point(12, 12);
            this.gbListadoClientes.Name = "gbListadoClientes";
            this.gbListadoClientes.Size = new System.Drawing.Size(503, 455);
            this.gbListadoClientes.TabIndex = 2;
            this.gbListadoClientes.TabStop = false;
            this.gbListadoClientes.Text = "Consulta de Datos";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(383, 418);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(113, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar Deudores";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblPromedio2
            // 
            this.lblPromedio2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio2.Location = new System.Drawing.Point(367, 369);
            this.lblPromedio2.Name = "lblPromedio2";
            this.lblPromedio2.Size = new System.Drawing.Size(129, 23);
            this.lblPromedio2.TabIndex = 6;
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidad2.Location = new System.Drawing.Point(367, 333);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(129, 23);
            this.lblCantidad2.TabIndex = 5;
            // 
            // lblTotal2
            // 
            this.lblTotal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal2.Location = new System.Drawing.Point(367, 295);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(129, 23);
            this.lblTotal2.TabIndex = 4;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(243, 379);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(104, 13);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio de Deuda:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(243, 343);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(107, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad de Clientes:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(263, 305);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total de Deuda:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.dgvClientes.Location = new System.Drawing.Point(0, 19);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(497, 260);
            this.dgvClientes.TabIndex = 0;
            // 
            // btnReportar
            // 
            this.btnReportar.Location = new System.Drawing.Point(237, 418);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(113, 23);
            this.btnReportar.TabIndex = 8;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 479);
            this.Controls.Add(this.gbListadoClientes);
            this.Name = "frmClientesDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Deudores";
            this.gbListadoClientes.ResumeLayout(false);
            this.gbListadoClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoClientes;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblPromedio2;
        private System.Windows.Forms.Label lblCantidad2;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnReportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}