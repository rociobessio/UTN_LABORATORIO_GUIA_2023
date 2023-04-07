using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_04__SOBRECARGA_
{
    public class Estante
    {
        #region ATRIBUTOS
        private Producto[] productos;//array de tipo producto
        private int ubicacionEstante;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// El método público GetProductos, retornará el array de productos.
        /// </summary>
        public Producto[] GetProductos { get { return this.productos; } }
        #endregion
         
        #region CONSTRUCTORES
        /// <summary>
        /// El constructor de instancia privado será el único que incializará el array.
        /// </summary>
        /// <param name="capacidad"></param>
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];   
        }

        /// <summary>
        /// La sobrecarga pública del constructor inicializará la ubicación del estante,
        /// recibiendo como parámetros la capacidad y la ubicación. 
        /// Reutilizar código.
        /// </summary>
        /// <param name="capacidad"></param>
        /// <param name="ubicacion"></param>
        public Estante(int capacidad,int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;  
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El método público de clase (estático) MostrarEstante, retornará una cadena con toda la información del estante 
        /// incluyendo el detalle de cada uno de sus productos. 
        /// Reutilizar código.
        /// </summary>
        /// <returns></returns>
        public static string MostrarEstante(Estante estante)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"UBICACION DEL ESTANTE {estante.ubicacionEstante}");
            for (int i = 0; i < estante.GetProductos.Length; i++)//Recorro el array de productos
            {
                if (!Object.ReferenceEquals(estante.productos[i], null))//Verifico que la instancia no sea null, se puede obviar
                {
                    stringBuilder.AppendLine(Producto.MostrarProducto(estante.productos[i]));//Muestro los productos.
                    stringBuilder.AppendLine("----------------------");
                }
            }
            return stringBuilder.ToString();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// ==: Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
        /// </summary>
        /// <param name="estante"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator == (Estante estante,Producto producto)
        {
            bool esta = false;
            for(int i = 0; i < estante.productos.Length;i++)
            {
                if (producto == estante.productos[i])//Comparo si son iguales
                {
                    esta = true; 
                    break;//Rompo el foreach porq esta, al pedo seguir iterando
                }
            }
            return esta;
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        /// <summary>
        /// +: Retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y 
        /// dicho producto no se encuentra en el estante, false caso contrario.
        /// Reutilizar código.
        /// </summary>
        /// <param name="estante"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator +(Estante estante, Producto producto)
        {
            bool pudo  = false;
            if (estante != producto)//Reutilizo codigo, si producto NO esta en el estante
            {
                //Recorro el array d productos mientras i > a la length, chequeo que aun tenga capacidad
                for (int i = 0; i > estante.productos.Length; i++)
                {
                    if (estante.productos[i] is null)//Chequeo si productos en la posicion i es null
                    {
                        estante.productos[i] = producto;//guardo el d posicion i en producto
                        pudo = true;
                    }
                }
            }
            return pudo;
        }

        /// <summary>
        /// -: Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado. Reutilizar código.
        /// </summary>
        /// <param name="estante"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static Estante operator -(Estante estante, Producto producto)
        { 
            //Recorro el array y en cada vuelta...
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] == producto)//Me fijo si producto en posicion i es igual al producto que recibo
                {
                    estante.productos[i] = null;//Lo pongo en null ya 
                    break;//Dejo de iterar
                }
            }
            return estante;//Devuelvo el estante sin el producto
        }
        #endregion
    }
}
