using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_DE_CLASES_PP__LA_LIBRERIA
{
    /// <summary>
    /// Clase que hereda de publicacion.
    /// </summary>
    public class Comic : Publicacion
    {
        #region ATRIBUTOS
        private bool esColor;
        #endregion

        #region PROPIEDADES
        protected override bool EsColor { get { return this.esColor; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado que hereda de la clase base (Publicacion)
        /// </summary>
        /// <param name="importe"></param>
        /// <param name="esColor"></param>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        public Comic(string nombre, bool esColor,int stock, float importe)
            : base(nombre,stock,importe)
        {
            this.esColor = esColor;
        }
        #endregion
    }
}
