using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_ENTIDADES_PP_COMIQUERIA
{
    sealed class Venta
    {
        #region ATRIBUTOS
        private DateTime _fecha;
        static int _porcentajeIVA;
        private double _precioFinal;
        private Producto producto;
        #endregion

        #region PROPIEDADES
        internal DateTime Fecha { get { return this._fecha; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Tiene un constructor estático que inicializará el campo porcentajeIva en 21.
        /// </summary>
        static Venta()
        {
            _porcentajeIVA = 21;
        }

        /// <summary>
        /// El constructor de instancia inicializará el campo producto y llamará al método Vender
        /// pasándole la cantidad indicada como argumento
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        internal Venta(Producto producto,int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Le restará al stock del producto la cantidad que le pasaron por parámetro. 
        /// Inicializará el campo fecha con la fecha actual completa.
        /// Inicializará el campo precioFinal con el valor retornado por el método
        /// CalcularPrecioFinal, al cual se le pasará el precio unitario del producto y la cantidad. 
        /// </summary>
        /// <param name="cantidad"></param>
        private void Vender(int cantidad)
        {
            int vendio = 0;
            if (this.producto.Stock >= cantidad)
            {
                this.producto.Stock -= cantidad;//Resto del stock
            }

            this._fecha = DateTime.Now;
            this._precioFinal = Venta.CalcularPrecioFinal(this.producto.Precio, vendio);
        }

        /// <summary>
        /// El método CalcularPrecioFinal es estático y público. Calculará el precio final multiplicando
        /// el precio unitario por la cantidad comprada y a este resultado le aplicará el porcentaje de
        /// IVA que esté indicado en el campo porcentajeIva.
        /// </summary>
        /// <param name="precioUnidad"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static double CalcularPrecioFinal(double precioUnidad,int cantidad)
        { 
            return (float)precioUnidad * cantidad * ((Venta._porcentajeIVA / 100) + 1);
        }

        /// <summary>
        /// El método ObtenerDescripcionBreve devuelve un string breve y en una sola línea indicando
        /// fecha, descripción del producto y precio final.De esta forma: “fecha – descripción –
        /// precioFinal”. El precio deberá mostrarse con 2 decimales.
        /// </summary>
        /// <returns></returns>
        public string ObtenerDescripcionBreve()
        {
            return $" {this._fecha.ToShortDateString()} - {this.producto.Descripcion} - ${this._precioFinal:f}";
        }
        #endregion

    }
}
