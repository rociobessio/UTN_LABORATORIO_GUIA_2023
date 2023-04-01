using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_DE_CLASES__EL_DISPOSITIVO_
{
    public class AppMusical : Aplicacion
    {
        #region ATRIBUTOS
        private List<string> listaCanciones;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Override de la propiedad TAmanaio de la Clase base (Apliacion).
        /// retorna el tamaño de la app, el cual crecerá en base a la cantidad de
        /// canciones que tenga cargada.Por cada canción cargada, su tamaño crecerá en 2mb más.
        /// 
        /// El .Count cuenta la cantidad de canciones de la lista y lo multiplica por 2mb
        /// y se lo sumamos al tamanio de la aplicacion.
        /// /// </summary>
        protected override int Tamanio { get {
                int tamCanciones = listaCanciones.Count * 2;
                return tamanioMB + tamCanciones; } }
        #endregion

        #region CONSTRUCTORES
        //Creamos sobrecargas flexibles. No siempre es necesario sobrecargar todos los datos.
        //Ademas se reutiliza para poder hacer validaciones.

        /// <summary>
        /// Constructor parametrizado que hereda de la clase Aplicacion.
        /// Reutilizo el segundo constructor que recibe la lista y la instancia.
        /// le paso null
        /// A veces la lista no es necesaria pero si el resto de atributos por eso
        /// utilizamos dos constructores.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="so"></param>
        /// <param name="tamanio"></param>
        public AppMusical(string nombre,SistemaOperativo so, int tamanio)
            : this(nombre,so,tamanio,null)//Se puede poner tambien new List<string>() pero creo una instancia
        { 
        }

        public AppMusical(string nombre, SistemaOperativo so, int tamanio, List<string> listaCanciones)
            : base(nombre, so, tamanio)
        {
            if(listaCanciones is null)
                //si es null la instancio, me evito errores.
                this.listaCanciones = new List<string>();
            else
                this.listaCanciones = listaCanciones;//Si no es null lo asigno
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Se llama igual que el de la clase base. Asi que es override.
        /// Si no hago base. entro en algo recursivo y deriva en un StackOverFlow (not nice)
        /// </summary>
        /// <returns></returns>
        public override string ObtenerInformacionApp()
        {
            StringBuilder sb    = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());//Llamo al metodo de la clase base para obtener la info de la app.
            sb.AppendLine($"{Environment.NewLine}LISTA DE CANCIONES: ");
            foreach (string item in listaCanciones)//Obtengo las canciones y por cada una muetro la cancion.
            {
                sb.AppendLine(item);
            } 
            return sb.ToString();
        }
        #endregion
    }
}
