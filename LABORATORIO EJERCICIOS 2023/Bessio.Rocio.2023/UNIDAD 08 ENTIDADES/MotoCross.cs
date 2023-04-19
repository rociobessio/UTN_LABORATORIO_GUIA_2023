using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_08_ENTIDADES
{
    public class MotoCross : VehiculoDeCarrera
    {
        #region ATRIBUTO
        private short _cilindrada;
        #endregion

        #region PROPIEDADES
        public short Cilindrada { get { return _cilindrada; } set { _cilindrada = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor que hereda de la clase padre.
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="escuderia"></param>
        public MotoCross(short numero,string escuderia) 
            : base(numero,escuderia) { }

        /// <summary>
        /// Constructor de la clase MotoCross, realiza una sobrecarga
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="escuderia"></param>
        /// <param name="cilindrada"></param>
        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this._cilindrada=cilindrada;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos motos seran iguale si coinciden sus cilindradas.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator == (MotoCross m1,MotoCross m2)
        {
            bool sonIguales = false;
            if(m1 is not null && m2 is not null)
            {
                sonIguales = m1._cilindrada == m2._cilindrada ;
            }
            return sonIguales;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
        #endregion

        #region METODO
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostarDatos()} - CILINDRADA: {this._cilindrada}");
            return sb.ToString();   
        }
        #endregion
    }
}
