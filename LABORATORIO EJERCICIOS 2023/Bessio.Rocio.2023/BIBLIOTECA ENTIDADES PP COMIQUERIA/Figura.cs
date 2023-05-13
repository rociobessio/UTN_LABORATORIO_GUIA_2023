using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_ENTIDADES_PP_COMIQUERIA
{
    /// <summary>
    /// Hereda de producto
    /// </summary>
    public class Figura : Producto
    {
        #region ATRIBUTO
        private double _altura;
        #endregion

        #region CONSTRUCTORES
        public Figura(int stock,double precio,double altura)
            : this(($"Figura {altura} cm."), stock, precio, altura)
        {  }

        public Figura(string descripcion, int stock, double precio, double altura)
            : base(descripcion,precio,stock)
        {
            this._altura = altura;
        }
        #endregion

        #region METODO
        /// <summary>
        /// Sobrescribir el método ToString. Agregar a lo devuelto por el ToString de la clase base los
        /// datos de la Figura(Altura). Seguir el mismo formato y metodología utilizado en la clase base.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("  COMIC  ");
            sb.AppendLine($"{base.ToString()}\nAltura: {this._altura}");
            return sb.ToString();
        }
        #endregion

    }
}
