using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_04__SOBRECARGA_
{
    public class Producto
    {
        #region ATRIBUTOS
        private string codigoDeBarra;
        private string marca;
        private float precio;
        #endregion

        #region PROPIEDADES
        public string GetMarca { get { return this.marca; } }
        public float GetPrecio { get { return (float)this.precio; } }   
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="codigoDeBarra"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El método de clase (estático) MostrarProducto es público y 
        /// retornará una cadena detallando los atributos de la clase.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static string MostrarProducto(Producto producto)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"CODIGO DE BARRA: {producto.codigoDeBarra}");
            stringBuilder.AppendLine($"MARCA: {producto.marca}");
            stringBuilder.AppendLine($"PRECIO: {producto.precio}");
            return stringBuilder.ToString();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// explicit: Realizará la conversión de un objeto Producto a string.
        /// Sólo retornará el atributo codigoDeBarras del producto.
        /// </summary>
        /// <param name="producto"></param>
        public static explicit operator string (Producto producto)
        {
            return (string)producto.codigoDeBarra;
        }

        /// <summary>
        /// == (Producto, string): Retornará true si la marca del producto coincide con la cadena pasada como argumento, 
        /// false caso contrario.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator ==(Producto producto, string marca)
        {
            bool coincide = false;
            if (producto.marca == marca)
                coincide = true;
            return coincide;
        }

        public static bool operator != (Producto producto, string marca)
        {
            return !(producto == marca);
        }

        /// <summary>
        /// == (Producto, Producto): Retornará true si las marcas y códigos de barra son iguales,
        /// false caso contrario.
        /// </summary>
        /// <returns></returns>
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            bool coinciden = false;
            if(!(producto1 is null || producto2 is null))//Me fijo q no hay nulls y rompa el programa
                coinciden = (producto1.marca == producto2.marca) && (producto1.codigoDeBarra == producto2.codigoDeBarra);   

            return coinciden;
        }

        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }
        #endregion
    }
}
