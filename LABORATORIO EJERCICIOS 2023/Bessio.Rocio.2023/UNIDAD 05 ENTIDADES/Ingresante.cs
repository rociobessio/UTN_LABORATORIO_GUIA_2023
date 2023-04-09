using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_05_ENTIDADES
{
    public class Ingresante
    {
        #region ATRIBUTOS
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado que me permitira crear una instancia de la clase
        /// Ingresante.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="direccion"></param>
        /// <param name="genero"></param>
        /// <param name="pais"></param>
        /// <param name="cursos"></param>
        /// <param name="edad"></param>
        public Ingresante(string nombre,string direccion,string genero,string pais,string[] cursos,int edad)
        {
            this.cursos = cursos;
            this.nombre = nombre;
            this.genero = genero;
            this.pais = pais;
            this.edad = edad;
            this.direccion = direccion; 
        }
        #endregion

        #region METODO
        /// <summary>
        /// El método Mostrar expondrá todos los atributos de la clase al exterior, 
        /// utilizar StringBuilder e interpolación de strings.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {this.nombre}");
            sb.AppendLine($"DIRECCION: {this.direccion}");
            sb.AppendLine($"GÉNERO: {this.genero}");
            sb.AppendLine($"PAIS: {this.pais}");
            sb.AppendLine($"EDAD: {this.edad}"); 
            sb.AppendLine("       CURSOS");
            for (int i = 0; i < this.cursos.Length; i++)
            {
                sb.AppendLine($"{this.cursos[i]}");
            }
            return sb.ToString();   
        }
        #endregion
    }
}