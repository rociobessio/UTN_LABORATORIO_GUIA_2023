using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES_LA_CENTRALITA
{
    public class Provincial : Llamada
    {
        #region ATRIBUTOS
        protected Franja franjaHoraria;
        #endregion

        #region PROPIEDADES
        public float CostoLlamada { get { return this.CalcularCosto(); } }
        #endregion

        #region CONSTRUCTORES
        public Provincial(Franja franja,Llamada llamada)
            :base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = franja;
        }

        public Provincial(string origen,Franja miFranja,float duracion,string destino)
            : base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Método Mostrar retornará como texto todos los datos de la clase base y agregará el costo de la llamada y la franja horaria.
        /// Utilizar StringBuilder.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("|----------------------|");
            sb.AppendLine("|  LLAMADA PROVINCIAL  |");
            sb.AppendLine("|----------------------|");
            sb.AppendLine($"{base.Mostrar()} - COSTO: {this.CostoLlamada} - FRANJA HORARIA: {this.franjaHoraria}");
            return sb.ToString();
        }

        /// <summary>
        /// CalcularCosto será privado y retornará el valor de la llamada a partir de la duración y el costo de la misma. Los valores serán:
        /// Franja_1: 0.99
        /// Franja_2: 1.25
        /// Franja_3: 0.66
        /// </summary>
        /// <returns>Retorna el costo de la llamada por la duracion</returns>
        private float CalcularCosto()
        {
            float costoLlamadaFinal = 0;
            switch (this.franjaHoraria)//Verifico que franja horaria es
            {
                case Franja.Franja_1:
                    costoLlamadaFinal = (float)0.99;
                break;
                case Franja.Franja_2:
                    costoLlamadaFinal = (float)1.25;
                break;
                case Franja.Franja_3:
                    costoLlamadaFinal = (float)0.66;
                break;
            }
            return costoLlamadaFinal * base.Duracion;
        }
        #endregion

        #region ENUMERADOS
        public enum Franja { Franja_1, Franja_2, Franja_3 }
        #endregion
    }
}
