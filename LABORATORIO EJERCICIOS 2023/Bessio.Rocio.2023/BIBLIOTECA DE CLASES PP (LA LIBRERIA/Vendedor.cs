using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_DE_CLASES_PP__LA_LIBRERIA
{
    public class Vendedor
    {
        #region ATRIBUTOS
        private string nombre;
        private List<Publicacion> listaVentas;
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// La lista se inicializara con el constructor privado.
        /// </summary>
        private Vendedor()
        {
            this.listaVentas = new List<Publicacion>();
        }

        /// <summary>
        /// Sobrecarga del constructor.
        /// </summary>
        /// <param name="nombre"></param>
        public Vendedor(string nombre)
            : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region SOBRECARGA
        /// <summary>
        /// Agregara siempre y cuando haya stck suficiene para realizar
        /// una venta del producto, agregando en este caso la informacion de la venta
        /// a la lista descontando stock de la publicacion.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="lisPublicaciones"></param>
        /// <returns></returns>
        public static bool operator + (Vendedor v,Publicacion publicaciones)
        {
            bool pudo = false;
            if (v is not null && publicaciones is not null)
            {
                if (publicaciones.HayStock)//Me fijo si hay stock
                {
                    v.listaVentas.Add(publicaciones);//Aññado la publicacion a su lista de ventas
                    publicaciones.Stock--;//Descuento esa publicacion usando la propiedad
                    pudo = true;
                }
            }
            return pudo;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Sera de clase (estatico) y retornara la informacion del vendedor,
        /// sus ventas y la ganancia total de las mismas (que se van acumulando de la lista de ventas).
        /// Utilizo el metodo d stringBuilder .ToUpper() para poner en mayuscula los nombres.
        /// </summary>
        /// <returns></returns>
        public static string obtenerInformeVentas(Vendedor vendedor)
        {
            float ganancias = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {vendedor.nombre.ToUpper()}{Environment.NewLine}");
            sb.AppendLine("----------------------------");
            sb.AppendLine($"PUBLICACIÓN: ");
            foreach (Publicacion item in vendedor.listaVentas)
            {
                sb.AppendLine(item.ObtenerInformacion());
                sb.AppendLine("----------------------------");
                ganancias += item.Importe;//Acumulo los importes
            }
            sb.AppendLine($"GANANCIA TOTAL: ${ganancias}");
            return sb.ToString();
        }
        #endregion
    }
}
