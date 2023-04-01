using System.Text;

namespace BIBLIOTECA_DE_CLASES__EL_DISPOSITIVO_
{
    public abstract class Aplicacion
    {
        // * = significa protected

        #region ATRIBUTOS
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMB;
        #endregion

        #region PROPIEDADES
        public SistemaOperativo SistemaOperativo { get { return this.sistemaOperativo; } }
        protected abstract int Tamanio { get; }//Al ser abstracta no se puede desarrollar, es solo su declaracion para posterior desarrollo. 
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor parametrizado que me permite crear una instancia
        /// del objeto Aplicacion.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="sistema"></param>
        /// <param name="tamanio"></param>
        protected Aplicacion(string nombre,SistemaOperativo sistema,int tamanio)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistema;
            this.tamanioMB = tamanio;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Recibe una lista de aplicaciones y devuelve la
        /// instancia de mayor peso.
        /// </summary>
        /// <param name="listaApp"></param>
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            Aplicacion appMasPesada = null; //Incializo en null, para usarlo como aux.
            foreach (Aplicacion item in listaApp)
            {
                if (appMasPesada is null || item.Tamanio > appMasPesada.Tamanio)//En la primer vuelta, el item sera el mas pesado, a partir de ahi ira comparando en el resto de vuelts.
                {
                    appMasPesada = item;
                }
            }
            return appMasPesada; 
        }

        /// <summary>
        /// La sobreacarga de l operador == devolvera buscara si una palicacion
        /// existe ya en la lista recibida comparando sus nombres.
        /// </summary>
        /// <param name="listApp"></param>
        /// <param name="app"></param>
        /// <returns>TRUE SI EXISTE.</returns>
        public static bool operator == (List<Aplicacion> listApp, Aplicacion app)
        {
            bool existe=false;
            if (listApp is not null || app is not null)
            {
                foreach (Aplicacion item in listApp)//Recorro la lista
                {
                    if(item.nombre == app.nombre)//Si conciden retornara true.
                        existe = true;
                }
            }
            return existe;
        }

        /// <summary>
        /// Reutilizo codigo de la sobrecarga del operador ==
        /// </summary>
        /// <param name="listApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator != (List<Aplicacion> listApp, Aplicacion app)
        {
            return !(listApp == app);
        }

        /// <summary>
        /// La sobrecarga del operador + añadira una nueva aplicacion a la lista, 
        /// siempre y cuando esta no exista previamente. Reutizacion de codigo.
        /// </summary>
        /// <param name="listApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator + (List<Aplicacion> listApp,Aplicacion app)
        {
            bool existe = false;
                if (listApp != app)//Reutilizo codigo, si app no es contenida..
                {
                    listApp.Add(app);//La agrego
                    existe = true;//devuelvo true.  
                } 
            //foreach (Aplicacion item in listApp)
            //{
            //    if (item != app)//Me fijo si son distintas, si lo son
            //    {
            //        listApp.Add(item);//Añado a la lista pasada por parametro.
            //    }
            //}
            return existe;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Muestra la informacion de la aplicacion.
        /// {Environment.NewLine} = Hace salto de linea.
        /// 
        /// Lo hago virtual ya que el mismo metodo sera utilizado en otras clases
        /// heredadas.
        /// </summary>
        /// <returns></returns>
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE DE LA APLICACIÓN: {this.nombre}{Environment.NewLine}  - SO: {this.sistemaOperativo}{Environment.NewLine} - TAMAÑO: {this.tamanioMB}");
            return sb.ToString();
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Sobrecarga del .ToString() devuelve el nombre de la aplicacion.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return nombre;
        }
        #endregion
    }
}