namespace UNIDAD_11_ENTIDADES_UNIT_TEST
{
    public class Calculadora
    {

        public double Dividir(double divisor,double dividendo)
        {
            if (divisor == 0)
            { 
                return double.MinValue;
            }

            return dividendo / divisor;
        }
    }
}