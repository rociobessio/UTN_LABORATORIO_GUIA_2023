using UNIDAD_07_ENTIDADES;

namespace EJERCICIO_I02_UNIDAD_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancio Libro
            Console.BackgroundColor = ConsoleColor.Blue;
            Libro libro = new Libro();
            Console.WriteLine("|---------INDICE---------|");
            libro[0] = "|   Jorge Luis Borges    |";//En el indice 0, nombre del libro
            libro[1] = "|   Alejandra Pizarnik   |";
            for (int i = 0; i < 2; i++)//2 = Tengo 2 paginas.
            {
                Console.WriteLine(libro[i]);//Imprimo la string
            }
            Console.WriteLine("|------------------------|");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("CAMBIO EL INDICE POR OTRO TITULO");
            Console.WriteLine();
            Console.WriteLine("|---------INDICE---------|");
            //Cambio el titulo de un indice si el indice existe
            libro[1] = "|   Silvia Plath         |";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
            Console.WriteLine("|------------------------|");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}