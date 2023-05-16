using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_12_ENTIDADES___GENERICS
{
    /// <summary>
    /// Tanto el tipo genérico T como el U deberán ser del tipo Documento o 
    /// uno de sus derivados.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class Contabilidad<T,U> 
        where T : Documento 
        where U : Documento, new ()//-->Restricción que indique que deberá tener un constructor público y sin parámetros.
    {
        #region ATRIBUTOS
        public List<T> _listaEgresos;
        public List<U> _listaIngresos;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// COnstructor me permite inicializar las listas.
        /// </summary>
        public Contabilidad()
        {
            this._listaEgresos = new List<T>();
            this._listaIngresos = new List<U>();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// El operador + entre Contabilidad y T agrega un elemento a la lista egresos.
        /// </summary>
        /// <param name="contabilidad"></param>
        /// <param name="egreso"></param>
        /// <returns></returns>
        public static Contabilidad<T,U> operator +(Contabilidad<T, U> contabilidad, T egreso)
        {
            if (contabilidad is not null && !(egreso is null))
            {
                contabilidad._listaEgresos.Add(egreso);
                return contabilidad;
            }
            return contabilidad;
        }

        /// <summary>
        /// El operador + entre Contabilidad y U agrega un elemento a la lista ingresos.
        /// </summary>
        /// <param name="contabilidad"></param>
        /// <param name="ingreso"></param>
        /// <returns></returns>
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, U ingreso)
        {
            if (contabilidad is not null && !(ingreso is null))
            {
                contabilidad._listaIngresos.Add(ingreso);
                return contabilidad;
            }
            return contabilidad;
        }
        #endregion
    }
}
