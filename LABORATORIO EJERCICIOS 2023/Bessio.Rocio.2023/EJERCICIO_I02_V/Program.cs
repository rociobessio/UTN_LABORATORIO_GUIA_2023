using UNIDAD_03_ENTIDADES;

namespace EJERCICIO_I02_V
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Persona persona1 = new Persona("ROCIO BESSIO", "45013997", new DateTime(2003, 08, 13));
            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());

            Persona persona2 = new Persona("RENATA BESSIO", "520129312", new DateTime(2013, 08, 13));
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());

            Persona persona3 = new Persona("ESTEBAN BESSIO", "70000", new DateTime(1937, 08, 13));
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());
        }
    }
}