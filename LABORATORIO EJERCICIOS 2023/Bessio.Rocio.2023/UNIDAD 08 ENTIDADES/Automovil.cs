using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_08_ENTIDADES
{
    /// <summary>
    /// Automovil hereda de la clase VehiculoTerrestre
    /// </summary>
    public class Automovil : VehiculoTerrestre
    {
        #region ATRIBUTOS
        public short _cantidadMarchas;
        public int _cantidadPasajeros;
        #endregion

        #region PROPIEDADES
       // public int CantidadPasajeros { get { return this._cantidadPasajeros; } set { this._cantidadPasajeros = value; } }
       // public short CantidadMarchas { get { return this._cantidadMarchas; } set { this._cantidadMarchas = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor que me permite crear una instancia de la clase Automovil
        /// la cual hereda de VehiculoTerrestre.
        /// </summary>
        /// <param name="cantidadMarchas"></param>
        /// <param name="cantidadPasajeros"></param>
        /// <param name="cantidadRuedas"></param>
        /// <param name="cantidadPuertas"></param>
        /// <param name="color"></param>
        public Automovil(short cantidadMarchas, int cantidadPasajeros, short cantidadRuedas, short cantidadPuertas, Color color)
            : base(cantidadRuedas,cantidadPuertas,color)
        {
            this._cantidadMarchas = cantidadMarchas;
            this._cantidadPasajeros = cantidadPasajeros;
        }
        #endregion
    }
}
