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
    public partial class frmClientesForeach : Form
    {
        public frmClientesForeach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.ListarForeach(dgvConsulta);
        }
    }
}
