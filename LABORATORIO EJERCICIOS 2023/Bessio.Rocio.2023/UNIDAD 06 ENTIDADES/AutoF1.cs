using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_06_ENTIDADES
{
    public class AutoF1
    {
        #region ATRIBUTOS
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #endregion

        #region PROPIEDADES
        public short CantidadCombustible { get { return this.cantidadCombustible; } set { this.cantidadCombustible = value; } }
        public bool EnCompetencia { get { return this.enCompetencia; } set { this.enCompetencia = value; } }
        public short VueltasRestantes { get { return this.vueltasRestantes; }  set { this.vueltasRestantes = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Al generar un auto se cargará el atributo enCompetencia como falso. 
        /// Inicializar cantidadCombustible y vueltasRestantes en 0.
        /// </summary>
        public AutoF1(short numero,string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;

            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }
        #endregion

        #region METODO
        /// <summary>
        /// Devuelve string con los datos del auto.
        /// </summary>
        /// <returns></returns>
        public string MostarDatos()
        {
            StringBuilder sb = new StringBuilder();
            bool enCompetencia = this.EnCompetencia;
            string siNo = "NO";
            if (enCompetencia)
                siNo = "SI";

            sb.AppendLine($"NUMERO: {this.numero} - ESCUDERIA: {this.escuderia} - EN COMPETENCIA: {siNo}");
            sb.AppendLine($"VUELTAS RESTANTES: {this.vueltasRestantes} - CANT. COMBUSTIBLE: {this.cantidadCombustible}");
            return sb.ToString();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos autos serán iguales si los atributos número y escuderia son iguales.
        /// </summary>
        /// <param name="autoF1"></param>
        /// <param name="autoF12"></param>
        /// <returns></returns>
        public static bool operator == (AutoF1 autoF1,AutoF1 autoF12)
        {
            bool sonIguales = false;
            if(autoF1 is not null && autoF12 is not null)
            {
                sonIguales = (autoF1.numero == autoF12.numero) && (autoF1.escuderia == autoF12.escuderia);
            }
            return sonIguales;
        }

        public static bool operator !=(AutoF1 autoF1, AutoF1 autoF12)
        {
            return !(autoF1 == autoF12);
        }
        #endregion
    }
}
