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


        #region METODOS 
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
                        acumulador += local.Costo;//Acumulo el costo de llamadas locales que estan la lista.
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
                        acumulador += local.Costo;
                    }
                }
            }
            return acumulador;
        }

        /// <summary>
        /// El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales y provinciales y
        /// el detalle de las llamadas realizadas.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            Local local;
            Provincial provincial;
            Llamada llamada; 

            sb.AppendLine($" RAZÓN SOCIAL: {this._razonSocial}");

            //Imprimo la info de las llamadas
            foreach (Llamada llamda in this._listaDellamdaas)
            {
                if (llamda is Local)
                {
                    local= (Local)llamda;//Casteo llamda a local
                    sb.AppendLine(local.Mostrar());
                }
                else if (llamda is Provincial)
                {
                    provincial = (Provincial)llamda;
                    sb.AppendLine(provincial.Mostrar());
                }
            }
            //2.Imprimo las ganancias
            sb.AppendLine("|-----------------------------------------------|");    
            sb.AppendLine("|                     GANANCIAS                 |");
            sb.AppendLine("|-----------------------------------------------|");
            sb.AppendLine($"|     PROVINCIAL         |         {this.GananciasPorProvincial}        |");
            sb.AppendLine($"|       LOCAL            |         {this.GanaciasPorLocal}       |");
            sb.AppendLine($"|       TOTAL            |         {this.GananciasPorTotal}        |");
            sb.AppendLine("|-----------------------------------------------|");
            return sb.ToString();
        }
        #endregion
    }
}
