
using System.Runtime.InteropServices;
using System.Text;

namespace UNIDAD_06_ENTIDADES
{
    public class Jugador
    {
        #region ATRIBUTOS
        private int _dni;
        private string _nombre;
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
        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public int Dni { get { return this._dni; } set { this._dni = value; } }
        /// <summary>
        /// Propiedad de lectura y escritura.
        /// </summary>
        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }   
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Todos los datos estadísticos del jugador se inicializarán 
        /// en 0 dentro del constructor privado.
        /// </summary>
        private Jugador()
        {
            this._partidosJugados = 0; 
            this._totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
            :this ()
        {
            this._nombre = nombre;
            this._dni = dni; 
        }

        public Jugador(int dni, string nombre,int totalGoles,int totalPartidos)
            : this(dni,nombre)
        {
            this._totalGoles=totalGoles;
            this._partidosJugados = totalPartidos;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
        /// </summary>
        /// <returns></returns>
        //public float GetPromdioGoles()
        //{
        //    return (float)this._totalGoles / this._partidosJugados;
        //}

        /// <summary>
        /// MostrarDatos retornará una cadena de string con todos los datos y estadísticas del jugador.
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI: {this._dni} - NOMBRE: {this._nombre} - TOTAL GOLES: {this._totalGoles}");
            sb.AppendLine($"PARTIDOS JUGADOS: {this._partidosJugados} - PROMEDIO GOLES: {this.PromedioGoles}");
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
                sonIguales = (j1._dni == j2._dni);
            return sonIguales;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}