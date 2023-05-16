using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_10_ENTIDADES___EXCEPCIONES
{
    /// <summary>
    /// Clase de excepcion del ejercicio 'Go Speed Racer Go!'
    /// </summary>
    public class CompetenciaNoDisponibleException : Exception
    {
        #region ATRIBUTOS
        private string _nombreClase;
        private string _nombreMetodo;
        #endregion

        #region PROPIEDADES
        public string NombreClase { get { return _nombreClase; } }
        public string NombreMetodo { get { return _nombreMetodo; } }
        #endregion

        public CompetenciaNoDisponibleException(string mensaje,string clase,string metodo)
            :this(mensaje,clase,metodo,null)
        { 

        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje,innerException)
        {
            _nombreClase = clase;
            _nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepcion del metodo {this._nombreMetodo} de la clase {this._nombreClase}");
            sb.AppendLine($"{Message}");//-->agregamos el mensaje propio de la excepción

            var innerExcepcion = InnerException;
            while (innerExcepcion != null)
            {
                sb.AppendLine("\t" + innerExcepcion.Message);
                innerExcepcion = innerExcepcion.InnerException;
            }
            return sb.ToString();
        }
    }
}
