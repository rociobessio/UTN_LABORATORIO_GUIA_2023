 using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_ENTIDADES_PP_COMIQUERIA
{
    public class Comiqueria
    {
        #region ATRIBUTOS
        private List<Producto> _productos;
        private List<Venta> _ventas;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Tendrá un indexador que recibirá como parámetro un código Guid y devolverá el producto
        /// de la lista de productos que corresponda con ese código.Si no encuentra ningún producto
        /// devolverá null. 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Producto this[Guid codigo]
        {
            get 
            {
                Producto producto = null; 
                foreach (Producto p in _productos) 
                { 
                    if(((Guid)p) == codigo)//Uso el casteo explicito de producto q devuelve el codigo.
                    {
                        producto = p; 
                    } 
                }
                return producto;
            }
        }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// El constructor instanciará los campos de tipo List
        /// </summary>
        public Comiqueria()
        {
            this._productos = new List<Producto>();
            this._ventas = new List<Venta>();    
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// La sobrecarga del operador == debe verificar si el producto se encuentra en la lista de
        /// productos comparando la descripción.Si dos productos tienen la misma descripción son el
        /// mismo producto.
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator == (Comiqueria comiqueria,Producto producto)
        {
            bool esta = false;
            if(!(comiqueria is null) && !(producto is null))
            {
                foreach (Producto item in comiqueria._productos)
                {
                    if (item.Descripcion == producto.Descripcion)
                    {
                        esta = true;
                        break;
                    }
                }
            }
            return esta;
        }

        /// <summary>
        /// La sobrecarga del operador != debe reutilizar código, no repetir
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator != (Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        /// <summary>
        /// La sobrecarga del operador + debe agregar un producto a la lista de producto siempre que
        /// el mismo ya no exista en la lista.
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static Comiqueria operator + (Comiqueria comiqueria,Producto producto)
        { 
            if(!(comiqueria is null) && !(producto is null))
            {
                if(comiqueria != producto)//Si no existe, reutilizo sobrecargas
                {
                    comiqueria._productos.Add(producto);
                }
            }
            return comiqueria;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El método Vender agrega una nueva venta a la lista de ventas
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        public void Vender(Producto producto,int cantidad)
        {
            this._ventas.Add(new Venta(producto,cantidad));
        }

        /// <summary>
        /// El método Vender tiene una sobrecarga que sólo recibe un producto (sin cantidad). Llamará
        /// a la sobrecarga más compleja pasándole como argumento a la cantidad el valor de 1. 
        /// </summary>
        /// <param name="producto"></param>
        public void Vender(Producto producto)
        {
            this.Vender(producto,1);
        }

        /// <summary>
        /// ListarProductos devuelve un Dictionary<Guid, string>. Cada elemento del diccionario
        /// corresponderá con cada producto en la lista de productos.La key será el código del
        /// producto y el valor la descripción del producto.
        /// </summary>
        /// <returns></returns>
        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid,string> diccionario = new Dictionary<Guid,string>();

            foreach (Producto item in this._productos)
            {
                //Verifico q no venga null el producto, y que la Key no sea ya existente
                if (!(item is null) && !(diccionario.ContainsKey((Guid)item)))
                {
                    diccionario.Add(((Guid)item), item.Descripcion);
                }
            } 
            return diccionario;
        }

        /// <summary>
        /// ListarVentas devuelve un string conteniendo la descripción breve de cada venta en la lista
        /// de ventas.Una descripción por línea.Utilizar las herramientas que expone la clase Venta.
        /// La lista deberá estar ordenada por fecha de la más reciente a la más antigua (Para
        /// esto utilice el mecanismo que conozca y prefiera. Si lo necesita, agregue un método extra o
        /// lo que requiera).
        /// </summary>
        /// <returns></returns>
        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("     LISTA DE VENTAS");
            if(this._ventas.Count > 0)//Me fijo que hayan ventas
            {
                foreach (Venta item in this._ventas)
                {
                    if(!(item is null))
                    {
                        sb.AppendLine($"{item.ObtenerDescripcionBreve()}");
                    }
                }
            }
            else
            {
                sb.AppendLine("NO HAY VENTAS.");
            }
            return sb.ToString();
        }
        #endregion
    }
}
