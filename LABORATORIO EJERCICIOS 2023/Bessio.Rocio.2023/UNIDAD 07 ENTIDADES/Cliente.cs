namespace UNIDAD_07_ENTIDADES
{
    public class Cliente
    {
        #region ATRIBUTOS
        private string nombre;
        private int numero;
        #endregion

        #region PROPIEDADES
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public int Numero { get { return this.numero; } }
        #endregion

        #region CONSTRUCTOR
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre)
            : this(numero)
        {
            this.nombre = nombre;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// La sobrecarga del operador == retornará true si dos clientes tienen el mismo número.
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static bool operator == (Cliente cliente1,Cliente cliente2)
        {
            bool sonIguales = false;
            if(cliente1 is not null && cliente2 is not null)
            {
                sonIguales = cliente1.numero == cliente2.numero;
            }
            return sonIguales;
        }

        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }
        #endregion
    }
}