

using System.Text;

namespace UNIDAD_12_ENTIDADES___GENERICS
{
    /// <summary>
    /// Restringir el tipo genérico para que deba ser del tipo Equipo o sus derivados.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Torneo<T> where T : Equipo
    {
        #region ATRIBUTOS
        private List<T> _listaEquipos;
        private string _nombre;
        #endregion

        #region PROPIEDAD
        /// <summary>
        /// La propiedad pública JugarPartido tomará dos equipos de la lista al azar y
        /// calculará el resultado del partido a través del método CalcularPartido.
        /// </summary>
        public string JugarPartido
        {
            get
            {
                Random rd = new Random();
                T equipo1;
                T equipo2;

                do
                {
                    equipo1 = _listaEquipos[rd.Next(0, _listaEquipos.Count)];
                    equipo2 = _listaEquipos[rd.Next(0, _listaEquipos.Count)];

                } while (equipo1 == equipo2);
                return CalcularPartido(equipo1, equipo2);
            }
        }
        #endregion

        #region CONSTRUCTORES
        private Torneo()
        {
            this._listaEquipos = new List<T>();
        }
        public Torneo(string nombre) 
            : this()
        {
            this._nombre = nombre;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Sobrecargar el operador == para que controle si un equipo ya está inscripto al torneo.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static bool operator == (Torneo<T> torneo,T equipo)
        {
            bool esta = false;
            if (!(torneo is null) && !(equipo is null))
            {
                foreach (T item in torneo._listaEquipos)
                {
                    if (item == equipo)
                    {
                        esta = true;
                    }
                }
            }
            return esta;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        /// <summary>
        /// Sobrecargar el operador + para agregar un equipo a la lista, siempre y 
        /// cuando este no se encuentre ya en el torneo.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            bool esta = false;

            if (!(torneo is null) && !(equipo is null))
            {
                if (torneo != equipo)
                {
                    torneo._listaEquipos.Add(equipo);
                    esta = true;
                }
            } 
           return esta;
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// El método Mostrar retornará los datos del torneo y de los equipos participantes.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {this._nombre}");
            foreach (T item in this._listaEquipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();   
        }

        /// <summary>
        /// El método privado CalcularPartido recibirá dos elementos del tipo T, que deberán ser del tipo Equipo
        /// o sus herencias, y calculará utilizando la clase Random un resultado del partido. Retornará el resultado 
        /// como un string con el siguiente formato donde EQUIPOX es el nombre del equipo y RESULTADOX 
        /// la cantidad de goles/puntos:
        /// </summary>
        /// <param name="equipo1"></param>
        /// <param name="equipo2"></param>
        /// <returns></returns>
        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random resultadoRandom = new Random();
            return $"{equipo1._nombre}{resultadoRandom.Next(0,10)} - {equipo2._nombre}{resultadoRandom.Next(0,10)}";
        }
        #endregion
    }
}