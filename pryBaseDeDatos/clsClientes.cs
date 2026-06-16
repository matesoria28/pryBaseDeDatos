using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;


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

            //catch (Exception e)
            //{
            //    MessageBox.Show(e.ToString());

            //}

            catch (FormatException)
            {
                MessageBox.Show("No se puede convertir el tipo de dato");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("El valor del argumento no puede ser nulo");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("El índice se encuentra fuera del rango de la matriz");
            }
            finally
            {
                //lo que va aca se ejecuta siempre, haya o no error
            }


        }


        public void Modificar(Int32 idCliente)
        {
            try 
            {
                String sql = "";
                sql = "UPDATE Cliente SET Limite = " + lim + " WHERE idCliente = "+ idCliente.ToString();
                
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }


        public void Eliminar(Int32 idCliente)
        {
            try
            {
                String sql = "";
                sql = "DELETE * FROM Cliente WHERE idCliente = " + idCliente.ToString();

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.ExecuteNonQuery();

                conexion.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void AgregarNuevoRegistro()
        {
            try
            {
                String sql = "";
                sql = "INSERT INTO Cliente (Nombre,Deuda,Limite,idAutomovil)";
                sql = sql + "VALUES ('" + nom + "',0," + lim.ToString() + "," + idAu.ToString() + ")";
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.ExecuteNonQuery();

                conexion.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void ListarForeach(DataGridView Grilla)
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
                adaptador.Fill(DS, tabla);

                if (DS.Tables[tabla].Rows.Count > 0) //si ese DS tiene filas
                {
                    foreach (DataRow x in DS.Tables[tabla].Rows)
                    {
                        Grilla.Rows.Add(x["Nombre"], x["idAutomovil"]);
                    }
                }

                conexion.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ReporteCliente(String NombreArchivo)
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
                adaptador.Fill(DS, tabla);

                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);

                AD.WriteLine("Listado de Clientes\n");
                AD.WriteLine("Codigo;Nombre;Deuda");

                Cantidad = 0;
                Deuda = 0;


                if (DS.Tables[tabla].Rows.Count>0)
                {
                    foreach (DataRow fila in DS.Tables[tabla].Rows)
                    {
                        AD.Write(fila["idCliente"]);
                        AD.Write(";");
                        AD.Write(fila["Nombre"]);
                        AD.Write(";");
                        AD.WriteLine(fila["deuda"]);

                        Cantidad++;
                        Deuda = Deuda + Convert.ToDecimal(fila["deuda"]);

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

        public void Imprimir(PrintPageEventArgs reporte)
        {
            try
            {
                Font LetraTitulo1 = new Font("Arial", 20);
                Font LetraTitulo2 = new Font("Arial", 12);
                Font LetraTexto = new Font("Arial", 8);
                Int32 f = 200;
                reporte.Graphics.DrawString("Listado de Clientes", LetraTitulo1, Brushes.Red, 100, 100);
                reporte.Graphics.DrawString("Código", LetraTitulo2, Brushes.Blue, 100, 180);
                reporte.Graphics.DrawString("Nombre del cliente", LetraTitulo2, Brushes.Blue, 150, 180);

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                adaptador = new OleDbDataAdapter(comando);

                DataSet DS = new DataSet();
                adaptador.Fill(DS, tabla);

                if (DS.Tables[tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[tabla].Rows)
                    {
                        reporte.Graphics.DrawString(fila["IdCliente"].ToString(), LetraTexto, Brushes.Black, 100, f);
                        reporte.Graphics.DrawString(fila["Nombre"].ToString(), LetraTexto, Brushes.Black, 300, f);
                        f = f + 15;
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

        }





    }
}
