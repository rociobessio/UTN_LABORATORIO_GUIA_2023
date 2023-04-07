using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_04__SOBRECARGA_
{
    public class Euro
    {
        #region ATRIBUTOS
        private double cantidad;
        private static double cotzRespectoDolar;
        #endregion

        #region PROPIEDADES
        public static double GetCotizacion()  { return cotzRespectoDolar;  }
        public double GetCantidad() { return this.cantidad; } 
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Los constructores estaticos le daran la cotizacion por defecto
        /// del dolar = 1,17 Dólares.
        /// </summary>
        static Euro()
        {
            cotzRespectoDolar = 1 / 1.17;//1 dolar 
        }

        /// <summary>
        /// Constructor parametrizado que recibe la cantidad y 
        /// se la da al atributo.
        /// </summary>
        /// <param name="cantidad"></param>
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Sobrecarga de constructor,
        /// agrega la cotizacion respecto al dolar que recibe.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="cotz"></param>
        public Euro(double cantidad, double cotz)
            :this(cantidad)
        {
            cotzRespectoDolar = cotz;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Castea implicitamente el double a Euro.
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Euro(double d) 
        {
            return new Euro(d);
        }

        /// <summary>
        /// Casteo explicitamente un Euro a Dolar.
        /// Realiza un calculo, es decir me devuelve ese Euro
        /// como dolar.
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Dolar(Euro d)
        {
            return new Dolar(d.cantidad / cotzRespectoDolar);
        }

        public static explicit operator Pesos (Euro e)
        {
            return (Pesos)((Dolar)e);
        }

        /// <summary>
        /// Comparro cantidades.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator == (Euro e, Dolar d)
        { return e == (Euro)d; }

        public static bool operator != (Euro e, Dolar d)
        {
            return !(e == d);
        }

        /// <summary>
        /// Comparro cantidades.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==  (Euro e,Pesos p)
        {
            return e == (Euro)p;
        }

        public static bool operator != (Euro e, Pesos pesos)
        {
            return !(e == pesos);
        }

        /// <summary>
        /// Comparro cantidades.
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.cantidad == e2.cantidad);
        }

        public static bool operator != (Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }
        #endregion
    }
}
