using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES_LA_CENTRALITA
{
    public class Centralita
    {
        #region ATRIBUTOS
        private List<Llamada> _listaDellamdaas;
        protected string _razonSocial;
        #endregion

        #region PROPIEDADES
        public float GanaciasPorLocal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return this._listaDellamdaas; } }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// La lista sólo se inicializará en el constructor por defecto Centralita
        /// </summary>
        public Centralita()
        {
            this._listaDellamdaas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// CENTRALITA II:
        /// El operador == retornará true si la centralita contiene la llamada en su lista genérica.
        /// Utilizar la sobrecarga del operador == de la clase Llamada.
        /// </summary>
        /// <returns></returns>
        public static bool operator ==(Centralita centralita, Llamada llamada)
        {
            bool esta = false;

            if (!(centralita is null) && !(llamada is null)
                && (llamada is Llamada) && (centralita is Centralita))
            {
                foreach (Llamada item in centralita._listaDellamdaas)
                {
                    if (item == llamada)
                    {
                        esta = true;
                        break;
                    }
                }
            } 
            return esta;
        }

        public static bool operator !=(Centralita centralita, Llamada llamada)
        {
            return !(centralita == llamada);
        }

        /// <summary>
        /// CENTRALITA II:
        /// El operador + invocará al método AgregarLlamada sólo si la llamada no está 
        /// registrada en la Centralita. Utilizar la sobrecarga del operador == de Centralita.
        /// </summary>
        /// <param name="centralita"></param>
        /// <param name="nuevaLlamada"></param>
        /// <returns></returns>
        public static Centralita operator +(Centralita centralita, Llamada nuevaLlamada)
        {
            //Utilizo la sobrecarga del !=, si no esta llamo a agregarLlamada.
            //No verifico si es null o del tipo que recibo ya que lo hace la sobrecarga
             if(centralita != nuevaLlamada)
             {
                centralita.AgregarLlamada(nuevaLlamada);
             }
            return centralita;
        }
        #endregion


        #region METODOS 
        /// <summary>
        /// CENTRALITA II:
        /// El método AgregarLlamada es privado. Recibe una instancia de Llamada y la agrega a la lista de llamadas.
        /// 
        /// Verifico que no sea NULL y que sea del tipo Llamada
        /// </summary>
        /// <param name="nuevaLlamada"></param>
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if (!(nuevaLlamada is null) && (nuevaLlamada is Llamada))
                this._listaDellamdaas.Add(nuevaLlamada);
        }

        /// <summary>
        /// CalcularGanancia será privado. Este método recibe un enumerado TipoLlamada y retornará el valor de lo recaudado,
        /// según el criterio elegido (ganancias por las llamadas del tipo Local, Provincial o de Todas según corresponda).
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumulador = 0;
            Local local;
            Provincial provincial;

            foreach (Llamada item in this._listaDellamdaas)
            {
                if (tipo == Llamada.TipoLlamada.Todas)
                {
                    if (item is Local)
                    {
                        local = (Local)item;//Casteo para utilizar el metodo CalcularCosto    
                        acumulador += local.CostoLlamada;//Acumulo el costo de llamadas locales que estan la lista.
                    }
                    else
                    { 
                        provincial = (Provincial)item;//Casteo para llamar al metodo
                        acumulador += provincial.CostoLlamada;
                    } 
                }
                else if(tipo == Llamada.TipoLlamada.Provincial)
                {
                    if (item is Provincial)//Si no chequeo me rompe el programa
                    {
                        provincial = (Provincial)item;
                        acumulador += provincial.CostoLlamada;
                    }
                }
                else if(tipo == Llamada.TipoLlamada.Local)
                {
                    if(item is Local)
                    {
                        local = (Local)item;
                        acumulador += local.CostoLlamada;
                    }
                }
            }
            return acumulador;
        }

        /// <summary>
        /// El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales y provinciales y
        /// el detalle de las llamadas realizadas.
        /// 
        /// CENTRALITA II:
        /// El método Mostrar pasará a ser privado y será llamado por la sobrescritura del método ToString.
        /// </summary>
        /// <returns></returns>
        public string Mostrar(Llamada.TipoLlamada tipo)
        {
            StringBuilder sb = new StringBuilder();
            Local local;
            Provincial provincial; 

            sb.AppendLine($"\n RAZÓN SOCIAL: {this._razonSocial}");

            //Imprimo la info de las llamadas
            foreach (Llamada llamda in this._listaDellamdaas)
            {
                if (llamda is Local && (tipo == Llamada.TipoLlamada.Todas || tipo == Llamada.TipoLlamada.Local))
                {
                    local= (Local)llamda;//Casteo llamda a local
                    sb.AppendLine(local.ToString());//Utilizo la sobrecarga del .ToString().
                }
                else if (llamda is Provincial && (tipo == Llamada.TipoLlamada.Todas || tipo == Llamada.TipoLlamada.Provincial))
                {
                    provincial = (Provincial)llamda;
                    sb.AppendLine(provincial.ToString());//Utilizo la sobrecarga del .ToString().
                }
            }
            //2.Imprimo las ganancias
            sb.AppendLine("\t\t|------------------------------------|");    
            sb.AppendLine("\t\t|                GANANCIAS              |");
            sb.AppendLine("\t\t|------------------------------------|");
            switch (tipo)
            {
                case Llamada.TipoLlamada.Todas:
                    sb.AppendFormat("\t\t\t  Total: {0}  ", this.GananciasPorProvincial);
                    sb.AppendFormat("\t\t\t  Local: {0}  ", this.GanaciasPorLocal);
                    sb.AppendFormat("\t\t\t  Provincial: {0}  ", this.GananciasPorTotal);
                    break;
                case Llamada.TipoLlamada.Local:
                    sb.AppendFormat("\t\t\t  Local: {0}  ", this.GanaciasPorLocal);
                    break;
                case Llamada.TipoLlamada.Provincial:
                    sb.AppendFormat("\t\t\t  Provincial: {0}  ", this.GananciasPorTotal);
                    break;
            }  
            return sb.ToString();
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// CENTRALITA II:
        /// El método Mostrar pasará a ser privado y será llamado por la sobrescritura del método ToString.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar(Llamada.TipoLlamada.Todas);
        }
        #endregion
    }
}
