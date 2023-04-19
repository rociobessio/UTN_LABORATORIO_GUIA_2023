using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_08_ENTIDADES
{
    public class DirectorTecnico : Persona
    {
        #region ATRIBUTOS
        private DateTime _fechaNacimiento;
        #endregion

        #region PROPIEDADES
        public DateTime fechaNacimiento { get { return this._fechaNacimiento; } set { this._fechaNacimiento = value; } }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Llamo al constructor de la clase base y le paso el nombre.
        /// </summary>
        /// <param name="nombre"></param>
        private DirectorTecnico(string nombre) 
            : base(nombre)
        {
        
        }

        /// <summary>
        /// Sobrecarga del constructor de la clase.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="fecha"></param>
        public DirectorTecnico (string nombre, DateTime fecha)
            : this(nombre)
        {
            this._fechaNacimiento = fecha;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Sobrecarga del ==, dos directores tecnicos seran iguales
        /// si tienen mismo nombre y fecha de nacimiento.
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public static bool operator == (DirectorTecnico dt1,DirectorTecnico dt2)
        {
            bool sonIguales = false;
            if(dt1 is not null && dt2 is not null)
            {
                sonIguales = (dt1.Nombre == dt2.Nombre) && (dt1._fechaNacimiento == dt2._fechaNacimiento);
            }
            return sonIguales;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
        #endregion

        #region METODOS
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.Append($" - NACIMIENTO: {this._fechaNacimiento}");
            return sb.ToString();
        }
        #endregion
    }
}
