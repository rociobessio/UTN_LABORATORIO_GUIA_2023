using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_04__SOBRECARGA_
{
    public class Kelvin
    {
        #region ATRIBUTO
        private int valor; 
        #endregion

        #region CONSTRUCTOR
        public Kelvin(int valor)
        {
            this.valor = valor;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Me calcula el pasaje de Kelvin a celsius y lo 
        /// retorna.
        /// </summary>
        /// <returns></returns>
        public int KelvinACelsius()
        {
            double resultKelvACelsius = (this.valor - 273.15);
            return (int)resultKelvACelsius;
        }

        /// <summary>
        /// Me pasa kelvin a fahrenheit.
        /// reutilizo codgio llamando al metodo KelvinACelsius de
        /// la clase.
        /// </summary>
        /// <returns></returns>
        public int KelvinAFahrenheit()
        {
            double resultKelvAFahrenheit = this.KelvinACelsius() * 9 / 5 + 32;
            return (int) resultKelvAFahrenheit;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static explicit operator Fahrenheit(Kelvin k)
        {
            int numero = 0;
            if(k is not null)
            {
                numero = k.KelvinAFahrenheit();
            }
            Fahrenheit fahrenheitAux = new Fahrenheit(numero);
            return fahrenheitAux;
        }

        public static explicit operator Celsius (Kelvin k)
        {
            int numero = 0;
            if (k is not null)
            {
                numero = k.KelvinACelsius();
            }
            Celsius celsiusAux = new Celsius(numero);
            return celsiusAux;
        }

        /// <summary>
        /// La sobrecarga del operador == se fija si los valores de 
        /// los dos parametros recibidos son iguales.
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <returns></returns>
        public static bool operator == (Kelvin k1,Kelvin k2)
        {
            bool sonIguales = false;
            if (k1 is not null && k2 is not null)
            {
                sonIguales = k1.valor == k2.valor;
            }
            return sonIguales;
        }

        public static bool operator != (Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        /// <summary>
        /// La sobrecarga del operador - me permite restar dos
        /// valores de Kelvin.
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <returns></returns>
        public static int operator - (Kelvin k1, Kelvin k2)
        {
            int resta = 0;
            if (k1 is not null && k2 is not null)
            {
                resta = k1.valor - k2.valor;
            }
            return resta;
        }

        /// <summary>
        /// La sobrecarga del operador + me permite sumar dos
        /// valores de Kelvin.
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <returns></returns>
        public static int operator + (Kelvin k1, Kelvin k2)
        {
            int suma = 0;
            if (k1 is not null && k2 is not null)
            {
                suma = k1.valor + k2.valor;
            }
            return suma;
        }
        #endregion
    }
}
