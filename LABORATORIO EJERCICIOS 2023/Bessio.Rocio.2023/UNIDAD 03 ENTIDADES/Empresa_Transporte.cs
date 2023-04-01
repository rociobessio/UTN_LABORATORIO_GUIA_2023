using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_03_ENTIDADES
{
    public class Empresa_Transporte
    {
        #region ATRIBUTOS
        private Conductores[] arrayConductores;
        #endregion

        #region PROPIEDADES
        public Conductores[] ArrayConductores { get { return this.arrayConductores; } set { this.arrayConductores = value; } }
        #endregion

        #region CONSTRUCTOR
        public Empresa_Transporte(Conductores[] array)
        {
            this.arrayConductores = array;
        }
        #endregion

        #region METODOS
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.arrayConductores.Length; i++)
            {
                sb.AppendLine(arrayConductores[i].Mostrar());
            }
            return sb.ToString();
        }
        #endregion
    }
}
