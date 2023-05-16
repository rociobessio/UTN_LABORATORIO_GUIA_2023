using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_12_ENTIDADES___GENERICS
{
    public class Recibo : Documento
    {
        #region CONSTRUCTORES
        public Recibo()
            : this(0) { }

        public Recibo(int numero)
            : base(numero) { }
        #endregion
    }
}
