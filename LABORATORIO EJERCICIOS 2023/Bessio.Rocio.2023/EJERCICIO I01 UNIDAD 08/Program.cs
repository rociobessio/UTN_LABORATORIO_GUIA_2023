using UNIDAD_08_ENTIDADES;

namespace EJERCICIO_I01_UNIDAD_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(8,100,6,2,Color.Rojo);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------------CAMION------------- ");
            Console.WriteLine($"RUEDAS:{camion.cantidadRuedas} - PUERTAS: {camion.cantidadPuertas} - MARCHAS: {camion._cantidadMarchas}" +
                $" - COLOR: {camion.color} - PESO: {camion._pesoCarga}");
            Console.BackgroundColor = ConsoleColor.Blue;
            Moto moto = new Moto(3000,2,0,Color.Azul); 
            Console.WriteLine("-------------MOTO------------- ");
            Console.WriteLine($"RUEDAS:{moto.cantidadRuedas} - PUERTAS: {moto.cantidadPuertas} - CILINDRADAS: {moto._cilindrada}" +
                              $" - COLOR: {moto.color}");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Automovil auto = new Automovil(6,3,4,4,Color.Rojo);
            Console.WriteLine("-------------AUTO------------- ");
            Console.WriteLine($"RUEDAS:{auto.cantidadRuedas} - PUERTAS: {auto.cantidadPuertas} - PASAJEROS: {auto._cantidadPasajeros}" +
                              $" - COLOR: {moto.color} - MARCHAS: {auto._cantidadMarchas}");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}