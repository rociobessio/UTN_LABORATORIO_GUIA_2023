using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_11_ENTIDADES_UNIT_TEST
{
    public static class StringExtension
    {
        /// <summary>
        /// El this representa que es un metodo de extension
        /// en este caso de la clase string, solo con metodos
        /// estaticos.
        /// me permite llamar al metodo como si fuese un metodo
        /// de instancia y el this es el tipo que puede extender
        /// instanciarlo.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int ContarVocales(this string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            text = text.ToLower();

            char[] vocales = { 'a','e','i','o','u'};

            int contador = 0;

            foreach (char caracter in text)
            {
                if (vocales.Contains(caracter))
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
