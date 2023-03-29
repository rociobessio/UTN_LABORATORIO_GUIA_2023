using UNIDAD_02_ENTIDADES; 
/*
                                           Consigna
Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

Mostrar el resultado en la consola.
*/
namespace EJERCICIO_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseA = 0;
            double altura = 0;

            Console.WriteLine("INGRESA LA BASE: ");
            double.TryParse(Console.ReadLine(),out baseA);
            Console.WriteLine("INGRESA LA ALTURA");
            double.TryParse(Console.ReadLine(), out altura);

            Console.WriteLine($"EL RESULTADO DEL TEOREMA DE PITAGORAS ES {Calculadora.TeoremaPitagoras(baseA, altura)}");
        }
    }
}