using UNIDAD_03_ENTIDADES;

namespace EJERCICIO_AO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listkms1  = new List<int>();
            listkms1.Add(200);
            listkms1.Add(599);
            listkms1.Add(899);

            Conductores conductor1 = new Conductores(3,"Jose Mariano",listkms1);

            Console.WriteLine(conductor1.Mostrar());
        }
    }
}