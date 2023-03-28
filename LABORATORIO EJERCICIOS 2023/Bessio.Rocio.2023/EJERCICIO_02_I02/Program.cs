namespace EJERCICIO_02_I02
{
    /*
     * Consigna:
     *  Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
     *  Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje:
     *  "ERROR. ¡Reingresar número!". 
     * 
     * IMPORTANTE
     *  Utilizar el método Pow de la clase Math para calcular las potencias.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            int cubo;
            int cuadrado;

            Console.WriteLine("INGRESA UN NÚMERO: ");
            numeroIngresado = int.Parse(Console.ReadLine());

            //Validacion que sea mayor a 0
            if (numeroIngresado <= 0)
            {
                Console.WriteLine("ERROR, REINGRESAR NÚMERO!");    
            }
            else
            {
                //El metodo Pow me permite hacer una potencia, el primer parametro es el numero, el segundo es la potecia a la cual voy a elevarlo.
                cuadrado = (int)Math.Pow(numeroIngresado,2);
                cubo = (int)Math.Pow(numeroIngresado,3);
                Console.WriteLine($"EL NÚMERO INGRESADO ES {numeroIngresado}, EL CUBO ES {cubo} y EL CUADRADO ES {cuadrado}");
            }
        }
    }
}