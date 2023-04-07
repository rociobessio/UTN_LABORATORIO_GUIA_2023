using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_04__SOBRECARGA_
{
    public class NumeroDecimal
    {
        #region ATRIBUTO
        public double numero;
        #endregion

        #region PROPIEDAD
        public double GetNumero { get { return this.numero; } }
        #endregion

        #region CONSTRUCTOR
        private NumeroDecimal(double numero)
        {
            this.numero = numero;       
        }
        #endregion

        #region METODO
        public string DecimalABinario(double numero)
        {
            string valorBinario = string.Empty;
            int resultadoDivision = (int)numero;//Casteo explicitamente de double a int
            int restoDivisio;

            if (resultadoDivision >= 0)
            {
                do
                {
                    restoDivisio = resultadoDivision % 2;
                    resultadoDivision /= 2;
                    valorBinario = restoDivisio.ToString() + valorBinario;
                } while (resultadoDivision > 0);
            }
            return valorBinario;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Me devuelve una nueva instancia de la clase NumeroDecimal
        /// pasandole el double que recibo y asignandoselo.
        /// </summary>
        /// <param name="numero"></param>
        public static explicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        /// <summary>
        /// El operador explicito, devuelve 
        /// </summary>
        /// <param name="numeroDecimal"></param>
        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)numeroDecimal.DecimalABinario(numeroDecimal.numero);
        }
        public static double operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero + ((NumeroDecimal)numeroBinario).numero;
        }
        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero - ((NumeroDecimal)numeroBinario).numero;
        }


        #endregion
    }
}
