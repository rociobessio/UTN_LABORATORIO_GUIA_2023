using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_03
{
    public class Estudiante
    {
        #region ATRIBUTOS
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        #endregion

        #region PROPIEDADES
        public int SetNotaPrimerParcial { set { this.notaPrimerParcial = value; } }
        public int SetNotaSegundoParcial { set { this.notaSegundoParcial = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor estatico inicializa atributo random.
        /// </summary>
        static Estudiante()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor de instacia que me inicializa los atributos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="legajo"></param>
        public Estudiante(string nombre,string apellido,string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El método privado CalcularPromedio retornará el promedio de las dos notas.
        /// Se podria validar que las notas no sean negaticas. Pero no lo pide.
        /// </summary>
        /// <returns></returns>
        private float CalcularPromedio()
        {
            return ((float)this.notaPrimerParcial + this.notaSegundoParcial)/2;
        }

        /// <summary>
        /// El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4,
        /// caso contrario la inicializará con el valor -1.
        /// </summary>
        /// <returns></returns>
        public double CalcularNotaFinal()
        {
            double notaFinal;
            if (this.notaSegundoParcial>=4 && this.notaPrimerParcial>=4)
            {
                notaFinal = random.Next(6, 10);//Calculo un num random entre 6 y 10 con el metodo Next de la clase Random
            }
            else
            {
                notaFinal = -1;
            }
            return notaFinal;
        }

        /// <summary>
        /// El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            float promedio = this.CalcularPromedio();
            double final = this.CalcularNotaFinal();    
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {this.nombre} - APELLIDO: {this.apellido} - LEGAJO: {this.legajo}");
            sb.AppendLine($"NOTA PRIMER PARCIAL: {this.notaPrimerParcial} - NOTA SEGUNDO PARCIAL: {this.notaSegundoParcial}");
            sb.AppendLine($"PROMEDIO: {promedio}");
            sb.AppendLine($"NOTA FINAL: ");
            if (final == -1)
                sb.AppendLine($"ALUMNO DESAPROBADO.");
            else
                sb.AppendLine($"{final}");

            return sb.ToString();   
        }
        #endregion

    }
}
