using System.Runtime.CompilerServices;
using System.Text;

namespace BIBLIOTECA_DE_CLASES_PP__SISTEMA_SOLAR_
{
    public abstract class Astro
    {
        #region ATRIBUTOS
        private int _duracionOrbita;
        private int _duracionRotacion;
        protected string _nombre;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Un constructor que recibe su nombre y la duración de órbita y la de rotación.
        /// Me permite crear una instancia parametrizada de la clase Astro.
        /// </summary>
        /// <param name="duracionOrbita"></param>
        /// <param name="duracionRotacion"></param>
        /// <param name="nombre"></param>
        public Astro(int duracionOrbita, int duracionRotacion, string nombre)
        {
            this._duracionOrbita = duracionOrbita;
            this._duracionRotacion = duracionRotacion;
            this._nombre = nombre;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Mostrar() es un método protegido que devuelve toda la información del astro. (Ej: Nombre: {nombre} -
        ///Órbita: {órbita} -Rotación: {rotación})
        /// </summary>
        /// <returns></returns>
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE ASTRO: {this._nombre} - ÓRBITA: {this._duracionOrbita} - ROTACIÓN: {this._duracionRotacion}");
            return sb.ToString();
        }

        /// <summary>
        /// Orbitar() método abstracto.
        /// No se puede implementar en esta clase.
        /// </summary>
        /// <returns></returns>
        public abstract string Orbitar();

        /// <summary>
        /// Rotar() método virtual que retorna el mensaje "Rotando. Tiempo estimado: {tiempo de rotación}.
        /// </summary>
        /// <returns></returns>
        public virtual string Rotar()
        {
            return $"Rotando. Tiempo estimado: {this._duracionRotacion}";
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Agregar un conversor explícito de Astro a String que retorne sólo el nombre del astro.
        /// </summary>
        /// <param name="astro"></param>
        public static explicit operator string(Astro astro)
        {
            return astro._nombre;
        }
        #endregion
    }
}