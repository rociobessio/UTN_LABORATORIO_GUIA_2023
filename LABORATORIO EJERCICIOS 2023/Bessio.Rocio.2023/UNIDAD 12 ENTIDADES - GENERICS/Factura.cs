using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_12_ENTIDADES___GENERICS
{
    public class Factura : Documento
    {
        #region CONSTRUCTOR
        public Factura(int numero)
        : base(numero) { }
        #endregion
    }
}
