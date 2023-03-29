using UNIDAD_02_ENTIDADES;

namespace EXPLICACION
{
    internal class Program
    {
        /// <summary>
        ///                                     EJERCICIO I01
        /// 
        /// Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
        /// bool Validar(int valor, int min, int max)
        /// valor: dato a validar.
        /// min: mínimo valor incluido.
        /// max: máximo valor incluido.
        /// Pedir al usuario que ingrese 10 números enteros.Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
        /// Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
        /// 
        /// </summary>
        static void Main(string[] args)
        {
            #region ATRIBUTOS
            int numero = 0;
            int maximo = 0;
            int minimo = 0;
            int acumulador = 0;
            float promedio;
            #endregion

            //Console.WriteLine($"{Calculadora.contarNumeros()}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingresa el número {i}: ");
                //numeroIngresado[i] = int.Parse(Console.ReadLine());//ReadLine() devuelve string 
                numero = int.Parse(Console.ReadLine());//ReadLine() devuelve string 
                if (Validador.Validar(numero, -100, 100))
                {
                    //Acumulo 
                    acumulador += numero;

                    if (numero < minimo || i == 0)
                    {
                        minimo = numero;
                    }
                    else if (numero > maximo || i == 0)
                    {
                        maximo = numero;
                    }
                }
                else
                {
                    Console.WriteLine($"ERROR REINGRESE NUMERO");
                } 
            }

            //Casteo el acumulador ya que es int y los numeros ingresados tambien, y promedio es float
            promedio = (float)acumulador / 5;

            Console.WriteLine($"EL NÚMERO MAXIMO ES {maximo}, EL MINIMO ES {minimo} Y EL PROMEDIO ES {promedio}");

        }
    }
}