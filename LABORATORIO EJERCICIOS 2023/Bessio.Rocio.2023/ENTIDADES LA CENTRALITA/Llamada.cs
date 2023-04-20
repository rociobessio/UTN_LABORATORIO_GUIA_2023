using System.Text;

namespace ENTIDADES_LA_CENTRALITA
{ 

    public class Llamada
    {
        #region ATRIBUTOS
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region PROPIEDADES
        public float Duracion { get { return this._duracion; } }
        public string NroDestino { get {  return this._nroDestino; } }
        public string NroOrigen { get { return this._nroOrigen; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado que me permite crear una instancia
        /// de Llamada
        /// </summary>
        /// <param name="duracion"></param>
        /// <param name="nroDestino"></param>
        /// <param name="nroOrigen"></param>
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Me retorna un string con los datos de la clase.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DURACION: {this._duracion} - NRO. DESTINO: {this._nroDestino} - NRO. ORGIREN: {this._nroOrigen}");
            return sb.ToString();   
        }

        /// <summary>
        /// OrdenarPorDuracion es un método de clase (estatico) que recibirá dos Llamadas. 
        /// Se utilizará para ordenar una lista de llamadas de forma ascendente.
        /// </summary>
        /// <param name="llamda1"></param>
        /// <param name="llamada2"></param>
        /// <returns>Me retorna 1 si llamada1 es mayor que llamda2, -1 caso contrario</returns>
        public static int OrdenarPorDuracion(Llamada llamda1,Llamada llamada2)
        {
            int result = 0;
            if (llamda1._duracion > llamada2._duracion)
            {
                result =  1;
            }
            else if(llamda1._duracion < llamada2._duracion)
            {
                result =  - 1;
            }
            return result;
        }
        #endregion

        #region ENUM
        public enum TipoLlamada { Local, Provincial, Todas }
        #endregion
    }
}