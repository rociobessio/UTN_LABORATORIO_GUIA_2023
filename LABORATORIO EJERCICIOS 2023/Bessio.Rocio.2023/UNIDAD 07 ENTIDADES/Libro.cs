using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_07_ENTIDADES
{
    public class Libro
    {
        #region ATRIBUTO
        private List<string> _paginas;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// El descriptor de acceso GET del indexador leerá la página pedida, 
        /// siempre y cuando el subíndice se encuentre dentro de un rango correcto, 
        /// sino retornará un string vacío.
        /// 
        /// En el SET, si la página existe (existe ese índice) le asignará el texto. 
        /// Si no existe (si el índice es superior al máximo existente), 
        /// agregará una nueva página.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public string this[int i]
        {
            get 
            { 
                //Si el indice es mayor o igual a 0 y que no sea mayor al num d paginas
                if (i >= 0 && i < this._paginas.Count) 
                {
                    return this._paginas[i];//Retorno el indice
                }
                return "";//Retorno string vacio
            }
            set
            {
                if ( i > this._paginas.Count)//Si existe
                {
                    this._paginas.Add(value);//Añado el value que me pasan
                }
                else if( i >= 0)
                {
                    this._paginas.Insert(i, value);
                }
            }
        }
        #endregion

        #region CONSTRUCTOR
        public Libro()
        {
            this._paginas = new List<string>(); 
        }
        #endregion

    }
}
