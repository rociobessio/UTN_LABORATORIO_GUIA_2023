using MisExtensiones;

namespace EJERCICIO_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int64 numero = 189;
            int totalResult = numero.ExtensionContarCantidadDeDigitos();//->Extiendo string

            Console.WriteLine($"El número es: {numero} y la cantidad de digitos es de {totalResult}.");
        }
    }
}