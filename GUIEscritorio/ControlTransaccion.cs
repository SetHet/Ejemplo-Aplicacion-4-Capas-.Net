using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloDeDatos;
using Negocio;

namespace GUIEscritorio
{
    public partial class ControlTransaccion : Form
    {
        private NegocioTransaccion nTransaccion;

        public NegocioTransaccion NTransaccion { get => nTransaccion; set => nTransaccion = value; }

        public ControlTransaccion()
        {
            InitializeComponent();
            NTransaccion = new NegocioTransaccion();
            ClearGUI();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            VentanaListaTransacciones lista = new VentanaListaTransacciones();
            lista.ShowDialog();
        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            //Revisar Existencia de Rut
            if (Txt_Rut.Text.Length <= 0)
            {
                MessageBox.Show("Se necesita ingresar el Rut");
                return;
            }

            //Revisar Existencia de Nombre
            if (Txt_Nombre.Text.Length <= 0)
            {
                MessageBox.Show("Se necesita ingresar el Nombre");
                return;
            }

            //Revisar si Estatura es un float
            if (!isFloat(Txt_Estatura.Text))
            {
                MessageBox.Show("La estatura debe ser un decimal");
                return;
            }

            //Revisar si Estatura es mayor que 0
            if (getFloat(Txt_Estatura.Text) <= 0)
            {
                MessageBox.Show("La estatura debe ser un decimal positivo mayor que 0");
                return;
            }

            //Revisar si Peso es un int
            if (!isInt(Txt_Peso.Text))
            {
                MessageBox.Show("El peso debe ser un entero");
                return;
            }

            //Revisar si Estatura es mayor que 0
            if (getInt(Txt_Peso.Text) <= 0)
            {
                MessageBox.Show("El peso debe ser un entero positivo mayor que 0");
                return;
            }

            //Comenzar Guardado si todo esta bien
            NTransaccion.NewTransaccion();
            NTransaccion.DTransaccion.Rut_paciente = Txt_Rut.Text;
            NTransaccion.DTransaccion.Nom_paciente = Txt_Nombre.Text;
            NTransaccion.DTransaccion.Estatura = getFloat(Txt_Estatura.Text);
            NTransaccion.DTransaccion.Peso = getInt(Txt_Peso.Text);
            NTransaccion.DTransaccion.Imc = getFloat(Txt_IMC.Text);
            NTransaccion.DTransaccion.Estado = Txt_Resultado.Text;

            bool insercionCorrecta = NTransaccion.Save();

            if (insercionCorrecta)
            {
                MessageBox.Show("Transaccion Guardada");
                ClearGUI();
            }
            else
            {
                MessageBox.Show("No se ha podido guardar la transaccion");
            }
        }


        private bool isInt(string txt)
        {
            return int.TryParse(txt, out int valor);
        }

        private bool isFloat(string txt)
        {
            return float.TryParse(txt, out float valor);
        }

        private int getInt(string txt)
        {
            return int.Parse(txt);
        }

        private float getFloat(string txt)
        {
            return float.Parse(txt);
        }

        private void ClearGUI()
        {
            Txt_Rut.Clear();
            Txt_Nombre.Clear();
            Txt_Estatura.Clear();
            Txt_Peso.Clear();
            Txt_IMC.Clear();
            Txt_Resultado.Clear();

            Txt_Rut.Focus();
        }

        private void ActualizarIMC()
        {
            bool calculable = true;

            //Revisar si Estatura es un float
            if (!isFloat(Txt_Estatura.Text))
            {
                calculable = false;
            }

            //Revisar si Estatura es mayor que 0
            else if (getFloat(Txt_Estatura.Text) <= 0)
            {
                calculable = false;
            }

            //Revisar si Peso es un int
            if (!isInt(Txt_Peso.Text))
            {
                calculable = false;
            }

            //Revisar si Estatura es mayor que 0
            else if (getInt(Txt_Peso.Text) <= 0)
            {
                calculable = false;
            }

            if (calculable)
            {
                float peso = getInt(Txt_Peso.Text);
                float estatura = getFloat(Txt_Estatura.Text);
                float valorIMC = peso / (estatura * estatura);

                Txt_IMC.Text = valorIMC.ToString();

                if (valorIMC < 18)
                    Txt_Resultado.Text = "esqueleto";
                else if (valorIMC < 25)
                    Txt_Resultado.Text = "bien";
                else
                    Txt_Resultado.Text = "Ballena";
            }
            else
            {
                Txt_IMC.Text = "Se necesita Peso y Estatura";
                Txt_Resultado.Text = "Se necesita IMC";
            }
        }


        //Mal
        private void Txt_IMC_TextChanged(object sender, EventArgs e)
        {
            ActualizarIMC();
        }

        //Mal
        private void Txt_Resultado_TextChanged(object sender, EventArgs e)
        {
            ActualizarIMC();
        }


        private void Txt_Estatura_TextChanged(object sender, EventArgs e)
        {
            ActualizarIMC();
        }

        private void Txt_Peso_TextChanged(object sender, EventArgs e)
        {
            ActualizarIMC();
        }
    }
}
