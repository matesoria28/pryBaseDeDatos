using System;
using System.Collections.Generic;
//Agregamos 3 espacios de nombre
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace pryBaseDeDatos
{
    internal class clsClientes
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

       // private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
       private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\BDClientes\\Clientes.mdb";
        private string tabla = "Cliente";

        //Variable de los datos calculados en clientes deudores
        private decimal Deuda;
        private Int32 Cantidad;

        private Int32 idCli;
        private String nom;
        private Decimal deu;
        private Decimal lim;
        private Int32 idAu;
        public decimal TotalDeuda
        {
            get { return Deuda; }

        }

        public Int32 CantidadClientes
        {
            get { return Cantidad; }

        }

        public Decimal PromedioDeuda
        {
            get { return Deuda / Cantidad; }

        }
        public Int32 IdCliente
        {
            get { return idCli; }
            set { idCli = value; }
        }
        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public Decimal Deudas
        {
            get { return deu; }
            set { deu = value; }
        }
        public Decimal Limite
        {
            get { return lim; }
            set { lim = value; }
        }
        public Int32 IdAutomovil
        {
            get { return idAu; }
            set { idAu = value; }
        }


        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

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

        public void ListarDeudores(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                OleDbDataReader DR = comando.ExecuteReader();

                Cantidad = 0;
                Deuda = 0;
                Grilla.Rows.Clear();

                while (DR.Read())
                {
                    if (DR.GetDecimal(2) > 0)
                    {
                        Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(2));
                        Cantidad++;
                        Deuda = Deuda + DR.GetDecimal(2);
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void ReporteCliente()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter AD = new StreamWriter("ReporteClientes.csv", false, Encoding.UTF8);

                AD.WriteLine("Listado de Clientes\n");
                AD.WriteLine("Codigo;Nombre;Deuda");

                Cantidad = 0;
                Deuda = 0;


                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        AD.Write(DR.GetInt32(0));
                        AD.Write(";");
                        AD.Write(DR.GetString(1));
                        AD.Write(";");
                        AD.WriteLine(DR.GetDecimal(2));

                        Cantidad++;
                        Deuda = Deuda + DR.GetDecimal(2);

                    }
                    AD.Write("\nCantidad de Clientes:;;");
                    AD.WriteLine(Cantidad);
                    AD.Write("Deuda de los clientes:;;");
                    AD.WriteLine(Deuda);
                    AD.Write("Promedio de deuda:;;");
                    AD.WriteLine(Deuda / Cantidad);
                }
                AD.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Buscar(Int32 IDCliente)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                while (DR.Read())
                {
                    if (DR.GetInt32(0) == IDCliente)
                    {
                        idCli = DR.GetInt32(0);
                        nom = DR.GetString(1);
                        deu = DR.GetDecimal(2);
                        lim = DR.GetDecimal(3);
                        idAu = DR.GetInt32(4);
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void Agregar()
        {
            string tabla = "Cliente";
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Cliente";

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, tabla);

                DataTable Tabla = DS.Tables[tabla];
                DataRow Fila = Tabla.NewRow();

                Fila["Nombre"] = nom;
                Fila["Deuda"] = 0;
                Fila["Limite"] = lim;
                Fila["idAutomovil"] = idAu;  

                Tabla.Rows.Add(Fila);
                OleDbCommandBuilder CB = new OleDbCommandBuilder(adaptador);
                adaptador.Update(DS, tabla);

                conexion.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }




    }
}
