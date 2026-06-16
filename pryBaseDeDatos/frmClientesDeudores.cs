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
            lblPromedio2.Text = x.PromedioDeuda.ToString("0,00");
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();
            objArchivo.Title ="Seleccione carpeta y escriba nombre de archivo";
            objArchivo.RestoreDirectory = true;
            objArchivo.Filter = "Archivos separados por coma(*.csv)|*.csv|Archivo de texto(*.txt)|*.txt";

            objArchivo.ShowDialog();

            clsClientes x = new clsClientes();
            x.ReporteCliente(objArchivo.FileName);
            MessageBox.Show("Reporte generado con exito");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            {
                prtVentana.ShowDialog();
                prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
                prtDocumento.Print();
                MessageBox.Show("Reporte Impreso Correctamente");
            }

        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsClientes x = new clsClientes();
            x.Imprimir(e);

             
             Font TipoLetra = new Font("Arial", 12);
             e.Graphics.DrawString("Hola", TipoLetra, Brushes.Blue, 200, 200);
        }

       
    }
}
