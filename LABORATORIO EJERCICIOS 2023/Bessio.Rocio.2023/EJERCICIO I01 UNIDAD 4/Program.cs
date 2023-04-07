using UNIDAD_04_ENTIDADES;

namespace EJERCICIO_I01_UNIDAD_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sobrecarga de constructores
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador(2);//Cantidad de sumas 2


            //Sobrecarga de Metodos
            string retornoString = sumador.Sumar("ROCIO","BESSIO");//Invoco al metodo para sumar las strings
            long retornoLong = sumador.Sumar(123,123);

            Console.Write("RETORNO DE Sumador(string, string): ");
            Console.Write(retornoString);

            //El {Enviroment.NewLine} es parecido a usar Writeline o AppendLine, solo q este
            //Se fija en que sistema esta y coloca un barra n 
            Console.Write($"{Environment.NewLine}RETORNO DE Sumador(long, long): "); 
            Console.WriteLine(retornoLong.ToString());

            //Operador + sobrecarga
            Console.WriteLine($"SUMA DE LA CANTIDAD DE SUMAS DE CADA OBJETO = {sumador + sumador2}");

            //Operador | sobrecarga
            if (sumador | sumador2)//Si retorna true, cuentan con la misma cantidad d sumas
            {
                Console.WriteLine("CUENTAN CON LA MISMA CANTIDAD DE SUMAS");
            }

            Sumador sumador3 = new Sumador();//Cantidad de sumas 2
            if (sumador | sumador3)//Si retorna true, cuentan con la misma cantidad d sumas
            {
                Console.WriteLine("CUENTAN CON LA MISMA CANTIDAD DE SUMAS");
            }
            else
                Console.WriteLine("NO CUENTAN CON LA MISMA CANTIDAD DE SUMAS");
        }
    }
}