using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_07_ENTIDADES
{
    public class PuestoDeAtencion
    {
        #region ATRIBUTOS
        private static int numeroActual;
        private Puesto puesto;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// La propiedad estática NumeroActual es la encargada de incrementar en 1 al atributo numeroActual
        /// y luego retornarlo.
        /// </summary>
        static int NumeroActual { get { return PuestoDeAtencion.numeroActual++; } }
        #endregion

        #region CONSTRUCTORES()
        /// <summary>
        /// Se inicializará en el constructor de clase (estático) con valor 0.
        /// </summary>
        static PuestoDeAtencion()
        {
            PuestoDeAtencion.numeroActual = 0;
        }

        public PuestoDeAtencion(Puesto puesto) 
        {
            this.puesto = puesto;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente,
        /// simulará un tiempo de atención mediante el método Sleep de la clase Thread 
        /// (perteneciente al espacio de nombre System.Threading) 
        /// y retornará true para indicar el final de la atención.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool Atender(Cliente cliente)
        {
            bool atendido = false;
            if(cliente is not null)
            {
                Thread.Sleep(3000);//Suspende el hilo principal por 3 milisegundos
                atendido = true;
            }
            return atendido;
        }
        #endregion
    }
}
