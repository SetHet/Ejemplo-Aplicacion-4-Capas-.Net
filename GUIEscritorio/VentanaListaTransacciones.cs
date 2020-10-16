using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Data;
using ModeloDeDatos;

namespace GUIEscritorio
{
    public partial class VentanaListaTransacciones : Form
    {
        private NegocioTransaccion nTransaccion;
        private DataTable tablaTransaccion;

        public NegocioTransaccion NTransaccion { get => nTransaccion; set => nTransaccion = value; }
        public DataTable TablaTransaccion { get => tablaTransaccion; set => tablaTransaccion = value; }

        public VentanaListaTransacciones()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
            this.Close();
        }

        private void ActualizarTabla()
        {
            NTransaccion = new NegocioTransaccion();
            TablaTransaccion = NTransaccion.GetAll();

            DataGridView_Tabla.DataSource = TablaTransaccion;

            DataGridView_Tabla.Columns["rut_paciente"].HeaderText = "RUT Paciente";
            DataGridView_Tabla.Columns["nom_paciente"].HeaderText = "Nombre Paciente";
            DataGridView_Tabla.Columns["estatura"].HeaderText = "Estatura";
            DataGridView_Tabla.Columns["peso"].HeaderText = "Peso";
            DataGridView_Tabla.Columns["IMC"].HeaderText = "IMC";
            DataGridView_Tabla.Columns["estado"].HeaderText = "Estado";
        }
    }
}
