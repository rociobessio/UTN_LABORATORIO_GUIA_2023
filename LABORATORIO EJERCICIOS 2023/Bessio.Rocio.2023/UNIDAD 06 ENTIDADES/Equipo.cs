using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_06_ENTIDADES
{
    public class Equipo
    {
        #region ATRIBUTOS
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion

        #region CONSTRUCTORES 
        /// <summary>
        /// La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
        /// </summary>
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantJugadores,string nombre)
            : this()
        {
            this.cantidadDeJugadores = cantJugadores;
            this.nombre = nombre;
        }
        #endregion

        #region SOBRECARGA
        /// <summary>
        /// La sobrecarga del operador + agregará jugadores a la lista siempre y cuando 
        /// no exista aún en el equipo y la cantidad de jugadores no supere el límite 
        /// establecido por el atributo cantidadDeJugadores.
        /// </summary>
        /// <param name="equipo"></param>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public static bool operator +(Equipo equipo,Jugador jugador)
        {
            bool pudoAgregar = true;

            if (equipo is not null && jugador is not null)
            { 
                if (equipo.jugadores.Count <= equipo.cantidadDeJugadores)
                {
                    foreach (Jugador item in equipo.jugadores)
                    {
                        //Si no son iguales y las cantidades no se superan lo añado a la lista.
                        if (item == jugador)
                        {
                            pudoAgregar = false;
                        }
                    }
                    equipo.jugadores.Add(jugador);
                }
                else
                    pudoAgregar = false;

            }
            return pudoAgregar;
        }
        #endregion
    }
}
