using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA_DE_CLASES_PP__SISTEMA_SOLAR_
{
    public class Planeta : Astro
    {
        #region ATRIBUTOS
        private int _cantidaSatelites;
        private Tipo _tipo;
        private List<Astro> _satelites;
        #endregion

        #region PROPIEDAD
        public List<Astro> Satelites { get { return this._satelites; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Tiene un constructor que recibe los mismos parámetros que el constructor de Astro
        /// </summary>
        /// <param name="duaracion"></param>
        /// <param name="rotacion"></param>
        /// <param name="nombre"></param>
        public Planeta(int duaracion,int rotacion,string nombre)
            : base(duaracion, rotacion,nombre)
        {

        }

        /// <summary>
        /// Otro constructor que agrega cantSatelites y el tipo.
        /// </summary>
        /// <param name="duaracion"></param>
        /// <param name="rotacion"></param>
        /// <param name="nombre"></param>
        /// <param name="cantSatelites"></param>
        /// <param name="tipo"></param>
        public Planeta(int duaracion, int rotacion, string nombre,int cantSatelites,Tipo tipo)
            : this(duaracion,rotacion,nombre)
        {
            this._tipo = tipo;
            this._cantidaSatelites = cantSatelites;
        }
        #endregion

        #region SOBRECARGA
        /// <summary>
        /// Sobre carga del == (Planeta, Satélite) que chequea si el satélite se encuentra en la lista (comparando el
        /// nombre).
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="satelite"></param>
        /// <returns></returns>
        public static bool operator == (Planeta planeta,Satelite satelite)
        {
            bool esta = false;
            if (!(planeta is null) && !(satelite is null))//Verifico que no sean nulos
            {
                foreach (Satelite item in planeta._satelites)
                {
                    if (item.Nombre == satelite.Nombre)
                    {
                        esta = true;
                        break;
                    }
                }
            }
            return esta;
        }

        public static bool operator !=(Planeta planteta, Satelite satelite)
        {
            return !(planteta == satelite);
        }

        /// <summary>
        /// Sobre carga del == (Planeta, Planeta) compara dos planetas por el nombre
        /// </summary>
        /// <param name="planeta1"></param>
        /// <param name="planeta2"></param>
        /// <returns></returns>
        public static bool operator == (Planeta planeta1, Planeta planeta2)
        {
            bool sonIguales = false;
            if (!(planeta1 is null) && !(planeta2 is null))
            {
                sonIguales = planeta1._nombre == planeta2._nombre;
            }
            return sonIguales;
        }

        public static bool operator !=(Planeta planeta1, Planeta planeta2)
        {
            return !(planeta1 == planeta2);
        }

        /// <summary>
        /// Sobrecarga el operador + para agregar un satélite a la lista, como recibe un objeto del tipo Astro debe validar
        /// que sea satélite y no planeta
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="astro"></param>
        /// <returns></returns>
        public static bool  operator +(Planeta planeta, Astro astro)
        {
            bool agrego = false;
            //Verifico que no sean null  y obtengo el tipo de astro
            if (!(planeta is null) && !(astro is null) && (astro.GetType() == Type.GetType("Satelite")))
            {
                planeta.Satelites.Add(astro);//Si es, lo agrego
            }

            return agrego;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Orbitar() retorna el siguiente mensaje "Orbita el planeta: {nombre}"
        /// </summary>
        /// <returns></returns>
        public override string Orbitar()
        {
            return $"Ortbita el planeta: {(string)this}\n";
        }

        /// <summary>
        /// Rotar() método que no sobreescribe el base. Retorna: "Orbita el planeta {nombre}"
        /// </summary>
        /// <returns></returns>
        public new string Rotar() 
        {
            return $"Orbita el planeta: {(string)this}.\n";
        }

        /// <summary>
        /// Sobrecarga del ToString() que retorna la información del objeto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"CANT. SATELITES: {this._cantidaSatelites} - TIPO: {this._tipo}");
            return sb.ToString();
        }
        #endregion
    }
}
