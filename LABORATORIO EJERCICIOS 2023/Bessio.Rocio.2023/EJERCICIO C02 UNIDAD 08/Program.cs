using UNIDAD_08_ENTIDADES;

namespace EJERCICIO_C02_UNIDAD_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Competencia competenciaFormula1 = new Competencia(21,22,TipoCompetencia.F1);//Vueltas, competidores
            AutoF1 auto1 = new AutoF1(18, "Ferrari",9000);
            AutoF1 auto2 = new AutoF1(22, "Red Bull",1299);
            AutoF1 auto3 = new AutoF1(18, "Ferrari",8090);//igual auto1 
            AutoF1 auto4 = new AutoF1(13, "McLaren",5432);
            AutoF1 auto5 = new AutoF1(08, "Aston Martin",1892);
            MotoCross moto = new MotoCross(09,"Audi");

            try
            {

                if (competenciaFormula1 + auto1)
                {
                    Console.WriteLine(competenciaFormula1.MostrarDatos());
                }

                if (competenciaFormula1 + auto3)//No se deberia de mostrar es igual a autoF1
                {
                    Console.WriteLine(competenciaFormula1.MostrarDatos());
                }

                if (competenciaFormula1 + auto2)
                {
                    Console.WriteLine(competenciaFormula1.MostrarDatos());
                }

                if (competenciaFormula1 + moto)
                {
                    Console.WriteLine(competenciaFormula1.MostrarDatos());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //if (competenciaFormula1 + auto4)
            //{
            //    Console.WriteLine(competenciaFormula1.MostrarDatos());
            //} 

            //if (competenciaFormula1 + auto5)//No debe agregar no hay mas espacio
            //{
            //    Console.WriteLine(competenciaFormula1.MostrarDatos());
            //} 
            Console.BackgroundColor = ConsoleColor.DarkBlue;   
            Competencia competenciaMotoCross = new Competencia(21, 22, TipoCompetencia.MotoCross);//Vueltas, competidores
            MotoCross moto1 = new MotoCross(18, "Ferrari MOTO", 9000);
            MotoCross moto2 = new MotoCross(22, "Red Bull MOTO", 1299);
            MotoCross moto3 = new MotoCross(18, "Ferrari MOTO", 8090);//igual auto1 
            MotoCross moto4 = new MotoCross(13, "McLaren MOTO", 5432);
            MotoCross moto5 = new MotoCross(08, "Aston Martin MOTO", 1892);

            if (competenciaMotoCross + moto1)
            {
                Console.WriteLine(competenciaMotoCross.MostrarDatos());
            }

            if (competenciaMotoCross + moto3)//No se deberia de mostrar es igual a autoF1
            {
                Console.WriteLine(competenciaMotoCross.MostrarDatos());
            }

            if (competenciaMotoCross + moto2)
            {
                Console.WriteLine(competenciaMotoCross.MostrarDatos());
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}