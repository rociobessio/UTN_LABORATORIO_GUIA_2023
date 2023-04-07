using UNIDAD_04__SOBRECARGA_;
using UNIDAD_04_ENTIDADES;

namespace EJERCICIO_C01_UNIDAD_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONVERSIONES IMPLICITAS:
            NumeroBinario objBinario = (NumeroBinario)"1001";
            NumeroDecimal objDecimal = (NumeroDecimal)9;


            //Console.WriteLine($"El numero binario es {objBinario.numero}, sumado con el decimal de un total de {objDecimal + objBinario}");
            //Console.WriteLine($"El numero decimal es {objDecimal.numero}, sumado con el binario de un total de {objBinario + objDecimal}");

        }
    }
}