using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_DE_CLASES_PP__SISTEMA_SOLAR_
{
    public class Satelite : Astro
    {
        #region PROPIEDAD
        /// <summary>
        /// Retorno el nombre del astro
        /// </summary>
        public string Nombre { get { return base._nombre; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="duracion"></param>
        /// <param name="orbita"></param>
        /// <param name="nombre"></param>
        public Satelite(int duracion,int orbita,string nombre)
            : base(orbita, duracion,nombre)
        {

        }
        #endregion

        #region METODOS
        /// <summary>
        /// Sobreescibo el metodo abstracto Orbitar de la clase padre.
        /// Orbitar() retorna "Orbitar el satelite: {nombre}".
        /// </summary>
        /// <returns></returns>
        public override string Orbitar()
        {
            return $"Orbitar el satelite: {this.Nombre}";
        }

        /// <summary>
        /// Sobrecarga del ToString() que retorna la información del objeto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.Mostrar();
        }
        #endregion

    }
}
