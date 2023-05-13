using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_DE_CLASES_PP__SISTEMA_SOLAR_
{
    public class SistemaSolar
    {
        #region ATRIBUTOS
        private List<Astro> _planetas;
        #endregion

        #region PROPIEDAD
        public List<Astro> Planetas { get { return _planetas; } set { this._planetas = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Posee un solo constructor sin parámetros.
        /// </summary>
        public SistemaSolar()
        {
            this._planetas = new List<Astro>();
        }
        #endregion

        #region METODOS
        /// <summary>
        /// MostrarInformacionAstros(): método que retorna toda la información de los planetas, y sus satélites.
        /// </summary>
        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" PLANETAS ");
            foreach (Astro item in this._planetas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public Dictionary<int, string> ListarPlanetas()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            int index = 0;
            foreach (Planeta p in this._planetas)
            {
                index = dic.Count;
                if (!(p is null))
                {
                    //Console.WriteLine("No es null");
                    if (!(dic.ContainsKey(index)))
                    {
                        //Console.WriteLine("No existe el indice");
                        dic.Add(index, (string)p);
                    }
                }
            }
            return dic;
        }
        #endregion
    }
}
