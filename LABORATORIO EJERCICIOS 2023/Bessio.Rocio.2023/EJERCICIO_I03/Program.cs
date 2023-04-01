using UNIDAD_03_ENTIDADES;

namespace EJERCICIO_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("MARIA","ESTEVANEZ", "113211");
            estudiante1.SetNotaPrimerParcial = 9;
            estudiante1.SetNotaSegundoParcial = 8;

            Estudiante estudiante2 = new Estudiante("JOSE", "VALIENTE", "9032123");
            estudiante2.SetNotaPrimerParcial = 4;
            estudiante2.SetNotaSegundoParcial = 2;
            
            Estudiante estudiante3 = new Estudiante("PAULO", "RODRIGUEZ", "65321");
            estudiante3.SetNotaPrimerParcial = 10;
            estudiante3.SetNotaSegundoParcial = 9;


            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}