using System.Xml;
using UNIDAD_02_ENTIDADES;

/*
                                Consigna
Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/

namespace EJERCICIO_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double resultado = 0;
            double longitud = 0;
            double baseA = 0;
            double altura = 0;
            double radio = 0;

            Console.WriteLine("CALCULAR AREA RECTANGULO (1), CALCULAR AREA TRIANGULO (2), CALCULAR AREA CIRCULO (3)");
            int.TryParse(Console.ReadLine(),out opcion);
            if (opcion == 1)
            { 
                Console.WriteLine("INGRESE EL NUMERO A CALCULAR: ");
                double.TryParse(Console.ReadLine(), out longitud);

                resultado = CalculadoraDeAreas.CalcularAreaCuadrado(longitud);

                Console.WriteLine($"AREA DEL RECTANGULO {resultado}");
            }
            else if (opcion == 2)
            {

                Console.WriteLine("INGRESE LA BASE DEL TRIANGULO: ");
                double.TryParse(Console.ReadLine(), out baseA);
                Console.WriteLine("INGRESE LA ALTURA: ");
                double.TryParse(Console.ReadLine(), out altura);

                resultado = CalculadoraDeAreas.CalcularAreaTriangulo(baseA,altura);

                Console.WriteLine($"AREA DEL TRIANGULO {resultado}");
            }
            else if (opcion == 3)
            {

                Console.WriteLine("INGRESE EL RADIO DEL CIRCULO: ");
                double.TryParse(Console.ReadLine(), out radio); 

                resultado = CalculadoraDeAreas.CalcularAreaCirculo(radio);

                Console.WriteLine($"AREA DEL CIRCULO {resultado}");
            }

        }
    }
}