using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_04__SOBRECARGA_
{
    public class Dolar
    {
        #region ATRIBUTOS
        private double cantidad;
        private static double cotzRespectoDolar;
        #endregion

        #region PROPIEDADES
        public static double GetCotizacion() {  return cotzRespectoDolar; } 
        public double GetCantidad() {  return this.cantidad; }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Los constructores estaticos le daran la cotizacion por defecto
        /// del dolar = 1,17 Dólares.
        /// </summary>
        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        /// <summary>
        /// Constructor parametrizado que recibe la cantidad
        /// </summary>
        /// <param name="cantidad"></param>
        public Dolar(double cantidad) 
        {
            this.cantidad = cantidad;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Me devuelve el double como Dolar.
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Dolar(double d) 
        {
            return new Dolar(d);
        }

        /// <summary>
        /// Me devuelve el valor del Dolar en Euros.
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(Euro.GetCotizacion() * d.cantidad);
        }

        /// <summary>
        /// Me devuelve el valor del Dolar en Pesos.
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(Pesos.GetCotizacion() * d.cantidad);
        }

        /// <summary>
        /// Los operadores de comparación == compararán cantidades.
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool sonIguales = false;
            if (d1 is not null && d2 is not null)
            {
                sonIguales = (d1.GetCantidad() == d2.GetCantidad());
            }
            return sonIguales;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        /// <summary>
        /// Los operadores de comparación == compararán cantidades.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator == (Dolar d, Pesos p)
        {
            bool sonIguales = false;
            if (d is not null && p is not null)
            {
                sonIguales = (d.cantidad == p.GetCantidad());
            }
            return sonIguales;
        }

        public static bool operator != (Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator == (Dolar d,Euro e)
        {
            bool sonIguales = false;
            if (d is not null && e is not null)
            {
                sonIguales = (d.cantidad == e.GetCantidad());
            }
            return sonIguales;
        }

        public static bool operator != (Dolar d, Euro e)
        {
            return !(d == e);
        }
        
        public static Dolar operator -(Dolar d,Pesos p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).cantidad);//Gracias al casteo resto cantidades
        } 
        public static Dolar operator + (Dolar d,Pesos p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);//Gracias al casteo sumo cantidades
        }

        public static Dolar operator + (Dolar d,Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);//Gracias al casteo sumo cantidades.
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);//Gracias al casteo resto cantidades
        }
        #endregion

    }
}
