using MisExtensiones;

namespace EJERCICIO_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadenaTest = "Rocio.Bessio,23;09";
            int totalResult = cadenaTest.ExtensionContarPuntuaciones();//->Extiendo string

            Console.WriteLine($"La Primer Cadena: {cadenaTest}. Tiene {totalResult} signos de puntuacion");

            cadenaTest = "ROCIO;.,.,;;;;";//9 puntuaciones
            totalResult = cadenaTest.ExtensionContarPuntuaciones();
            Console.WriteLine($"La Segunda Cadena: {cadenaTest}. Tiene {totalResult} signos de puntuacion");
        }
    }
}