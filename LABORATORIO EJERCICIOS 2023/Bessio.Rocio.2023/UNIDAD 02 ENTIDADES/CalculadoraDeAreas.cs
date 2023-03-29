using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_02_ENTIDADES
{
    public class CalculadoraDeAreas
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo(double baseA, double altura) 
        {
            return (altura * baseA) / 2;
        }

        public static double CalcularAreaCirculo(double radio) 
        { 
            return Math.PI * radio;
        }
    }
}
