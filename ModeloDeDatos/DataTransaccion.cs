using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDatos
{
    public class DataTransaccion
    {
        private string rut_paciente;
        private string nom_paciente;
        private float estatura;
        private int peso;
        private float imc;
        private string estado;

        private const int rut_paciente_maxLenght = 15;
        private const int nombre_paciente_maxLenght = 40;
        private const int estado_maxLenght = 15;

        public string Rut_paciente { get => rut_paciente; set => rut_paciente = value; }
        public string Nom_paciente { get => nom_paciente; set => nom_paciente = value; }
        public float Estatura { get => estatura; set => estatura = value; }
        public int Peso { get => peso; set => peso = value; }
        public float Imc { get => imc; set => imc = value; }
        public string Estado { get => estado; set => estado = value; }

        public static int Rut_paciente_maxLenght => rut_paciente_maxLenght;

        public static int Nombre_paciente_maxLenght => nombre_paciente_maxLenght;

        public static int Estado_maxLenght => estado_maxLenght;
    }
}
