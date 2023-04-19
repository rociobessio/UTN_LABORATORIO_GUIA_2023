using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_08_ENTIDADES
{
    /// <summary>
    /// La clase moto hereda de la clase VehiculoTerrestre,
    /// con sus atributos.
    /// </summary>
    public class Moto : VehiculoTerrestre
    {
        #region ATRIBUTOS
        public short _cilindrada;
        #endregion

        #region PROPIEDADES
        //public short Cilindrada { get { return this._cilindrada; } set { this._cilindrada = value;} }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor que hereda de la clase base VehiculoTerrestre.
        /// </summary>
        /// <param name="cilindrada"></param>
        /// <param name="cantidadRuedas"></param>
        /// <param name="cantidadPuertas"></param>
        /// <param name="color"></param>
        public Moto(short cilindrada, short cantidadRuedas, short cantidadPuertas, Color color)
            : base(cantidadRuedas,cantidadPuertas,color)
        {
            this._cilindrada = cilindrada;
        }
        #endregion
    }
}
