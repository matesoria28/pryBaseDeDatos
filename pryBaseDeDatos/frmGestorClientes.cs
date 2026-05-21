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
    }
}
