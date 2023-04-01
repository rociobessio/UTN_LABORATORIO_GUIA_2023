using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_DE_CLASES__EL_DISPOSITIVO_
{
    /// <summary>
    /// Clase que hereda de Aplicacion.
    /// </summary>
    public class AppJuegos : Aplicacion
    {
        #region PROPIEDADES
        /// <summary>
        /// La propiedad Tamanio retorna el tamaño de la aplicación
        /// Es la implementacion de la propiedad abstracta.
        /// </summary>
        protected override int Tamanio { get { return base.tamanioMB; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor que hereda de la clase Aplicacion.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="so"></param>
        /// <param name="tamanio"></param>
        public AppJuegos(string nombre, SistemaOperativo so,int tamanio)
            : base(nombre , so,tamanio)
        {

        }
        #endregion

    }
}
