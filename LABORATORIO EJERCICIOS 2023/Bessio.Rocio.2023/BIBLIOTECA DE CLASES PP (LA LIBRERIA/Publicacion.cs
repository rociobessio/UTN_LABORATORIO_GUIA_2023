using System.Text;

namespace BIBLIOTECA_DE_CLASES_PP__LA_LIBRERIA
{
    /// <summary>
    /// Una clase abstracta es una simplificacion de la realidad
    /// donde me quedo con lo importante y descarto detalles irrelevantes.
    /// </summary>
    public abstract class Publicacion
    {
        #region ATRIBUTOS
        protected float importe;
        protected string nombre;
        protected int stock;
        #endregion

        #region PROPIEDADES
        protected abstract bool EsColor { get; }

        /// <summary>
        /// La propiedad HayStock será virtual, retornará true siempre y cuando haya stock y el importe sea mayor a 0 (cero).
        /// </summary>
        public virtual bool HayStock { get { if (this.stock > 0 && this.importe > 0) { return true; } else { return false; } } }
        public float Importe { get { return this.importe; }  }
        /// <summary>
        /// Solo asignara si lo recibido es mayor a 0.
        /// </summary>
        public int Stock { get { return this.stock; } set { if (value >= 0) { this.stock = value; } } }
        #endregion

        #region CONSTRUCTORES (sobrecarga)
        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre,int stock)
            : this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(string nombre,int stock, float importe)
            :this(nombre, stock)
        {
            this.importe = importe;
        }
        #endregion

        #region METODOS
        public string ObtenerInformacion()
        {
            string esColor = EsColor ? "SI" : "NO";//es un if, Si es Color en el string retorna SI else NO
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre.ToUpper()}{Environment.NewLine} STOCK: {this.stock}{Environment.NewLine}" +
                $"ES COLOR: {esColor}{Environment.NewLine} VALOR: ${this.importe}");
            return sb.ToString();
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// El metodo .ToString() retorna el nombre
        /// de la publicacion.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nombre;
        }
        #endregion
    }
}