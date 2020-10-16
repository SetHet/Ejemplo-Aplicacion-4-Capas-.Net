using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using ConexionBaseDeDatos;
using ModeloDeDatos;

namespace Negocio
{
    public class NegocioTransaccion
    {
        private DataTransaccion dTransaccion;
        private DataTable tableTransacciones;
        private ConexionSQLServer conexion;

        public DataTransaccion DTransaccion { get => dTransaccion; set => dTransaccion = value; }
        public DataTable TableTransacciones { get => tableTransacciones; private set => tableTransacciones = value; }
        private ConexionSQLServer Conexion { get => conexion; set => conexion = value; }

        public NegocioTransaccion()
        {
            Conexion = new ConexionSQLServer();
            Conexion.Server = "DESKTOP-GBD1PJB";
            Conexion.DataBase = "TEST";
            Conexion.Conectar();
            NewTransaccion();
            TableTransacciones = new DataTable();
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM transaccion";
            TableTransacciones = Conexion.Select(query);
            return TableTransacciones;
        }

        public bool Save()
        {
            string query = $"INSERT INTO transaccion (rut_paciente, nom_paciente, estatura, peso, IMC, estado) VALUES " +
                $"('{DTransaccion.Rut_paciente}', '{DTransaccion.Nom_paciente}', {DTransaccion.Estatura}, {DTransaccion.Peso}, {DTransaccion.Imc}, '{DTransaccion.Estado}')";

            bool correcto = conexion.NonQuery(query);

            return correcto;
        }

        public void NewTransaccion()
        {
            DTransaccion = new DataTransaccion();
        }

    }
}
