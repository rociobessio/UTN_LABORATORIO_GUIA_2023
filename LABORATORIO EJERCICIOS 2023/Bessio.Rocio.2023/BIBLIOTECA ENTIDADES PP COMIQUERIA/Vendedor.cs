using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_ENTIDADES_PP_COMIQUERIA
{
    public class Vendedor
    {
        #region ATRIBUTOS
        private string _nombreUsuario;
        private string _password;//PUEDE SER ALFANUMERICA
        private static List<Vendedor> listVendedores;
        private DateTime fechaActual;
        #endregion

        #region PROPIEDADES
        public string Usuario { get { return this._nombreUsuario; } set { this._nombreUsuario = value; } }

        public string Password { get { return this._password; } set { this._password = value; } }

        #endregion

        #region CONSTRUCTORES
        public Vendedor(string userName, string password )
        {
            this._nombreUsuario = userName;
            this._password = password;
            this.fechaActual = DateTime.Now;
        }

        public Vendedor(string userName, string password,List<Vendedor> listaVendedroes)
            :this(userName,password)
        {
             listVendedores = listaVendedroes; 
        }
        #endregion

        #region METODOS DE CLASE 
        //public static bool LoguearUser(Vendedor v,List<Vendedor> lista)
        //{
        //    bool esIgual = false;
        //    foreach (Vendedor item in lista)
        //    {
        //        if (item == v)
        //        {
        //            esIgual = true;
        //        }
        //    }
        //    return esIgual;
        //} 
        #endregion


        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// DOS USUARIOS SERAN IGUALES SI COINCIDEN SU USERNAME Y PASSWORD
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vendedor v1, Vendedor v2)
        {
            bool esNull = false;
            if (v1 is not null && v2 is not null)
            {
                esNull = ((v1._nombreUsuario == v2._nombreUsuario) && (v1._password == v2._password));
            } 
            return esNull;
        }

        public static bool operator !=(Vendedor v1, Vendedor v2)
        {
            return !(v1 == v2);
        }

        /// <summary>
        /// Castea de manera explicita el Vendedor a string retornando el nombre de usuario
        /// </summary>
        /// <param name="usuario">nombre de usuario</param>
        public static explicit operator string(Vendedor usuario)
        {
            return usuario.ToString();
        }


        ///// <summary>
        ///// Me permite agregar un vendedor a la lista si este no se encuentra
        ///// en ella.
        ///// </summary>
        ///// <param name="v"></param>
        ///// <param name="lista"></param>
        ///// <returns></returns>
        //public static bool operator +( Vendedor v,List<Vendedor> lista)
        //{
        //    bool rta = false;
        //    bool auxVendedor = true;
        //    if (!(v is null) && lista.Count > 0)
        //    {
        //        foreach (Vendedor item in lista)
        //        {
        //            if (item == v)
        //            {
        //                auxVendedor = false;
        //                break;
        //            }
        //        }
        //        if (auxVendedor)
        //        {
        //            lista.Add(v);
        //            rta = true;
        //        }
        //    }
        //    return rta;
        //}
        #endregion

        #region POLIMORFISMO
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Nombre: {this._nombreUsuario}"); 
            texto.AppendLine($"Fecha actual: {this.fechaActual.ToShortDateString()}");
            return texto.ToString();
        }


        public override bool Equals(object obj)
        {
            bool esNull = false;
            if (obj is Vendedor)
            {//Comparo si son iguales con el operador de sobrecarga y casteo
                esNull = this == ((Vendedor)obj);
            }
            return esNull;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
