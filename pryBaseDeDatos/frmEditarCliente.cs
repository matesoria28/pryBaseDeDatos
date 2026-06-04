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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 IDCliente = Convert.ToInt32(txtCodigoCliente.Text);
            clsClientes x = new clsClientes();
            x.Buscar(IDCliente);

            if (x.IdCliente != 0)
            {
                lblNombreR.Text = x.Nombre;
                lblDeudaR.Text = x.Deudas.ToString();
                txtLimite.Text = x.Limite.ToString();

            }
            else
            {
                MessageBox.Show("No se encontro el cliente");
            }

            txtLimite.ReadOnly = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;

        }

        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else 
            {
                btnBuscar.Enabled = false; 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;    
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            txtLimite.ReadOnly = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();  
            Int32 id = Convert.ToInt32(txtCodigoCliente.Text);

            x.Limite = Convert.ToDecimal(txtLimite.Text);
            x.Modificar(id);
            MessageBox.Show("El cliente se cambio correctamente");
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            Int32 id = Convert.ToInt32(txtCodigoCliente.Text);

            x.Eliminar(id);
            MessageBox.Show("Cliente Eliminado");
            Limpiar();
        }

        private void Limpiar()
        { 
            txtCodigoCliente.Text = "";
            lblNombreR.Text = "";
            lblDeudaR.Text = "";
            txtLimite.Text = "";
            txtLimite.ReadOnly = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
        }
    
    }
}
