using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ConexionBaseDeDatos
{
    public class ConexionSQLServer
    {
        private SqlConnection conexionSQL;
        private string conexionString;
        private string server;
        private string dataBase;

        public SqlConnection ConexionSQL { get => conexionSQL; set => conexionSQL = value; }
        public string ConexionString { get => conexionString; set => conexionString = value; }
        public string Server { get => server; set => server = value; }
        public string DataBase { get => dataBase; set => dataBase = value; }

        public void Conectar()
        {
            if (Server.Equals(""))
            {
                MessageBox.Show("ConexionSQLServer, Server esta vacio");
                return;
            }
            if (dataBase.Equals(""))
            {
                MessageBox.Show("ConexionSQLServer, DataBase esta vacio");
                return;
            }

            try
            {
                ConexionString = $"Server={Server};Database={DataBase};Trusted_Connection=True;";
                ConexionSQL = new SqlConnection(ConexionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ConexionSQLServer, No se pudo generar la conexion. \n" + ex.Message);
            }
        }

        public void Open()
        {
            try
            {
                ConexionSQL.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ConexionSQLServer, No se abrir la conexion. \n" + ex.Message);
            }
        }

        public void Close()
        {
            try
            {
                ConexionSQL.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ConexionSQLServer, No se cerro la conexion. \n" + ex.Message);
            }
        }

        public DataTable Select(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, ConexionSQL);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select, No se realizo correctamente el Select. \n" + ex.Message);
            }

            Close();
            
            return dataTable;
        }

        public bool NonQuery(string query)
        {
            bool correcto = false; ;

            try
            {
                Open();

                SqlCommand command = new SqlCommand(query, ConexionSQL);
                command.ExecuteNonQuery();

                correcto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NonQuery, No se realizo correctamente el NonQuery. \n" + ex.Message);
                correcto = false;
            }

            Close();

            return correcto;
        }

    }
}
