using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_06_ENTIDADES
{
    public class Competencia
    {
        #region ATRIBUTOS
        private short cantidadCompetidoes;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// El constructor privado será el único capaz de inicializar la lista de competidores.
        /// </summary>
        private Competencia()
        {
            this.competidores = new List<AutoF1>(); 
        }

        /// <summary>
        /// Sobrecarga de constructores
        /// </summary>
        /// <param name="cantidadVueltas"></param>
        /// <param name="cantCompetidores"></param>
        public Competencia(short cantidadVueltas,short cantCompetidores)
            : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidoes = cantCompetidores;
        }
        #endregion

        #region METODO
        /// <summary>
        /// Muestra los datos y la lista de competidores.
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CANTIDAD COMPETIDORES: {this.cantidadCompetidoes} - CANTIDAD VUELTAS: {this.cantidadVueltas}");
            foreach (AutoF1 item in this.competidores)
            {
                sb.AppendLine(item.MostarDatos());
            }
            return sb.ToString();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// si es que aún hay espacio (validar con cantidadCompetidores) y el competidor no forma parte 
        /// de la lista (== entre Competencia y AutoF1).
        /// </summary>
        /// <param name="competencia"></param>
        /// <param name="autoF1"></param>
        /// <returns></returns>
        public static bool operator == (Competencia competencia,AutoF1 autoF1)
        {
            bool esParte = false;
            if (competencia is not null && autoF1 is not null)
            {
                foreach (AutoF1 auto in competencia.competidores)
                {
                    if (auto == autoF1)
                    {
                        esParte =  true;
                    }
                }
            }
            return esParte;
        }

        public static bool operator !=(Competencia competencia, AutoF1 autoF1)
        {
            return !(competencia == autoF1);
        }

        /// <summary>
        /// Me permite sacar a un competidor de la lista.
        /// </summary>
        /// <param name="competencia"></param>
        /// <param name="autoF1"></param>
        /// <returns></returns>
        public static bool operator -(Competencia competencia, AutoF1 autoF1)
        {
            bool saco = false;
            if(competencia is not null && autoF1 is not null)
            { 
                if (competencia == autoF1)
                {
                    competencia.competidores.Remove(autoF1);//Metodo Remove(), lo saco de la lista
                    saco =  true;
                }
            }
            return saco;
        }

        /// <summary>
        /// La sobrecarga del operador + agregará un competidor si es que aún hay espacio (validar con cantidadCompetidores)
        /// y el competidor no forma parte de la lista (== entre Competencia y AutoF1).
        /// 
        /// Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, 
        /// la cantidad de vueltasRestantes será igual a la cantidadVueltas de Competencia
        /// y se le asignará un número aleatorio entre 15 y 100 a cantidadCombustible.
        /// </summary>
        /// <param name="competencia"></param>
        /// <param name="autoF1"></param>
        /// <returns></returns>
        public static bool operator + (Competencia competencia, AutoF1 autoF1)
        {
            bool pudoAgregar = false;
            if(competencia is not null && autoF1 is not null)
            {
                if (competencia.competidores.Count < competencia.cantidadCompetidoes && competencia != autoF1)
                {
                    competencia.competidores.Add(autoF1);//Lo añado a la lista
                    autoF1.EnCompetencia = true;//el competidor cambiará su estado enCompetencia a verdadero
                    autoF1.VueltasRestantes = competencia.cantidadVueltas;//la cantidad de vueltasRestantes será igual a la cantidadVueltas de Competencia
                    Random random = new Random();
                    autoF1.CantidadCombustible = (short)random.Next(15, 100);//se le asignará un número aleatorio entre 15 y 100 a cantidadCombustible
                    
                    pudoAgregar = true;
                } 
            }
            return pudoAgregar; 
        }
        #endregion
    }
}
