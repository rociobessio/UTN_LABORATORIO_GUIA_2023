using BIBLIOTECA_ENTIDADES_PP_COMIQUERIA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMS_PP_COMIQUERIA
{
    public partial class FrmComiqueria : Form
    {
        #region ATRIBUTOS
        private Comiqueria comiqueria;
        private Producto producto; 
        private Dictionary<Guid, string> listaProductos;
        #endregion

        public FrmComiqueria()
        {
            InitializeComponent(); 
            this.comiqueria = new Comiqueria();
            //Productos
            Producto producto1 = new Comic("AMAZING SPIDER-MAN 01: SUERTE DE ESTAR VIVO", 5, 560, "Dan Slott", Comic.TipoComic.Occidental);
            Producto producto2 = new Figura("DC FIGURAS 29: STARFIRE", 2, 650.00, 29.00);
            Producto producto3 = new Figura(1, 349.58, 20);
            producto3.Stock = -2; //No debería cambiar el stock. 
            Producto producto4 = new Comic("AKIRA 01 (EDICION CON SOBRECUBIERTA)", 10, 800, "KATSUHIRO OTOMO", Comic.TipoComic.Oriental);
            producto4.Stock = 5; //El stock debería ser 5. 
            Producto producto5 = new Figura(3, 649.58, 20);

            this.comiqueria += producto1;
            this.comiqueria += producto2;
            this.comiqueria += producto3;
            this.comiqueria += producto4;

            //No debería agregar
            this.comiqueria += producto5;

            //Sobrecargas de vender. 
            this.comiqueria.Vender(producto1);
            this.comiqueria.Vender(producto4, 2);

            this.listaProductos = this.comiqueria.ListarProductos();
            this.richTextBox1.Text = this.comiqueria.ListarVentas();
        }

        private void FrmComiqueria_Load(object sender, EventArgs e)
        {
            this.Text = "La comiqueria";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.lstbProductos.DataSource = new BindingSource(this.listaProductos, null);
            this.lstbProductos.DisplayMember = "Value";
            this.lstbProductos.ValueMember = "Key";
        }

        /// <summary>
        /// Manejador del evento Load del formulario. Inicializará el list box de productos. NO MODIFICAR.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            //Si el constructor tiene parámetros de entrada proporcionarle los argumentos que correspondan.
            //El campo "productoSeleccionado" contiene el producto actualmente seleccionado en el listBox de productos. 
            //El campo "comiqueria" contiene la instancia de la comiqueria que se está utilizando. 
            Form ventasForm = new FrmVenta(this.comiqueria, producto);
            DialogResult result = ventasForm.ShowDialog(); //Agregar código para abrir ventasForm de forma MODAL
            if (result == DialogResult.OK)
            {
                this.richTextBox1.Text = this.comiqueria.ListarVentas();
                this.richTextBox1.Text = this.producto.ToString();
            }
        }

        /// <summary>
        /// Manejador del evento SelectedIndexChanged del ListBox de productos. NO MODIFICAR EL CÓDIGO. 
        /// Mantendrá el campo "productoSeleccionado" actualizado con el producto seleccionado actualmente por el usuario.
        /// Y actualizará el texto del richTextBox de detalle. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guid codigoProducto = ((KeyValuePair<Guid, string>)this.lstbProductos.SelectedItem).Key;
            this.producto = this.comiqueria[codigoProducto];
            this.richTextBox1.Text = this.producto.ToString();
        }
    }
}
