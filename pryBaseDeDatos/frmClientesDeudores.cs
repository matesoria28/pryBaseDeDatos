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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            
            x.ListarDeudores(dgvClientes);
            lblCantidad2.Text = x.CantidadClientes.ToString();
            lblTotal2.Text = x.TotalDeuda.ToString();
            lblPromedio2.Text = x.PromedioDeuda.ToString();
        }
    }
}
