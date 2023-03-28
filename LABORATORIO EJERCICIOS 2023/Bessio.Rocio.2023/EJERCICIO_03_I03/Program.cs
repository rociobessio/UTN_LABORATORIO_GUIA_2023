namespace EJERCICIO_03_I03
{
/*
 *                                              LOS PRIMOS
 * CONSIGNA:
            Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cerrar la consola.
            Al finalizar, preguntar al usuario si desea volver a operar. 
            Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
 * 
 * IMPORTANTE:
            Utilizar sentencias de iteración y selectivas.
 */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ATRIBUTOS
            int numero = 0;
            string userInput;
            int opcion;
            #endregion

            Console.WriteLine("INGRESE UN NÚMERO O ESCRIBA 'SALIR': ");
            userInput = Console.ReadLine();//Por si ingresa string

            //Si no escribe salir, con el TryParse() el primer parametro es la string y lo parse y lo guarda en numero
            while (userInput != "SALIR" && !(int.TryParse(userInput,out numero)))
            {
                Console.WriteLine("VALOR INVALIDO REINGRESE!");//Validar que el dato ingresado por el usuario sea un número.
                userInput = Console.ReadLine();//Tomo lo que ingresa
            }

            //Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            for (int i = 1; i<= numero;i++)
            {
                int contador = 0;
                for (int j = 1; j <= i;j++)
                {
                    if (i % j == 0)//Compruebo si es un numero primo
                    {
                        contador++;
                    }
                }

                //Imprimo los numeros primos 
                if (contador <= 2)
                {
                    Console.WriteLine(i);
                }
            }

            //Al finalizar le pregunto al usuario si desea seguir
            Console.WriteLine("¿DESEA SEGUIR ITERANDO? [1.Si ó 2.No]");
            while (!(int.TryParse(Console.ReadLine(),out opcion)) || (opcion != 1 && opcion !=2))
            {
                Console.WriteLine("VALOR INVALIDO REINGRESE 1 o 2!");
            }

            //Si la respuesta es afirmartiva (1) sigue iterando, instancio nuevamente al main
            if (opcion == 1)
            {
                Main(args);
            }
        }
    }
}