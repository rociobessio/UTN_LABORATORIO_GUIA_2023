using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_04__SOBRECARGA_
{
    public class Celsius
    {
        #region ATRIBUTO
        private int valor;
        #endregion

        #region CONSTRUCTOR
        public Celsius(int valor)
        {
            this.valor = valor;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Este metodo me permite calcular el pasaje
        /// de Celsius a Fahrenheit.
        /// </summary>
        /// <returns></returns>
        public int CelsiusAFahrenheit()
        {
            return (this.valor * 9 / 5) + 32;
        }

        /// <summary>
        /// Este metodo calcula el pasaje de Celsius a Kelvin.
        /// </summary>
        /// <returns></returns>
        public int CelsiusAKelvin()
        {
            double resultado = this.valor + 273.15;
            return (int)resultado;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static explicit operator Kelvin(Celsius c)
        {
            int numero = 0;
            if(c is not null)
            {
                numero = c.CelsiusAKelvin();
            }
            Kelvin kelvinAux = new Kelvin(numero);
            return kelvinAux;
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            int numero = 0; 
            if(c is not null)
            {
                numero = c.CelsiusAFahrenheit();
            }
            Fahrenheit fahrenheitAux = new Fahrenheit(numero);
            return fahrenheitAux;
        }

        /// <summary>
        /// La sobrecarga del operador == se fija si los valores
        /// de las dos instancias que recibe son iguales.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            bool respuesta = false;

            if (c1 is not null && c2 is not null)
            {
                respuesta = c1.valor == c2.valor;
            }
            return respuesta;
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// La sobrecarga del operador + me permite sumar dos instancias
        /// de la clase Celsius si no son null.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static int operator +(Celsius c1, Celsius c2)
        {
            int resultado = 0;
            if (c1 is not null && c2 is not null)
            {
                resultado = c1.valor + c2.valor;
            }
            return resultado;
        }

        /// <summary>
        /// La sobrecarga del operador - me permite restar dos instancias
        /// de la clase Celsius si no son null.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static int operator -(Celsius c1, Celsius c2)
        {
            int resultado = 0;
            if (c1 is not null && c2 is not null)
            {
                resultado = c1.valor - c2.valor;
            }
            return resultado;
        }
        #endregion
    }
}
