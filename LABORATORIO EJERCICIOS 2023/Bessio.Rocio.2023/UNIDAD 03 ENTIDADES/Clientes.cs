using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_03_ENTIDADES
{
    public class Clientes
    {
        #region ATRIBUTOS
        private string domicilio;
        private string nombre;
        private string apellido;
        private string telefono;
        private List<Mascota> listaMascota;
        #endregion

        #region PROPIEDADES
        public string Domicilio { get { return this.domicilio; } set { this.domicilio = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public string Telefono { get { return this.telefono; } set { this.telefono = value; } }
        public List<Mascota> ListaMascotas { get { return this.listaMascota; } set { this.listaMascota = value; } }
        #endregion

        #region CONSTRUCTOR 

        /// <summary>
        /// Constructor parametrizado que inicializa todos los atributos
        /// </summary>
        /// <param name="domicilio"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="telefono"></param>
        /// <param name="listaMascotas"></param>
        public Clientes(string domicilio, string nombre, string apellido, string telefono, List<Mascota> listaMascotas)
        {
            this.listaMascota = listaMascotas;
            this.apellido = apellido;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES

        #endregion

        #region METODOS
        /// <summary>
        /// El metodo mostrar justamente mostrara la informacion de los clientes y 
        /// de las mascotas que tenga a cargo.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE CLIENTE: {this.nombre} {this.apellido} - " +
                $"DOMICILIO: {this.domicilio} - TELEFONO: {this.telefono}");
            sb.AppendLine("MASCOTA/S A CARGO");
            foreach (Mascota masc in this.listaMascota)
            {
                sb.AppendLine(masc.Mostrar());
            }
            return sb.ToString();
        }
        #endregion
    }
}
