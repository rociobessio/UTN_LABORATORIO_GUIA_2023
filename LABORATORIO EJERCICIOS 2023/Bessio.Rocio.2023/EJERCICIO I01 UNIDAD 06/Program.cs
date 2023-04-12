namespace EJERCICIO_I01_UNIDAD_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerosArray =  new int[20];//Vector de tamaño 20
            Random numeroRandom = new Random();//Clase random.

            //Cargo el vector con numeros random
            for (int i = 0; i < numerosArray.Length; i++)//Recorro el tamaño del array
            {
                int numero = 0;
                numero  = numeroRandom.Next(-100,100);//Entre -100 y 100
                if (numero != 0)//Cualquier numero menos 0
                {
                    numerosArray[i] = numero;
                }
            }

            //1. Mostrar el vector tal como fue ingresado.
            Console.WriteLine("ARRAY DESORDENADO");
            for (int i = 0; i < numerosArray.Length; i++)//Recorro el array y lo imprimo en consola
            {
                Console.WriteLine($"   {numerosArray[i]}");
            }

            //2. Luego mostrar los positivos ordenados en forma decreciente.
            Console.WriteLine("POSITIVOS ORDENADOS EN FORMA DECRECIENTE");
            Array.Sort(numerosArray,Program.OrdenDescendente);
            for (int i = 0; i < numerosArray.Length; i++)
            { 
                if (numerosArray[i] > 0)
                {
                    Console.WriteLine($"{numerosArray[i]}");
                }
            }

            //3. Por último, mostrar los negativos ordenados en forma creciente.
            Console.WriteLine("NEGATIVOS ORDENADOS EN FORMA CRECIENTE");
            Array.Sort(numerosArray);//Los ordeno
            for (int i = 0; i < numerosArray.Length; i++)
            {
                if (numerosArray[i] < 0)//negativos
                {
                    Console.WriteLine($"{numerosArray[i]}");
                }
            }
        } 
        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }
    }
}