using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBaseDeDatos
{
    public partial class frmAgregarCliente : Form
    {
        public frmAgregarCliente()
        {
            InitializeComponent();
        }
        clsAutomovil x = new clsAutomovil();
        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            x.Listar(cmbAutomovil);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.Nombre=txtNombre.Text;
            x.Limite=Convert.ToDecimal(txtLimite.Text);
            x.IdAutomovil = Convert.ToInt32(cmbAutomovil.SelectedValue);
            x.Agregar();

            MessageBox.Show("Cliente Agregado");
            txtNombre.Text="";
            txtLimite.Text="";
            cmbAutomovil.SelectedIndex = 0;
        }
    }
}
