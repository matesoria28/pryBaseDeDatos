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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes x = new frmListadoClientes();
            x.ShowDialog();
        }

        private void listadoDeDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesDeudores x = new frmClientesDeudores();
            x.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buscarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente x = new frmBusquedaCliente();
            x.ShowDialog();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCliente x = new frmAgregarCliente();
            x.ShowDialog();
        }

        private void consultaDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarCliente x = new frmEditarCliente();
            x.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeClientesForeachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesForeach x = new frmClientesForeach();
            x.ShowDialog();
        }
    }
}
