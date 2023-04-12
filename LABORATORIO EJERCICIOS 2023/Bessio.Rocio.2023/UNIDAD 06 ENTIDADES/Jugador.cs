

using System.Text;

namespace UNIDAD_06_ENTIDADES
{
    public class Jugador
    {
        #region ATRIBUTOS
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Todos los datos estadísticos del jugador se inicializarán 
        /// en 0 dentro del constructor privado.
        /// </summary>
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
            :this ()
        {
            this.nombre = nombre;
            this.dni = dni; 
        }

        public Jugador(int dni, string nombre,int totalGoles,int totalPartidos)
            : this(dni,nombre)
        {
            this.totalGoles=totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
        /// </summary>
        /// <returns></returns>
        public float GetPromdioGoles()
        {
            return (float)this.totalGoles / this.partidosJugados;
        }

        /// <summary>
        /// MostrarDatos retornará una cadena de string con todos los datos y estadísticas del jugador.
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI: {this.dni} - NOMBRE: {this.nombre} - TOTAL GOLES: {this.totalGoles}");
            sb.AppendLine($"PARTIDOS JUGADOS: {this.partidosJugados} - PROMEDIO GOLES: {this.GetPromdioGoles()}");
            return sb.ToString();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos jugadores serán iguales si tienen el mismo DNI.
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador j1,Jugador j2)
        {
            bool sonIguales = false;
            if (j1 is not null && j2 is not null)
                sonIguales = (j1.dni == j2.dni);
            return sonIguales;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}