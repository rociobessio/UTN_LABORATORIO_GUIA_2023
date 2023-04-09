using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_04__SOBRECARGA_
{
    public class Fahrenheit
    {
        #region ATRIBUTO
        private int valor;

        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="valor"></param>
        public Fahrenheit(int valor)
        {
            this.valor = valor;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Me calcula cuanto seria el pasaje de Fahrenheit a
        /// Celsius.
        /// 
        /// FORMULA:
        /// C = (F-32) * 5/9
        /// </summary>
        /// <returns></returns>
        public int FahrenheitACelsius()
        {
            double resultadoCelsius = (this.valor - 32) * 5 / 9;
            return (int)resultadoCelsius;
        }

        /// <summary>
        /// Me calcula cuanto seria el pasaje de Fahrenheit a Kelvin.
        /// 
        /// Formula:
        /// K = (F + 459.67) * 5/9
        /// </summary>
        /// <returns></returns>
        public int FahrenheitAKelvin()
        {
            double resultadoKelvin = (this.valor - 32) * 5 / 9 + 273.15;
            return (int)resultadoKelvin;
        }
        #endregion

        #region SOBRECARGA
        public static explicit operator Kelvin(Fahrenheit f)
        {
            int numero = 0;
            if(f is not null)
            {
                numero = f.FahrenheitAKelvin();
            }
            Kelvin kelvAux = new Kelvin(numero);
            return kelvAux;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            int numero = 0;
            if (f is not null)
            {
                numero = f.FahrenheitACelsius();
            }
            Celsius celAux = new Celsius(numero);
            return celAux;
        }

        /// <summary>
        /// Compara si dos valores de Fahrenheit son iguales.
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns></returns>
        public static bool operator == (Fahrenheit f1,Fahrenheit f2)
        {
            bool sonIguales = false;
            if (f1 is not null && f2 is not null)
            {
                sonIguales = f1.valor == f2.valor;  
            }
            return sonIguales;
        }

        public static bool operator != (Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        /// <summary>
        /// La sobrecarga del operador + suma los dos valores que recibe
        /// por parametro si estos no son null.
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns></returns>
        public static int operator + (Fahrenheit f1, Fahrenheit f2)
        {
            int suma = 0;
            if (f1 is not null && f2 is not null)
            {
                suma = f1.valor + f2.valor;
            }
            return suma;
        }

        /// <summary>
        /// La sobrecarga del operador - resta los dos valores que recibe
        /// por parametro si estos no son null.
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns></returns>
        public static int operator - (Fahrenheit f1, Fahrenheit f2)
        {
            int resta = 0;
            if(f1 is not null && f2 is not null)
            {
                resta = f1.valor - f2.valor;    
            }
            return resta; 
        }
        #endregion
    }
}
