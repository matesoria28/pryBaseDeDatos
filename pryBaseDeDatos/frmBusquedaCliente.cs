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
    public partial class frmBusquedaCliente : Form
    {
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            Int32 IDCliente = Convert.ToInt32(txtCodigoCliente.Text);
            clsClientes x = new clsClientes();
            x.Buscar(IDCliente);

            if(x.IdCliente != 0)
            {
                lblNombreR.Text = x.Nombre;
                lblDeudaR.Text = x.Deudas.ToString();
                lblLimiteR.Text = x.Limite.ToString();
           
            }
            else
            {
                MessageBox.Show("No se encontro el cliente");
            }
        }

        private void frmBusquedaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
