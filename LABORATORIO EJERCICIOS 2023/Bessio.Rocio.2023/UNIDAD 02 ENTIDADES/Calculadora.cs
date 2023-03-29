using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace UNIDAD_02_ENTIDADES
{
    /// <summary>
    /// ctrl + r + r = cambiar varios nombres de atributos
    /// - Se puede guardar solamente metodos estaticos
    /// </summary>
    public static class Calculadora
    {
        #region ATRIBUTOS ESTATICOS
        private static int primerNumero;
        private static int segundoNumero;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor por defecto, me inicializa los atributos.
        /// </summary>
        static Calculadora()
        {
            Calculadora.primerNumero = 0;   
            Calculadora.segundoNumero = 0;  
        }
        #endregion

        #region METODOS ESTATICOS
        /// <summary>
        /// Visibiladores:
        /// public -> se ve desde cualquier parte del proyecto.
        /// internal -> se ve solamente dentro del proyecto.
        /// private -> se ve solamente desde la clase.
        /// 
        /// Metodo estatico que me retorna un entero (2).
        /// </summary>
        /// <returns></returns>
        public static int contarNumeros()
        {
            return 2;   
        }

        /// <summary>
        /// Dependiendo la operacion q elija el usuario se realizara la operacion matematica.
        /// </summary>
        /// <param name="operando1"></param>
        /// <param name="operando2"></param>
        /// <param name="operacion"></param>
        /// <returns></returns>
        public static int Calcular(int operando1,int operando2, string operacion)
        {
            int resultado  = 0;
            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }
            else if (operacion == "*")
            {
                resultado = operando1 * operando2;
            }
            else if(operacion == "/")
            {
                if (Calculadora.Validar(operando2))
                {
                    resultado = operando2 / operando1;
                }
                else
                {
                    resultado = 0;
                }
            } 

            return resultado;
        }

        /// <summary>
        /// Recibirá como parámetro el segundo operando. 
        /// Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
        /// </summary>
        /// <param name="operando2"></param>
        /// <returns>Este método devolverá true si el operando es distinto de cero.</returns>
        private static bool Validar(int operando2)
        {
            return operando2 != 0;
        }

        /// <summary>
        /// EJERCICIO I05
        /// Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string ImprimirTabla(int numero)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= 10; i++)
            {
                sb.AppendLine($"{i} x {numero} = {i*numero}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// EJERCICIO I07
        /// El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y
        /// Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos
        /// </summary>
        /// <returns></returns>
        public static double TeoremaPitagoras(double baseA, double altura)
        {
            double auxBase = Math.Pow(baseA,2);
            double auxAlt = Math.Pow(altura,2);
            double suma = auxBase + auxAlt;
            return Math.Sqrt(suma);//retorna la raiz cuadrada de un numero
        }
        #endregion
    }
}