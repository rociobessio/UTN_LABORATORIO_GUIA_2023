using UNIDAD_02_ENTIDADES;

/*
                                            Consigna
    Crear una aplicación de consola que permita al usuario ingresar un número entero.

    Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

    Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

    Mostrar en la consola el resultado.
*/
 
namespace EJERCICIO_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("INGRESE UN NUMERO: ");
            int.TryParse(Console.ReadLine(),out numero);

            Console.WriteLine("TABLA DE MULTIPLICAR:");
            Console.WriteLine(Calculadora.ImprimirTabla(numero));
        }
    }
}