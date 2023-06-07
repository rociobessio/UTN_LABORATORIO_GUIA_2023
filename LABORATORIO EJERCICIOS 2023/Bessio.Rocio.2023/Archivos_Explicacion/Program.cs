using ENTIDADES_ARCHIVOS;

namespace Archivos_Explicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Archivo_Explicacion.Leer());
             
            Archivo_Explicacion.Escribir(); 
        }
    }
}