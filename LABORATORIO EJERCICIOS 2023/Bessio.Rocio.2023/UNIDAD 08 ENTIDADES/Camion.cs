namespace UNIDAD_08_ENTIDADES
{
    public class Camion : VehiculoTerrestre
    {
        #region ATRIBUTOS 
        public short _cantidadMarchas;
        public int _pesoCarga;
        #endregion

        #region PROPIEDADES
        //public int PesoCarga { get { return this._pesoCarga; } set { this._pesoCarga = value; } }
        //public short CantidadMarchas { get { return _cantidadMarchas;} set {  this._cantidadMarchas = value;} }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor que me permite crear una instancia de la clase Automovil
        /// la cual hereda de VehiculoTerrestre.
        /// </summary>
        /// <param name="cantidadMarchas"></param>
        /// <param name="pesoCarga"></param>
        /// <param name="cantidadRuedas"></param>
        /// <param name="cantidadPuertas"></param>
        /// <param name="color"></param>
        public Camion(short cantidadMarchas, int pesoCarga, short cantidadRuedas, short cantidadPuertas, Color color)
            : base(cantidadRuedas,cantidadPuertas,color)
        {
            this._cantidadMarchas = cantidadMarchas;
            this._pesoCarga = pesoCarga;
        }
        #endregion
    }
}