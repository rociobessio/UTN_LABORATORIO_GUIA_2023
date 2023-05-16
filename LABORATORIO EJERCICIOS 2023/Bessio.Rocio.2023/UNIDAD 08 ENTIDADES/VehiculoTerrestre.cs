using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_08_ENTIDADES
{
    public class VehiculoTerrestre
    {
        #region ATRIBUTOS
        public short cantidadRuedas;//protected -> me permite acceder desde la clase que hereda
        public short cantidadPuertas;
        public Color color;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado de la clase base VehiculoTerrestre.
        /// </summary>
        /// <param name="cantidadRuedas"></param>
        /// <param name="cantidadPuertas"></param>
        /// <param name="color"></param>
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Color color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
        #endregion 
    }
}
