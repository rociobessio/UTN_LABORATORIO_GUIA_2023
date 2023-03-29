
/*
                                          Consigna
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
*/
using UNIDAD_02_ENTIDADES;

namespace EJERCICIO_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0; 
            string operacion = "";

            Console.WriteLine("INGRESE EL PRIMER NUMERO: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NUMERO: ");
            numero2 = int.Parse(Console.ReadLine());


            Console.WriteLine("INGRESE LA OPERACION QUE DESEA REALIZAR (+,-,/,*): ");
            operacion = Console.ReadLine();

            Console.WriteLine($"RESULTADO {Calculadora.Calcular(numero1, numero2, operacion)}");
        }
    }
}