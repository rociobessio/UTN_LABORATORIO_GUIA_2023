using UNIDAD_06_ENTIDADES;

namespace EJERCICIO_C02_UNIDAD_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(18,3);//Vueltas, competidores
            AutoF1 auto1 = new AutoF1(18,"Ferrari");
            AutoF1 auto2 = new AutoF1(22,"Red Bull");
            AutoF1 auto3 = new AutoF1(18, "Ferrari");//igual auto1 
            AutoF1 auto4 = new AutoF1(13, "McLaren");
            AutoF1 auto5 = new AutoF1(08, "Aston Martin"); 

            if (competencia + auto1)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }

            if (competencia + auto3)//No se deberia de mostrar es igual a autoF1
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }

            if (competencia + auto2)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }

            if (competencia + auto4)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }

            if (competencia + auto5)//No debe agregar no hay mas espacio
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
        }
    }
}