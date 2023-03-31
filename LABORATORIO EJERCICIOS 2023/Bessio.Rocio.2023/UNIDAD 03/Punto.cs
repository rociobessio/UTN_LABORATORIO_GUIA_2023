using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_03
{
    public class Punto
    {
        #region ATRIBUTOS
        private int x;
        private int y;
        #endregion

        #region PROPIEDADES
        public int X { get { return x; } }
        public int Y { get { return y; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        } 
        #endregion
    }
}
