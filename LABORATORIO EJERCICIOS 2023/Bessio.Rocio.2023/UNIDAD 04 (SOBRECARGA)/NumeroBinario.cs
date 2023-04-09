using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_04__SOBRECARGA_
{
    public class NumeroBinario
    {
        #region ATRIBUTO
        public string numero;
        #endregion

        #region PROPIEDADES
        public string GetNumero { get { return this.numero; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Único constructor privado (recibe un parámetro de tipo string).
        /// </summary>
        /// <param name="cadena"></param>
        private NumeroBinario(string cadena)
        {
            this.numero = cadena;
        }
        #endregion

        #region METODO 
        public double BinarioADecimal(string valor)
        {
            double resultado = 0;
            int cantCaracteres = valor.Length;//Guardo la longitud de la cadena.
            foreach (char caracter in valor)//Recorro la string
            {
                cantCaracteres--;//por cada vuelta lo resto
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantCaracteres);//resultado se le va sumando el cubo de la cantidad de caracteres
                }
            }
            return resultado;
        }
        #endregion

        #region SOBRECARGA
        /// <summary>
        /// Operador explicito, recibo un string
        /// y retorno una instancia de la clase NumeroBinario.
        /// </summary>
        /// <param name="numero"></param>
        public static explicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator NumeroDecimal(NumeroBinario nummeroBinario)
        {
            return (NumeroDecimal)nummeroBinario.BinarioADecimal(nummeroBinario.numero);
        }

        /// <summary>
        /// Comparo el atributo numero d numero binario, casteo explicitamente
        /// al numero decimal y cito al atributo para compararlos.
        /// </summary>
        /// <param name="numeroBinario"></param>
        /// <param name="numeroDecimal"></param>
        /// <returns></returns>
        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario.numero == ((NumeroBinario)numeroDecimal).numero;
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }

        /// <summary>
        /// El operador + suma el binario (Decimal a binario) y el numero decimal
        /// Con el numeroDecimal llamo al metodo DecimalABinario, con el casteo exolicito
        /// lo que hago es pasar el binario a decimal y luego sumo los numeros.
        /// </summary>
        /// <param name="numeroDecimal"></param>
        /// <param name="numeroBinario"></param>
        /// <returns></returns>
        public static string operator + (NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.DecimalABinario(((NumeroDecimal)numeroBinario).numero + numeroDecimal.numero);
        }

        /// <summary>
        /// Resta el numero 
        /// </summary>
        /// <param name="numeroBinario"></param>
        /// <param name="numeroDecimal"></param>
        /// <returns></returns>
        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.DecimalABinario(((NumeroDecimal)numeroBinario).numero - numeroDecimal.numero);
        }
        #endregion

    }
}
