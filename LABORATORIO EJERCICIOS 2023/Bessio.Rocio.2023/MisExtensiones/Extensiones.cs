using System.Runtime.CompilerServices;

namespace MisExtensiones
{
    public static  class Extensiones
    {
        /// <summary>
        /// crear un método de extensión para la clase string que cuente la cantidad de signos de 
        /// puntuación punto (.), coma (,) y punto y coma (;) dentro de una cadena.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ExtensionContarPuntuaciones( this string str)
        {
            int cantidadTotal = 0;

            for (int i = 0;i < str.Length;i++)
            {
                if (str[i] == '.' || str[i] == ',' || str[i] == ';')
                {
                    cantidadTotal++;
                }
            }
            return cantidadTotal;
        }

        /// <summary>
        /// Se llamará ContarCantidadDeDigitos y retornará la cantidad de dígitos que forman un número.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int ExtensionContarCantidadDeDigitos(this Int64 num)
        {
            int cantidadTotal = 0;
            string str = num.ToString();//-->Lo transformo a string

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != null)//-->Mientras no sea null
                {
                    cantidadTotal++;
                }
            }
            return cantidadTotal;
        }

        /// <summary>
        /// Extender la clase Int32 con el método FizzBuzz
        /// 
        /// Reemplazar cualquier número divisible por tres con la palabra “Fizz” y
        /// cualquier número divisible por cinco con la palabra “Buzz”. 
        /// 
        /// Cualquier número divisible por ambos debe reemplazarse por "Fizz Buzz".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string ExtensionFizzBuzz(this Int32 numero)
        {
            string retorno = string.Empty;

            if (numero % 3 == 0)//-->Si es divisible por 3
            {
                retorno = "Fizz";
            } 
            
            if (numero % 5 == 0)
            {
                retorno = "Buzz";
            }
            
            if ((numero % 3 == 0) && (numero % 5 == 0))
            {
                retorno = "Fizz Buzz";
            }

            return retorno;
        }
    }
}