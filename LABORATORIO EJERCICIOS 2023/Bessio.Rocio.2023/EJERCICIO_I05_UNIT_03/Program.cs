using UNIDAD_03_ENTIDADES;

namespace EJERCICIO_I05_UNIT_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> kilometrosConductor1 = new List<int>();
            kilometrosConductor1.Add(234);
            kilometrosConductor1.Add(990);
            kilometrosConductor1.Add(123);
            kilometrosConductor1.Add(543);
            kilometrosConductor1.Add(1344);
            kilometrosConductor1.Add(9813);
            kilometrosConductor1.Add(782);
            Conductores conductor1 = new Conductores(7,"Federico",kilometrosConductor1);

            List<int> kilometrosConductor2 = new List<int>();
            kilometrosConductor2.Add(1234);
            kilometrosConductor2.Add(9892);
            kilometrosConductor2.Add(1232); 
            Conductores conductor2 = new Conductores(3, "MARCOS", kilometrosConductor2);
            
            List<Conductores> condLista = new List<Conductores>();
            condLista.Add(conductor2);
            condLista.Add(conductor1);

            Conductores[] arrayConductors = condLista.ToArray(); 

            Empresa_Transporte empresa_Transporte = new Empresa_Transporte(arrayConductors);

            foreach (Conductores item in arrayConductors)
            {
                Console.WriteLine(item.Mostrar());
            }
            
        }
    }
}