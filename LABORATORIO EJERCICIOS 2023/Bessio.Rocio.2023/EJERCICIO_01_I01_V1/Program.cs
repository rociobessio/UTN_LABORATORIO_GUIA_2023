using System.Diagnostics;

namespace EJERCICIO_01_I01_V1
{
    /*
     * CONSIGNA:
     * Ingresar 5 números por consola, guardándolos en una variable escalar.
     * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
     * 
     * IMPORTANTE:
     * Un escalar es una constante o variable que contiene un dato atómico y unidimensional.
     * En contraposición al concepto de escalar, están los conceptos de array, lista y objeto,
     * que pueden tener almacenado en su estructura más de un valor.​
     */ 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ATRIBUTOS
            int numero  = 0;
            int maximo = 0;
            int minimo = 0;
            float promedio;
            int acumulador = 0;
            #endregion

            for (int i = 0;i<5;i++)
            {
                Console.WriteLine($"Ingresa el número {i}: ");
                //numeroIngresado[i] = int.Parse(Console.ReadLine());//ReadLine() devuelve string 
                numero = int.Parse(Console.ReadLine());//ReadLine() devuelve string 

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

            //Casteo el acumulador ya que es int y los numeros ingresados tambien, y promedio es float
            promedio = (float)acumulador / 5;

            Console.WriteLine($"EL NÚMERO MAXIMO ES {maximo}, EL MINIMO ES {minimo} Y EL PROMEDIO ES {promedio}");

            //Console.WriteLine("Hello, World!");
        }
    }
}