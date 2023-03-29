using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_02_ENTIDADES
{

    public class Validador
    {
        /// <summary>
        /// EJERCICIO I01
        /// Me permite validar un numero en un rango numerico.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Devuelve true si el numero esta dentro del rango.</returns>
        public static bool Validar(int valor,int min,int max)
        {
            bool esValido = true;  
            if (valor <= min || valor >= max)
            {
                esValido = false;
            }
            return esValido;
        }

        /// <summary>
        /// El metodo estatico valida si el usuario ingreso S para seguir sumando
        /// </summary>
        /// <param name="letra"></param>
        /// <returns>Devuelve true si ingreso 'S', false si es cualquier otro valor</returns>
        public static bool ValidarRespuesta(char letra)
        {
            bool esValido = false;
            if (letra == 'S' || letra == 's')
            {
                esValido = true;
            }
            return esValido;    
        }
    }
}
