using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_ENTIDADES_PP_COMIQUERIA
{
    public class Comic : Producto
    {
        #region ATRIBUTOS
        private string _autor;
        private TipoComic _tipoComic;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// El constructor inicializa todos los campos con los parámetros de entrada
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="autor"></param>
        /// <param name="tipo"></param>
        public Comic(string descripcion, double precio,int stock, string autor,TipoComic tipo)
            : base(descripcion,precio,stock)
        {
            this._tipoComic = tipo;
            this._autor = autor;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Sobrescribir el método ToString. Agregar a lo devuelto por el ToString de la clase base los
        /// datos del Comic(Autor y TipoComic). Seguir el mismo formato y metodología utilizado en la
        /// clase base.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("  COMIC  ");
            sb.AppendLine($"{base.ToString()}\nAutor: {this._autor}\nTipo de comic: {this._tipoComic}");
            return sb.ToString();   
        }
        #endregion

        #region ENUMERADO
        /// <summary>
        /// Tiene un enumerado TipoComic con dos posibles valores: Occidental, Oriental. 
        /// </summary>
        public enum TipoComic { Occidental,Oriental}
        #endregion
    }
}
