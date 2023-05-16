using UNIDAD_12_ENTIDADES___GENERICS;

namespace EJERCICIO_I01_UNIDAD_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<Equipo> torneo = new Torneo<Equipo>("NBA");
            EquipoBasket equipo1 = new EquipoBasket("LAKERS", DateTime.Now);
            EquipoBasket equipo2 = new EquipoBasket("CELTICS", DateTime.Now);

            _ = torneo + equipo1;
            _ = torneo + equipo2;

            Console.WriteLine(torneo.Mostrar());
        }
    }
}