using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_DE_CLASES__EL_DISPOSITIVO_
{
    /// <summary>
    /// Al ser la clase, todos sus miembros tambien deben de serlo.
    /// </summary>
    public static class Dispositivo
    {
        #region ATRIBUTOS
        private static List<Aplicacion> listaAppsInstaladas;
        private static SistemaOperativo sistemaOperativo;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// El constructor estatico iniciara la lista estatica listaAppsInstaladas
        /// y seteara el sistema operativo como ANDROID.
        /// </summary>
        static Dispositivo()
        {
            listaAppsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }
        #endregion

        #region METODOS DE LA CLASE
        /// <summary>
        /// Recibe como parametro la aplicacion a instalar, antes de hacerlo
        /// se tiene que verificar que el sistema operativo sea compatible
        /// para dicha aplicacion.
        /// Si es compatible intentara añadirla a la lista.
        /// Reutilizar codigo.
        /// </summary>
        /// <param name="app"></param>
        /// <returns>Devuelve TRUE si pudo</returns>
        public static bool InstalarApp(Aplicacion app)
        {
            bool esCompatible = false;
            if (sistemaOperativo == app.SistemaOperativo)//Chequeo el SO de la app y del dispositivo
            {
                esCompatible =  listaAppsInstaladas + app;//Si es el mismo, reutilizo el codigo del operador + de la clase Aplicacion
            }
            return esCompatible;
        }

        /// <summary>
        /// mostrará toda la información del dispositivo, y el detalle
        /// de sus aplicaciones instaladas.
        /// </summary>
        /// <returns></returns>
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"SISTEMA OPERATIVO: {sistemaOperativo}{Environment.NewLine}");
            foreach (Aplicacion item in listaAppsInstaladas)
            {
                sb.AppendLine(item.ObtenerInformacionApp());//Aplica tambien con polimorfismo
            }
            return sb.ToString();
        }
        #endregion
    }
}
