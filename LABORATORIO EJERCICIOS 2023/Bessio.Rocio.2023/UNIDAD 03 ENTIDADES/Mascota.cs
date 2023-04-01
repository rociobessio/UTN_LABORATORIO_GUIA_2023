using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_03_ENTIDADES
{
    public class Mascota
    {
        #region ATRIBUTOS
        private Especie especieAnimal;
        private string nombre;
        private DateTime fechaDeNacimiento;
        private List<string> listaVacunas;
        private string vacuna;
        #endregion

        #region PROPIEDADES
        public Especie Especie { get { return this.especieAnimal; } set { this.especieAnimal = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public DateTime FechaDeNacimiento { get { return this.fechaDeNacimiento; } set { this.fechaDeNacimiento = value; } }
        public List<string> HistorialVacunas { get { return this.listaVacunas; } set { this.listaVacunas = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor que inicializara la lista de vacunas. Arranca vacio
        /// </summary>
        public Mascota()
        {
            this.listaVacunas = new List<string>();
        }

        /// <summary>
        /// Sobrecarga del constructor. Los primeros tres datos seran necesarios
        /// si o si para dar de alta a una mascota.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="fecha"></param>
        /// <param name="especie"></param>
        public Mascota(string nombre, DateTime fecha, Especie especie,List<string> listvacunas) : this()
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fecha;
            this.especieAnimal = especie;
            this.listaVacunas = listvacunas;
        }
        #endregion

        #region SOBRECARGA
        /// <summary>
        /// Sobrecarga del ==. Dos mascotas seran iguales
        /// si son dela misma especie y misma fecha de nacimiento.
        /// </summary>
        /// <param name="masc1"></param>
        /// <param name="mascota2"></param>
        /// <returns></returns>
        public static bool operator ==(Mascota masc1, Mascota mascota2)
        {
            return (masc1.especieAnimal == mascota2.especieAnimal && masc1.fechaDeNacimiento == mascota2.fechaDeNacimiento);
        }

        public static bool operator !=(Mascota masc1, Mascota mascota2)
        {
            return !(masc1 == mascota2);
        }
        #endregion

        #region METODOS
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {this.nombre} - FECHA DE NACIMIENTO: {this.fechaDeNacimiento.ToShortDateString()} - ESPECIE: {this.especieAnimal.ToString()}");
            sb.AppendLine("HISTORIAL DE VACUNAS: ");
            if (this.listaVacunas.Count > 0)
                for (int i = 0; i < this.listaVacunas.Count; i++)
                {
                    sb.AppendLine($"{this.listaVacunas[i].ToString()}");
                }
            else
            {
                sb.AppendLine("NO CUENTA CON VACUNAS");
            }
            return sb.ToString();
        }
        #endregion
    }
}
