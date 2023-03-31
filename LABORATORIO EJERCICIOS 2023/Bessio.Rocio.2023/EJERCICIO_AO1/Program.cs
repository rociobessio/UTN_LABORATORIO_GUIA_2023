using UNIDAD_03;

namespace EJERCICIO_AO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conductores conductor1 = new Conductores(3,"Jose Mariano",new double[100]);

            Console.WriteLine(conductor1.Mostrar());
        }
    }
}