﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_03
{
    public class Conductores
    {
        #region ATRIBUTOS
        private int dias;
        private double[] kilometros;
        private string nombre;
        #endregion

        #region PROPIEDADES
        public int Dias { get { return this.dias; } set { this.dias = value; } }
        public double[] Kilometros { get { return this.kilometros; } set { this.kilometros = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado.
        /// </summary>
        /// <param name="dias"></param>
        /// <param name="nombre"></param>
        /// <param name="kilometros"></param>
        public Conductores(int dias,string nombre,double[] kilometros)
        {
            this.dias =dias;
            this.nombre =nombre;
            this.kilometros=kilometros;
        }
        #endregion

        #region METODOS 
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.nombre}");
            for (int i = 0;i<= this.dias;i++)
            {
                stringBuilder.AppendLine($" DIA {i}: {this.kilometros[i]} ");
            }
            return stringBuilder.ToString();
        }
        #endregion

    }
}
