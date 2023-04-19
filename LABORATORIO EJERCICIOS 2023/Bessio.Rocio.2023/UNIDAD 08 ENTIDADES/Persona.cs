using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_08_ENTIDADES
{
    public class Persona
    {
        #region ATRIBUTOS
        private long _dni;
        private string _nombre;
        #endregion

        #region PROPIEDADES
        public long Dni { get { return this._dni; } set { this._dni = value; } }
        public string Nombre { get { return this._nombre;  } set { this._nombre = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado que me permite crear una instancia de 
        /// la clase Persona.
        /// </summary>
        /// <param name="nombre"></param>
        public Persona(string nombre)
        {
            this._nombre=nombre;
        }

        /// <summary>
        /// Sobrecarga de constructor de la clase Persona.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, long dni)
            : this(nombre)
        {
            this._dni=dni;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Me retorna una string con los datos de 
        /// Persona.
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"NOMBRE: {this._nombre} - DNI: {this._dni}");
            return sb.ToString();
        }
        #endregion
    }
}
