using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_12_ENTIDADES___GENERICS
{
    public class Documento
    {
        #region ATRIBUTOS
        private int _numero;
        #endregion

        #region PROPIEDAD
        public int Numero { get { return this._numero; } }
        #endregion

        #region CONSTRUCTOR
        public Documento(int numero)
        {
            this._numero = numero;
        }
        #endregion
    }
}
