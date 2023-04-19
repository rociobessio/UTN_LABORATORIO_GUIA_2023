using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_08_ENTIDADES
{
    public class Competencia
    {
        #region ATRIBUTOS
        private short _cantidadCompetidoes;
        private short _cantidadVueltas;
        private List<VehiculoDeCarrera> _competidores;
        private TipoCompetencia _tipoCompetencia;
        #endregion

        #region PROPIEDADES
        public short CantidadCompetidoes { get { return this._cantidadCompetidoes; } set { this._cantidadCompetidoes = value; } }
        public short CantidadVueltas { get { return this._cantidadVueltas; } set { this._cantidadVueltas = value; } }   
        public TipoCompetencia TipoCompetencia { get { return this._tipoCompetencia; } set { this._tipoCompetencia = value; } }
        public VehiculoDeCarrera this[int i] 
        {
            get
            {
                if (i >= 0 && i < this._competidores.Count)
                {
                    return this._competidores[i];//Retorno el indice
                }
                return null;
            } 
        }

        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// El constructor privado será el único capaz de inicializar la lista de competidores.
        /// </summary>
        private Competencia()
        {
            this._competidores = new List<VehiculoDeCarrera>(); 
        }

        /// <summary>
        /// Sobrecarga de constructores
        /// </summary>
        /// <param name="cantidadVueltas"></param>
        /// <param name="cantCompetidores"></param>
        public Competencia(short cantidadVueltas,short cantCompetidores,TipoCompetencia tipoCompetencia)
            : this()
        {
            this._tipoCompetencia = tipoCompetencia;
            this._cantidadVueltas = cantidadVueltas;
            this._cantidadCompetidoes = cantCompetidores;
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
            sb.AppendLine($"TIPO DE COMPETENCIA: {this._tipoCompetencia} - CANTIDAD COMPETIDORES: {this._cantidadCompetidoes} - CANTIDAD VUELTAS: {this._cantidadVueltas}");
            
            
            //Recorro la lista y muestro el vehiculo que corresponde
            foreach (VehiculoDeCarrera item in this._competidores)
            {
                //Comparo y corroboro los tipos d competencia y los vehiculos
                if(item.GetType() == typeof(AutoF1))//Si el item d la lista es igual a AutoF1
                { 
                    sb.AppendLine(((AutoF1)item).MostarDatos());
                }
                else if (item.GetType() == typeof(MotoCross))
                {
                    sb.AppendLine(((MotoCross)item).MostarDatos());
                }
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
        /// <returns>true si es parte de la competencia o si difieren del tipo</returns>
        public static bool operator == (Competencia competencia,VehiculoDeCarrera vehiculo)
        {
            bool esParte = false;
            if (competencia is not null && vehiculo is not null)
            {
                //Me fijo el tipo de competencia sea coincidente y que el vehiculo sea de una clase o la otra
                if ((competencia.TipoCompetencia == TipoCompetencia.F1 && vehiculo.GetType() == typeof(AutoF1))
                    || (competencia.TipoCompetencia == TipoCompetencia.MotoCross && vehiculo.GetType() == typeof(MotoCross)))
                {
                    if (competencia._competidores.Count > 0)//Me fijo q hayan competidores
                    {
                        foreach (VehiculoDeCarrera item in competencia._competidores)
                        {
                            if (vehiculo == item)//Utilizo la sobrecarga
                            {
                                esParte = true;
                                break;
                            }
                        }
                    }
                }
                else
                    esParte = true;
            }
            return esParte;
        }

        public static bool operator !=(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            return !(competencia == vehiculo);
        }

        /// <summary>
        /// Me permite sacar a un competidor de la lista.
        /// </summary>
        /// <param name="competencia"></param>
        /// <param name="autoF1"></param>
        /// <returns></returns>
        public static bool operator -(Competencia competencia, VehiculoDeCarrera vehiculoDeCarrera)
        {
            bool saco = false;
            if(competencia is not null && vehiculoDeCarrera is not null)
            { 
                if (competencia == vehiculoDeCarrera)
                {
                    competencia._competidores.Remove(vehiculoDeCarrera);//Metodo Remove(), lo saco de la lista
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
        public static bool operator + (Competencia competencia, VehiculoDeCarrera vehiculoDeCarrera)
        {
            bool pudoAgregar = false;
            if(competencia is not null && vehiculoDeCarrera is not null)
            {
                if (competencia._competidores.Count < competencia._cantidadCompetidoes && competencia != vehiculoDeCarrera)
                {
                    competencia._competidores.Add(vehiculoDeCarrera);//Lo añado a la lista
                    vehiculoDeCarrera.EnCompetencia = true;//el competidor cambiará su estado enCompetencia a verdadero
                    vehiculoDeCarrera.VueltasRestantes = competencia._cantidadVueltas;//la cantidad de vueltasRestantes será igual a la cantidadVueltas de Competencia
                    Random random = new Random();
                    vehiculoDeCarrera.CantidadCombustible = (short)random.Next(15, 100);//se le asignará un número aleatorio entre 15 y 100 a cantidadCombustible
                    
                    pudoAgregar = true;
                } 
            }
            return pudoAgregar; 
        }
        #endregion
    }
}
