using System.Data.SqlTypes;

namespace UNIDAD_04_ENTIDADES
{
    public class Sumador
    {
        #region ATRIBUTOS
        private int cantidadSumas;
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// El constructor parametrizado inicializa cantidadSumas
        /// en el valor recibido por parametro.
        /// </summary>
        /// <param name="cantidadSumas"></param>
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        /// <summary>
        /// Inicializa cantidadSumas en 0,  e invoca
        /// al constructor parametrizado, por eso es this(0) le paso 0 como valor
        /// </summary>
        public Sumador()
            : this(0)
        { }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Generar una conversión explícita que retorne cantidadSumas.
        /// -> Las conversiones explícitas requieren una expresión de conversión (tipo).
        /// </summary>
        /// <param name="s"></param>
        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;//Mediante lo que recibo, retorno cantidad sumas,justamente un int
        }

        /// <summary>
        /// La sobrecarga del operador + retornara un long
        /// correspondiente al resultado de la suma del atributo
        /// de cada argumento recibido por parametro.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }

        /// <summary>
        /// La sobrecarga del operador | (pipe), debera retornar TRUE 
        /// si ambos sumadores tienen igual valor en el atributo
        /// cantidad sumas.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            bool sonIguales = false;
            if (sumador1.cantidadSumas == sumador2.cantidadSumas)
                sonIguales = true;
            return sonIguales;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El método Sumar incrementará cantidadSumas en 1 
        /// y adicionará sus parámetros con la siguiente lógica:
        /// En el caso de Sumar(long, long) sumará los valores numéricos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public long Sumar(long a, long b)
        {
            this.cantidadSumas += 1;//Adhiciono 1.
            return a + b;//Retornara la suma de los valores numericos.
        }

        /// <summary>
        /// El método Sumar incrementará cantidadSumas en 1
        /// y adicionará sus parámetros con la siguiente lógica:
        /// En el de Sumar(string, string) concatenará las cadenas de texto.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Sumar(string a, string b)
        {
            this.cantidadSumas += 1;//Sumo 1
            return $"{a} {b}";//a la string le adhiero las dos strings recibidas
        }
        #endregion

    }
}