using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_08_ENTIDADES
{
    public class AutoF1 : VehiculoDeCarrera
    {
        #region ATRIBUTOS
        private short _caballosDeFuerza;
        #endregion

        #region PROPIEDADES
        public short CaballosDeFuerza { get { return this._caballosDeFuerza; } set { this._caballosDeFuerza = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor que hereda de la clase base.
        /// </summary>
        public AutoF1(short numero,string escuderia)
            : base(numero,escuderia) {  }

        /// <summary>
        /// Constructor de la clase AutoF1 me permite crear una instancia
        /// y utiliza a su vez la sobrecarga de otro constructor.
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="escuderia"></param>
        /// <param name="caballosDeFuerza"></param>
        public AutoF1(short numero, string escuderia,short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this._caballosDeFuerza = caballosDeFuerza;
        }
        #endregion

        #region METODO
        /// <summary>
        /// Devuelve string con los datos del auto.
        /// </summary>
        /// <returns></returns>
        public string MostarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.MostarDatos()} - CABALLOS DE FUERZA: {this._caballosDeFuerza}"); 
            return sb.ToString();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos autos serán iguales si tienen los mismos caballos d fuerza.
        /// </summary>
        /// <param name="autoF1"></param>
        /// <param name="autoF12"></param>
        /// <returns></returns>
        public static bool operator == (AutoF1 autoF1,AutoF1 autoF12)
        {
            bool sonIguales = false;
            if(autoF1 is not null && autoF12 is not null)
            {
                sonIguales = (autoF1._caballosDeFuerza == autoF12._caballosDeFuerza);
            }
            return sonIguales;
        }

        public static bool operator !=(AutoF1 autoF1, AutoF1 autoF12)
        {
            return !(autoF1 == autoF12);
        }
        #endregion
    }
}
