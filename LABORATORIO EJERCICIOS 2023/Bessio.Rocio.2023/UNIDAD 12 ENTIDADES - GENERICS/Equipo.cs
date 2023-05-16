using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_12_ENTIDADES___GENERICS
{
    public abstract class Equipo
    {
        #region ATRIBUTOS
        public string _nombre;
        public DateTime _fechaCreacion;
        #endregion

        #region CONSTRUCTOR
        public Equipo(string nombre, DateTime fecha) 
        {
            this._nombre = nombre;
            this._fechaCreacion = fecha;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos equipos serán iguales si comparten el mismo nombre y fecha de creación.
        /// </summary>
        /// <param name="equipo1"></param>
        /// <param name="equipo2"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            bool sonIguales = false;
            if (!(equipo1 is null) && !(equipo2 is null))
            {
                sonIguales = (equipo1._nombre == equipo2._nombre) && 
                    (equipo1._fechaCreacion == equipo2._fechaCreacion);
            } 
            return sonIguales;
        }

        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }
        #endregion

        #region METODO
        /// <summary>
        /// El método Ficha retornará el nombre del equipo y su fecha de creación con el siguiente formato:
        // [EQUIPO] fundado el[FECHA]
        /// </summary>
        /// <returns></returns>
        public string Ficha()
        {
            return $"[{this._nombre.ToUpper()}] fundado el [{this._fechaCreacion}]";
        } 
        #endregion
    }
}
