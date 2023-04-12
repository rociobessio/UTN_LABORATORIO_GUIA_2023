using UNIDAD_06_ENTIDADES;

namespace EJERCICIO_C01_UNIDAD_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creo instancias
            Equipo equipo = new Equipo(3,"ROPICLU");//cantJugadores, nombre
            Jugador jugador1 = new Jugador(11,"Jose",2,1);//Dni,nombre,goles,partidos
            Jugador jugador2 = new Jugador(11,"Esteban",0,10);
            Jugador jugador3 = new Jugador(22,"Marianela",5,3);
            Jugador jugador4 = new Jugador(33,"Luciana",2,6);
            Jugador jugador5 = new Jugador(44, "Lorenzo", 12, 6);

            //Uso las sobrecargas
            if (equipo + jugador1)//Agrega
            {
                Console.WriteLine(jugador1.MostrarDatos());
            }

            if (equipo + jugador2)//No puede porque son del mismo dni con jugador1
            {
                Console.WriteLine(jugador2.MostrarDatos());
            }
            else
                Console.WriteLine("NO AGREGO MISMO DNI");

            if (equipo + jugador3)//Agrega
            {
                Console.WriteLine(jugador3.MostrarDatos());
            }
            else
                Console.WriteLine("NO AGREGO MISMO DNI");

            if (equipo + jugador4)//Agrego
            {
                Console.WriteLine(jugador4.MostrarDatos());
            } 

            if (equipo + jugador5)//No puede porque no hay mas espacio en el equipo
            {
                Console.WriteLine(jugador5.MostrarDatos());
            }
            else
                Console.WriteLine("NO AGREGO NO HAY MAS ESPACIO EN EL EQUIPO.");
        }
    }
}