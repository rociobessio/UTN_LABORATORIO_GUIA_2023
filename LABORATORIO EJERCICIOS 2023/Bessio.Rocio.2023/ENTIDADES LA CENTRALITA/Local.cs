using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES_LA_CENTRALITA
{
    /// <summary>
    /// La clase Local hereda de Llamada
    /// </summary>
    public class Local : Llamada
    {
        #region ATRIBUTOS
        protected float _costo;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// La propiedad CostoLlamada retornará el precio,
        /// que se calculará en el método CalcularCosto.
        /// </summary>
        public override float CostoLlamada { get { return this.CalcularCosto(); } }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor parametrizado, Con el parametro llamada
        /// se lo paso al constructor de base citando a los
        /// atributos correspondientes.
        /// </summary>
        /// <param name="llamada"></param>
        /// <param name="costo"></param>
        public Local(Llamada llamada,float costo) 
            : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this._costo = costo;
            
        }

        /// <summary> 
        /// </summary>
        /// <param name="origen"></param>
        /// <param name="duracion"></param>
        /// <param name="destino"></param>
        /// <param name="costo"></param>
        public Local(string origen,float duracion,string destino,float costo)
            : base(duracion,origen,destino)
        {
            this._costo= costo;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Método Mostrar retornará como texto todos los datos de la clase base y agregará el costo de la llamada.
        /// Utilizar StringBuilder.
        /// 
        /// CENTRALITA II: 
        /// Sobrescribir el método Mostrar. Será protegido. 
        /// Reutilizará el código escrito en la clase base y además agregará la propiedad 
        /// CostoLlamada, utilizando un StringBuilder.
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n\t\t|----------------------------------|\t");
            sb.AppendLine("\t\t|            LLAMADA LOCAL        |\t");
            sb.AppendLine("\t\t|----------------------------------|\t");
            sb.AppendLine($"{base.Mostrar()}\nCOSTO: {this.CostoLlamada}");
            return sb.ToString();   
        }

        /// <summary>
        /// CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y 
        /// el costo de la misma.
        /// 
        /// El costo se calcula, la duracion(base) por el costo de la clase.
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            return base.Duracion * this._costo;
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// CENTRALITA II:
        /// El método ToString reutilizará el código del método Mostrar.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// CENTRALITA II:
        /// El método Equals retornará true sólo si el objeto que recibe es de tipo Local.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool esEqual = false;
            //si el obj no es nulo y es del tipo Local
            if (obj is not null && obj is Local)
            {
                esEqual = true;
            }
            return esEqual;
        }
        #endregion
    }
}
