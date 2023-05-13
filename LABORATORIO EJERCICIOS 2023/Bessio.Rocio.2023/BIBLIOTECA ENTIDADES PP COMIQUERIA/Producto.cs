using System.Text;

namespace BIBLIOTECA_ENTIDADES_PP_COMIQUERIA
{
    /// <summary>
    /// Clase abstracta.
    /// </summary>
    public abstract class Producto
    {
        #region ATRIBUTOS
        private Guid _codigo;
        private string _descripcion;
        private double _precio;
        private int _stock;
        #endregion

        #region PROPIEDADES
        public string Descripcion { get { return this._descripcion;} }
        public double Precio { get { return this._precio; } }

        /// <summary>
        /// La propiedad Stock de lectura y escritura. Validará que el stock ingresado sea mayor o igual a
        /// cero, sino no lo actualizará.
        /// </summary>
        public int Stock { get { return this._stock; } 
            set 
            {
                if(value > 0)
                {
                    this._stock = value;
                }
            } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Inicializará el campo “codigo” con el método estático NewGuid de la
        /// clase Guid.Iniciar el resto de los campos con los parámetros de entrada
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        protected Producto(string descripcion, double precio, int stock)
        {
            this._codigo = Guid.NewGuid();
            this._descripcion = descripcion;
            this._precio = precio;
            this._stock = stock;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Tiene un método de conversión explícito transforma un producto en su código
        /// </summary>
        /// <param name="producto"></param>
        public static explicit operator Guid(Producto producto)
        {
            return producto._codigo;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Sobrescribir el método ToString para devolver un string con los datos de un producto:
        /// descripción, código, precio y stock.Se deberá utilizar StringBuilder y/o métodos de la clase
        /// String, no utilizar operador + y derivados(no concatenar).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Descripción: {this._descripcion} \nCódigo: {this._codigo}" +
                $"\nPrecio: ${this._precio}\nStock: {this._stock} unidades");
            return sb.ToString();
        }
        #endregion

    }
}