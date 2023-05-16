using UNIDAD_12_ENTIDADES___GENERICS;

namespace EJERCICIO_I02_UNIDAD_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recibo recibo1 = new Recibo();
            Factura factura1 = new Factura(123);
            Factura factura2 = new Factura(456);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad += recibo1;
            contabilidad += factura1;
            contabilidad += factura2;

            foreach (Documento item in contabilidad._listaEgresos)
            {
                Console.WriteLine(item.Numero);
            }
            foreach (Documento item in contabilidad._listaIngresos)
            {
                Console.WriteLine(item.Numero);
            }
        }
    }
}