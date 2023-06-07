using System;
using System.Collections.Generic;
using static System.Environment;

namespace Consola
{
    class Program
    {
        public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);//-->Declaro mi delegado

        static void Main(string[] args)
        {
            // Borrar o agregar la primera barra para switchear entre las pruebas fijas y el ingreso de texto por consola. 
            //*
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            // Cant. caracteres: 89, Cant. palabras: 13, Cant. vocales: 35, Cant. signos puntuación: 2
            // Comparar(primerTexto,segundoTexto,);

            /*/
            Console.WriteLine("Ingrese el primer texto:");
            string primerTexto = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo texto:");
            string segundoTexto = Console.ReadLine();
            //*/


            //Usando el método Comparar, indicar cuál es el texto con más caracteres.
            //Sumistrar el argumento del tipo delegado usando una expresión lambda. 
            Console.WriteLine($"{NewLine}1era Comparación - Texto con más caracteres:");
            // Punto 2
            Comparar(primerTexto,segundoTexto, (n, a) => n.Length - a.Length);//-->Sumistrar el argumento del tipo delegado usando una expresión lambda.

            Console.WriteLine($"{NewLine}2da Comparación - Texto con más palabras:");
            // Punto 3
            Comparar(primerTexto, segundoTexto, (n, a) => n.Split(' ').Length - a.Split(' ').Length);
            
            Console.WriteLine($"{NewLine}3era Comparación - Texto con más vocales:");
            // Punto 4
            Comparar(primerTexto, segundoTexto, (n, a) => ContarVocales(n) - ContarVocales(a));

            Console.WriteLine($"{NewLine}4ta Comparación - Texto con más signos de puntuación:");
            // Punto 5
            Comparar(primerTexto, segundoTexto, (n, a) => ContarSignosPuntuacion(n) - ContarSignosPuntuacion(a));
        }

        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }

        /// <summary>
        /// Crear un método Comparar que reciba dos textos y un delegado.
        /// 
        /// El método Comparar invocará al delegado y en base a su resultado mostrará por consola si el primer
        /// texto es mayor, menor o igual al segundo.
        /// </summary>
        /// <param name="texto1"></param>
        /// <param name="texto2"></param>
        /// <param name="delegate"></param>
        public static void Comparar(string texto1,string texto2,DelegadoComparacion delegadoComparacion)
        {
            int result = delegadoComparacion(texto1,texto2);//Me devolvera un resultado

            if (result > 0)
            {
                Console.WriteLine($"El primer texto es MAYOR al segundo texto.");
            }
            else if(result < 0)
            {
                Console.WriteLine($"El segundo texto es MAYOR al primero texto.");
            }
            else
            {
                Console.WriteLine($"Los textos son iguales.");
            }

        }
    }
}
