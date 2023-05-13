using System.Text;

namespace ENTIDADES_LA_CENTRALITA
{
    /// <summary>
    /// CENTRALITA II: La clase Llamada ahora será abstracta. 
    /// </summary>
    public abstract class Llamada
    {
        #region ATRIBUTOS
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// CENTRALITA II: endrá definida la propiedad de sólo lectura CostoLlamada que también será abstracta.
        /// Se debera de implementar en las clases heredadas.
        /// </summary>
        public abstract float CostoLlamada { get; }
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

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// CENTRALITA II:
        /// El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
        /// (utilizar el método Equals, sobrescrito en las clases derivadas) y los números de destino 
        /// y origen son iguales en ambas llamadas.
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns></returns>
        public static bool operator == (Llamada llamada1, Llamada llamada2)
        {
            bool sonIguales = false;
            if(!(llamada1 is null) && !(llamada2 is null))
            {
                sonIguales = llamada1.Equals(llamada2);
            }
            return sonIguales;
        }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Me retorna un string con los datos de la clase.
        /// 
        ///                     CENTRALITA II:
        /// El método Mostrar deberá ser declarado como virtual, protegido y
        /// retornará un string que contendrá los atributos propios de la clase Llamada.
        /// </summary>
        /// <returns></returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nDURACION: {this._duracion} \nNRO. DESTINO: {this._nroDestino} \nNRO. ORGIREN: {this._nroOrigen}");
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

        #region POLIMORFISMO
        /// <summary>
        /// Centralita II:
        /// Retorna true si es del tipo LLAMADA y tiene mismo num de origen y destino.
        /// Se sobreescribe el metodo equal.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool esEqual = false;
            if (obj is not null && obj is Llamada)
            {
                Llamada l = ((Llamada)obj);//Casteo obj a Llamada
                if (l.NroDestino == this.NroDestino && l.NroOrigen == this.NroOrigen)
                { esEqual = true; }
            }
            return esEqual;
        }
        #endregion

        #region ENUM
        public enum TipoLlamada { Local, Provincial, Todas }
        #endregion
    }
}