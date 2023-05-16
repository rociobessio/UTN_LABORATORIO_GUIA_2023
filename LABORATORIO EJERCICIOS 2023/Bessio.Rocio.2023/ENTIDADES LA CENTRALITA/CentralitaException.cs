using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES_LA_CENTRALITA
{
    public class CentralitaException : Exception
    {
        #region ATRIBUTOS
        private string _nombreClase;
        private string _nombreMetodo;
        #endregion

        #region PROPIEDADES
        public string NombreClase { get {  return _nombreClase; } }
        public string NombreMetodo { get { return _nombreMetodo; } }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Sobrecarga de constructor, le paso al otro constructor
        /// null como innerException
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="clase"></param>
        /// <param name="metodo"></param>
        public CentralitaException(string mensaje,string clase,string metodo) 
            :this(mensaje,clase,metodo,null)
        {
        
        }

        /// <summary>
        /// Contrusctor cargo el atributo y el metodo,
        /// al base Exception le paso un mensaje y el error.
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="clase"></param>
        /// <param name="metodo"></param>
        /// <param name="innerException"></param>
        public CentralitaException(string mensaje, string clase, string metodo,Exception innerException)
            : base(mensaje,innerException)
        {
            this._nombreMetodo = metodo;
            this._nombreClase = clase;
        }
        #endregion
    }
}
