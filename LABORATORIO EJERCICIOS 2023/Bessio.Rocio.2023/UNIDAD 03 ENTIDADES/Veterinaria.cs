using System.Text;

namespace UNIDAD_03_ENTIDADES
{
    public class Veterinaria
    {
        #region Atributos
        public int capacidad;
        public List<Clientes> listaClientes;
        #endregion

        #region Constructores
        public Veterinaria()
        {
            this.listaClientes = new List<Clientes>();
            this.capacidad = 4;
        }

        public Veterinaria(int capacidad, List<Clientes> listClientes) : this()
        {
            this.listaClientes = listClientes; ;
            this.capacidad = capacidad;
        }

        #endregion

        #region Métodos
        public bool buscarMascota(Clientes m)
        {
            bool esta = false;
            foreach (Clientes item in this.listaClientes)
            {
                if (item == m)
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }

        public bool Agregar(Clientes m)
        {
            bool agrega = false;
            if (this.listaClientes.Count < this.capacidad)
            {
                if (!this.buscarMascota(m))
                {
                    this.listaClientes.Add(m);
                    agrega = true;
                }
                else
                {
                    Console.WriteLine("Ya se encuentra en la veterinaria\n");
                }
            }
            else
            {
                Console.WriteLine("No hay lugar en la veterinaria!\n");
            }
            return agrega;
        }

        public bool Eliminar(Clientes m)
        {
            bool elimina = false;
            for (int i = 0; i < this.listaClientes.Count; i++)
            {
                if (this.listaClientes[i] == m)
                {
                    this.listaClientes.RemoveAt(i);
                    elimina = true;
                    break;
                }
            }
            return elimina;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Clientes item in this.listaClientes)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }
        #endregion
    }
}