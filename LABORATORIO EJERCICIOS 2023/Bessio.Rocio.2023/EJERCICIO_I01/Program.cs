
using UNIDAD_03_ENTIDADES;

/*                                  CONSIGNA
 * En el método Main, simular depósitos y extracciones de dinero de la cuenta, 
 * e ir mostrando como va variando el saldo.
*/
namespace EJERCICIO_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("MARTIN RODRIGUEZ",8910);

            Console.WriteLine("DATOS DE LA CUENTA: ");
            Console.WriteLine(cuenta1.Mostrar());

            //Si es negativo no aparece nada
            if (!cuenta1.Ingresar(-1000))
                Console.WriteLine("NO SE PUDO AGREGAR NADA DEBIDO A QUE ES MONTON NEGATIVO EL INGRESADO");

            cuenta1.Ingresar(20000);
            Console.WriteLine(cuenta1.Mostrar());

            Console.WriteLine("MONTO A RETIRAR ES 200");
            cuenta1.Retirar(200);
            Console.WriteLine(cuenta1.Mostrar());
        }
    }
}