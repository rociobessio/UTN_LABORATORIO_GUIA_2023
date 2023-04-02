using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_DE_CLASES_PP__LA_LIBRERIA
{
    public class Biografia : Publicacion
    {
        #region PROPIEDADES
        /// <summary>
        /// Retornara siempre que NO
        /// </summary>
        protected override bool EsColor { get { return false; } }
        /// <summary>
        /// La propiedad HayStock controlará solo que haya stock, sin importar el valor de venta.
        /// </summary>
        public override bool HayStock { get { return stock > 0; } }
        #endregion

        #region CONSTRUCTORES
        public Biografia(string nombre) 
            : base(nombre) { }

        public Biografia(string nombre, int stock)
            : base(nombre,stock)
        { }

        public Biografia(string nombre, int stock, float importe)
            : base(nombre, stock, importe) { }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// La conversión explicita generará un objeto Biografia.
        /// </summary>
        /// <param name="nombre"></param>
        public static explicit operator Biografia (string nombre)
        {
            return new Biografia(nombre);
        }
        #endregion
    }
}
