namespace EJERCICIO_04_I04
{
/*
 *                     UN NUMERO PERFECTO  
 * CONSIGNA:
            Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
            (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.

 * IMPORTANTE:
            Utilizar sentencias de iteración y selectivas. 
 */
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int i = 2;

            //Escribir una aplicación que encuentre los 4 primeros números perfectos.
            Console.WriteLine("LOS PRIMEROS 4 NUMEROS PERFECTOS SON: ");
           
            while(contador != 4)//los primeros 4 numeros
            {
                int numero = 0;
                for (int k = 1; k < i; k++)
                {
                    if (i % k == 0)//Busco el numero perfecto
                    {
                        numero += k;
                    }
                }

                if (i == numero)//Sí i coincide con el numero, entonces es un numero perfecto
                {
                    //Imprimo en pantalla: (tiene que imprimir 6,28,496 y 8128)
                    Console.WriteLine(i);
                    contador++;
                }
                i++;
            }
        
        }
    }
}