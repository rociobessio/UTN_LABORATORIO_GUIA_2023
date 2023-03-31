using System.Runtime.Intrinsics.X86;
using UNIDAD_03;
using UNIDAD_03_ENTIDADES;

namespace EJERICICIO_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafo1 = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50,ConsoleColor.Red); 
            string gasto = "";
            bool ok;

            ok = boligrafo2.Pintar(70, out gasto);//Pintar reotrna si pudo pintar
            Console.ForegroundColor = boligrafo2.GetColor;
            Console.WriteLine($"PUDO DIBUJAR? {ok}\nDIBUJO: {gasto}");
            Console.ResetColor();
            Console.WriteLine($"{boligrafo2.GetTinta}");
        }
    }
}