using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregamos 3 espacios de nombre
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryBaseDeDatos
{
    internal class clsClientes
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConeccion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Clientes.mdb";
        private String Tabla = "Cliente";

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConeccion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS);

                Grilla.DataSource = DS.Tables[0];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString()); 

            }


        }
    }
}
