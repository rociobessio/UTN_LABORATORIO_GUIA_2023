using System;
using UNIDAD_02_ENTIDADES;

namespace EJERCICIO_I02
{
       /// <summary>
      ///                               Consigna
     /// Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
    ///  Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
    ///  El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra = 'A';
            int numero = 0;
            int acumulador = 0;

            do
            {
                Console.WriteLine("INGRESA UN NUMERO PARA SUMAR: ");
                numero = int.Parse(Console.ReadLine());
                acumulador += numero;

                Console.WriteLine("¿DESEA SEGUIR SUMANDO? S/N");
                letra = char.Parse(Console.ReadLine());

            } while (Validador.ValidarRespuesta(letra));

            Console.WriteLine($"LA SUMA ACUMULADA ES {acumulador}");
        }
    }
}