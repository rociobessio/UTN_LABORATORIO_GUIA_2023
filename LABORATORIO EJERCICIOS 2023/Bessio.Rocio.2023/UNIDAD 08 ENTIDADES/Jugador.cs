
using System.Runtime.InteropServices;
using System.Text;

namespace UNIDAD_08_ENTIDADES
{
    /// <summary>
    /// Esta clase esta modificada para que se adapte 
    /// al ejercicio que implementa Herencia
    /// </summary>
    public class Jugador : Persona
    {
        #region ATRIBUTOS 
        private int _partidosJugados;
        private int _totalGoles;
        #endregion

        #region PROPIEDADES (encapsulamientp)
        /// <summary>
        /// Propiedad de lectura.
        /// </summary>
        public int PartidosJugados { get { return this._partidosJugados; } }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public int TotalGoles { get { return this._totalGoles; } }
        /// <summary>
        /// Propiedad de lectura.
        /// Se quita el metodo GetPromedio() y se calcula dentro de la propiedad
        /// </summary>
        public float PromedioGoles { get { return (float)this._totalGoles / this._partidosJugados; } }
        #endregion

        #region CONSTRUCTORES 
        /// <summary>
        /// Constructor que hereda de la clase base.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        public Jugador(int dni, string nombre)
            :base (nombre,dni) {  }

        public Jugador(int dni, string nombre,int totalGoles,int totalPartidos)
            : this(dni,nombre)
        {
            this._totalGoles=totalGoles;
            this._partidosJugados = totalPartidos;
        }
        #endregion

        #region METODOS 
        /// <summary>
        /// MostrarDatos retornará una cadena de string con todos los datos y estadísticas del jugador.
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarDatos()} - TOTAL GOLES: {this._totalGoles}");
            sb.AppendLine($"PARTIDOS JUGADOS: {this._partidosJugados} - PROMEDIO GOLES: {this.PromedioGoles}");
            return sb.ToString();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos jugadores serán iguales si tienen el mismo DNI.
        /// El dni se encuentra en la clase persona ahora asi que
        /// accedo mediante la propiedad.
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador j1,Jugador j2)
        {
            bool sonIguales = false;
            if (j1 is not null && j2 is not null)
                sonIguales = (j1.Dni == j2.Dni);
            return sonIguales;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}