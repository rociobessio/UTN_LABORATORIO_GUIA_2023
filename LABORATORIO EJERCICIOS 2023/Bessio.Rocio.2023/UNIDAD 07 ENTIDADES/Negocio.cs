using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_07_ENTIDADES
{
    public class Negocio
    {
        #region ATRIBUTOS
        private PuestoDeAtencion _caja;
        private Queue<Cliente> _clientes;
        private string _nombre;
        #endregion

        #region PROPIEDADES
 /// <summary>
        /// a propiedad Cliente retornará el próximo cliente en la cola de atención en el get. 
        /// El set deberá controlar que el Cliente no figure en la cola de atención, caso contrario lo agregará.
        /// </summary>
        public Cliente Cliente
        {
            get { return _clientes.Dequeue(); }
            set { _ = this + value; }
        }

        /// <summary>
        /// La propiedad ClientesPendientes retornará la cantidad de clientes esperando a ser atendidos.
        /// </summary>
        public int ClientesPendientes { get { return this._clientes.Count; } }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// El constructor privado inicializará la colección y el puesto de atención como Caja1.
        /// </summary>
        private Negocio()
        {
            this._caja = new PuestoDeAtencion(Puesto.caja1);
            this._clientes = new Queue<Cliente>();
        }
        public Negocio(string nombre)
            : this()
        {
            this._nombre = nombre;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// El operador + será el único capaz de agregar un Cliente a la cola de atención. 
        /// Sólo se agregará un Cliente si este no forma parte de la lista. Reutilizar el == de Cliente.
        /// </summary>
        /// <param name="negocio"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool operator + (Negocio negocio,Cliente cliente)
        {
            bool pudoAgregar = false;
            if(negocio is not null && cliente is not null)
            {
                foreach (Cliente client in negocio._clientes)
                {
                    if (!(cliente == client))
                    {
                        negocio._clientes.Enqueue(client);
                        pudoAgregar = true; 
                    }
                }
            }
            return pudoAgregar;
        }

        /// <summary>
        /// El operador == retornará true si el cliente se encuentra en la colección.
        /// </summary>
        /// <param name="negocio"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool operator == (Negocio negocio,Cliente cliente)
        {
            bool estaOno = false;
            if(negocio is not null & cliente is not null)
            {
                foreach (Cliente item in negocio._clientes)
                {
                    if(item == cliente)
                    {
                        estaOno = true;
                    }
                }
            }
            return estaOno;
        }

        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);   
        }

        /// <summary>
        /// El operador ~ generará una atención del próximo cliente en la cola, utilizando la propiedad Cliente y el método Atender de PuestoAtencion. 
        /// Retornará true si pudo realizar la operación completa.
        /// </summary>
        /// <param name="negocio"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool operator ~ (Negocio negocio)
        {
            bool pudo = false;
            if(negocio._clientes.Count > 0)
            {
                pudo = negocio._caja.Atender(negocio.Cliente);
            }
            return pudo;
        }
        #endregion
    }
}
