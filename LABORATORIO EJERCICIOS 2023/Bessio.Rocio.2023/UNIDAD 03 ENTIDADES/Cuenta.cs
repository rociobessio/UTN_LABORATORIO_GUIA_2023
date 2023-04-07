using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIDAD_02_ENTIDADES;

namespace UNIDAD_03_ENTIDADES
{
    public class Cuenta
    {
        #region ATRIBUTOS
        private string titular;
        private float cantidad;
        #endregion

        #region PROPIEDAD
        public string Titular { get { return this.titular; } }
        public float Cantidad { get { return this.cantidad; } }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado.
        /// Me permite inicializar todos los atributos.
        /// </summary>
        /// <param name="titular"></param>
        /// <param name="cantidad"></param>
        public Cuenta(string titular, float cantidad)
        {
            this.cantidad = cantidad;
            this.titular = titular;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Retorna una cadena de txto con los datos de la cuenta.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"RAZON TITULAR: {this.titular} - CANTIDAD {this.cantidad}");
            return sb.ToString();
        }

        /// <summary>
        /// Recibe un monto para acreditar en la cuenta, si el monto
        /// es negativo no se hara nada.
        /// </summary>
        /// <param name="montoNuevo"></param>
        /// <returns></returns>
        public bool Ingresar(float montoNuevo)
        {
            bool pudoAgregar = true;
            if (Validador.Validar((int)montoNuevo, 0, 100000))//Reutilizo validador
            {
                this.cantidad += montoNuevo;
            }
            else
                pudoAgregar = false;
            
            return pudoAgregar;
        }

        /// <summary>
        /// Recibe un monto para debitar de la cuenta.
        /// Puede quedar en negativo.
        /// </summary>
        /// <param name="montonRetirar"></param>
        /// <returns></returns>
        public void Retirar(float montonRetirar)
        {
            this.cantidad -= montonRetirar;
        }
        #endregion
    }
}
