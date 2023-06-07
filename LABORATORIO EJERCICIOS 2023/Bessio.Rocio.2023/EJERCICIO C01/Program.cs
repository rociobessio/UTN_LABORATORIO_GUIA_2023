using MisExtensiones;

namespace EJERCICIO_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-->Debe de imprimir solo Fizz
            Int32 numero = 3;
            string retorno = numero.ExtensionFizzBuzz();
            Console.WriteLine(retorno);

            //-->Debe de imprimir Buzz
            numero = 5;
            retorno = numero.ExtensionFizzBuzz();
            Console.WriteLine(retorno);

            //-->Debe imprimir FizzBuzz
            numero = 15;
            retorno = numero.ExtensionFizzBuzz();   
            Console.WriteLine(retorno);
        }
    }
}