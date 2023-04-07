using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_04__SOBRECARGA_
{
    public class Pesos
    {
        #region ATRIBUTOS 
        private double cantidad;
        private static double cotzRespectoDolar;
        #endregion

        #region PROPIEDADES
        public static double GetCotizacion() { return cotzRespectoDolar; } 
        public double GetCantidad() { return this.cantidad; }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Los constructores estaticos le daran la cotizacion por defecto
        /// del dolar = 1,17 Dólares.
        /// </summary>
        static Pesos()
        {
            cotzRespectoDolar = 1 / 102.65;//1 dolar 
        }

        /// <summary>
        /// Constructor parametrizado que recibe la cantidad y 
        /// se la da al atributo.
        /// </summary>
        /// <param name="cantidad"></param>
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Sobrecarga de constructor,
        /// agrega la cotizacion respecto al dolar que recibe.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="cotz"></param>
        public Pesos(double cantidad, double cotz)
            : this(cantidad)
        {
            cotzRespectoDolar = cotz;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// El operador implicito recibe un double y retorna obj Pesos.
        /// Para luego hacer:
        /// Pesos p = d;
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        /// <summary>
        /// El operador explicito retorna como dolar la cotizacion
        /// del peso con respecto al dolar.
        /// Ejemplo:
        /// (Dolar)p;
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / Pesos.GetCotizacion());
        }

        /// <summary>
        /// Este operador explicito devolvera Euro respecto al peso
        /// en cotizacion con el dolar.
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
        }

        /// <summary>
        /// Retorna si las cantidades son iguales.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator == (Pesos p,Dolar d)
        {
            return (p == (Pesos)d);
        }

        public static bool operator != (Pesos p,Dolar d)
        {
            return !(p == d);
        }

        public static bool operator == (Pesos p,Euro e)
        {
            return (p == (Pesos)e);
        }

        public static bool operator !=(Pesos p,Euro e)
        { return !(p == e); }

        public static bool operator == (Pesos p1,Pesos p2)
        {
            return (p1.cantidad == p2.cantidad);
        }

        public static bool operator !=(Pesos p1,Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator +(Pesos p1, Euro e)
        {
            return new Pesos(p1.cantidad + ((Pesos)e).cantidad);
        }

        public static Pesos operator - (Pesos p1, Euro e)
        {
            return new Pesos(p1.cantidad - ((Pesos)e).cantidad);
        }

        public static Pesos operator +(Pesos p1, Dolar d)
        {
            return new Pesos(p1.cantidad + ((Pesos)d).cantidad);
        }

        public static Pesos operator -(Pesos p1, Dolar d)
        {
            return new Pesos(p1.cantidad - ((Pesos)d).cantidad);
        }
        #endregion
    }
}
