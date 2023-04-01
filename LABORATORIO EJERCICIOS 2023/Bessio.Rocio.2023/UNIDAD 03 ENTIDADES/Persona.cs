using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_03_ENTIDADES
{
    public class Persona
    {
        #region ATRIBUTOS
        private string nombre;
        private string dni;
        private DateTime fechaDeNacimiento;
        #endregion

        #region PROPIEDADES
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string DNI { get { return this.dni; } set { this.dni = value; } }
        public DateTime FechaNacimiento { get { return this.fechaDeNacimiento; } set { this.fechaDeNacimiento = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// COnstructor que inicializa los atributos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="dni"></param>
        /// <param name="fechaNacimiento"></param>
        public Persona(string nombre, string dni, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.fechaDeNacimiento = fechaNacimiento;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha 
        /// de nacimiento
        /// </summary>
        /// <returns></returns>
        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - this.fechaDeNacimiento.Year;
            if (ValidarAño(this.fechaDeNacimiento) && fechaActual < this.fechaDeNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }

        /// <summary>
        /// Mostrar retornará una cadena de texto con todos los datos de la persona, 
        /// incluyendo la edad actual.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE {this.nombre} - DNI {this.dni} - FECHA NACIMIENTO {this.fechaDeNacimiento.ToShortDateString()} - EDAD {CalcularEdad()}");
            return sb.ToString();
        }

        /// <summary>
        /// EsMayorDeEdad si es mayor de edad devuelve el valor
        /// “Es mayor de edad", sino devuelve “es menor”.
        /// </summary>
        /// <returns></returns>
        public string EsMayorDeEdad()
        {
            string esMayor = "Es mayor de edad!";
            int edad = CalcularEdad();
            if (edad < 18)
            {
                esMayor = "Es menor de edad!";
            }
            return esMayor;
        }
        #endregion

        #region VALIDADOR
        /// <summary>
        /// Me valida que el año no sea menor a 1939
        /// </summary>
        /// <param name="fechaNacimiento"></param>
        /// <returns></returns>
        private bool ValidarAño(DateTime fechaNacimiento)
        {
            DateTime dateTime = new DateTime(1939, 01, 01);
            return fechaDeNacimiento.Year > dateTime.Year;
        }
        #endregion
    }
}
