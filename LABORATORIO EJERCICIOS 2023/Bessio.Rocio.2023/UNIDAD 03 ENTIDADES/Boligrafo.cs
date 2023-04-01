using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_03_ENTIDADES
{
    public class Boligrafo
    {
        #region ATRIBUTOS
        const short cantidaTintaMaxima = 100;//La cantidad máxima de tinta para todos los bolígrafos será de 100
        private ConsoleColor color;
        private short tinta;
        #endregion

        #region PROPIEDADES
        public ConsoleColor GetColor { get { return this.color; } }
        public short GetTinta { get { return this.tinta; } }
        #endregion

        #region CONSTRUCTOR
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El argumento tinta contedrá la cantidad de tinta a agregar o quitar. 
        /// Podrá ser positivo (cargar tinta) o negativo (gastar tinta).
        /// Se deberá validar que el nivel de tinta resultante sea mayor o igual a cero y menor
        /// o igual a cantidadTintaMaxima.Si no es válido, no se deberá modificar el atributo ni realizar ninguna acción.
        /// </summary>
        /// <param name="tinta"></param>
        private void SetTinta(short tinta)
        {
            int resultado;
            if (tinta <= 0)
            {
                short resto = Convert.ToInt16(tinta * -1);
                resultado = this.tinta - resto;
                if (resultado >= 0 && resultado < cantidaTintaMaxima)
                {
                    this.tinta -= resto;
                }
            }
            else
            {
                this.tinta = tinta;
            }
        }

        /// <summary>
        /// Se recargar a cantidad maxima d tinta.
        /// </summary>
        public void Recargar()
        {
            this.tinta = cantidaTintaMaxima;
        }

        /// <summary>
        /// El método Pintar restará la tinta gastada (reutilizar código). 
        /// El parámetro gasto representará la cantidad de unidades de tinta a utilizar y utilizará
        /// tanta tinta como tenga disponible sin quedar en negativo. Utilizando el parámetro dibujo 
        /// informará el resultado retornando tantos * como unidades de tinta haya gastado, 
        /// por ejemplo:
        /// Si no había nada de tinta retornará una cadena de texto vacía.
        /// Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
        /// Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns></returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            bool pudo = true;
            dibujo = "";
            if (this.tinta <= 0)//No hay tinta devuelve false.
            {
                pudo = false;
            }
            else
            {
                if (gasto <= this.tinta)//Si lo q gasto sigue siendo menor a la tinta q hay
                {
                    this.SetTinta(Convert.ToInt16(gasto * -1));
                    for (int i = 0; i < gasto; i++)//Recorro para ver cuanto gasto y dibujo
                    {
                        dibujo += "*";
                    }
                }
                else//Si quiere gastar mas tinta de la que hay, que gaste lo q queda.
                {
                    for (int i = 0; i < gasto; i++)
                    {
                        dibujo += "*";
                    }
                    this.SetTinta(Convert.ToInt16(this.tinta * -1));
                }
            }
            return pudo;
        }
        #endregion
    }
}
