using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_08_ENTIDADES
{
    public class VehiculoDeCarrera
    {
        #region ATRIBUTOS
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia; 
        private short _vueltasRestantes;
        private short _numero;
        #endregion

        #region PROPIEDADES
        public short Numero { get { return this._numero; } set { this._numero = value; } }
        public short CantidadCombustible { get { return this._cantidadCombustible; } set { this._cantidadCombustible = value; } }
        public bool EnCompetencia { get { return this._enCompetencia; } set { this._enCompetencia = value; } }
        public short VueltasRestantes { get { return this._vueltasRestantes; } set { this._vueltasRestantes = value; } }
        public string Escuderia { get { return this._escuderia; } set { this._escuderia = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Me permite crear una instancia de un VehiculoDeCarrera.
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="escuderia"></param>
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this._numero = numero;
            this._escuderia = escuderia;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos VehiculosDeCarreras seran iguales si tienen mismo numero
        /// y escuderia.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            bool sonIguales = false;
            if(v1 is not null && v2 is not null)
                sonIguales = (v1._numero == v2._numero) && (v1._escuderia == v2._escuderia);
            return sonIguales;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
        #endregion

        #region METODO
        public string MostarDatos()
        {
            StringBuilder sb = new StringBuilder();
            bool enCompetencia = this.EnCompetencia;
            string siNo = "NO";
            if (enCompetencia)
                siNo = "SI";

            sb.AppendLine($"NÚMERO: {this._numero} - ESCUDERIA: {this._escuderia} - EN COMPETENCIA: {siNo} - " +
                $"VUELTAS RESTANTES: {this._vueltasRestantes} - CANT. COMBUSTIBLE: {this._cantidadCombustible}");
            return sb.ToString();   
        }
        #endregion

    }
}
