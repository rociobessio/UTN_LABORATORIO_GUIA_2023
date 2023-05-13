using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIBLIOTECA_ENTIDADES_PP_COMIQUERIA;

namespace FORMS_PP_COMIQUERIA
{
    public partial class FrmVenta : Form
    {
        #region AATRIBUTOS
        Comiqueria comiqueria;
        Producto producto;
        #endregion

        public FrmVenta(Comiqueria comiqueria, Producto producto)
        {
            InitializeComponent();
            this.comiqueria = comiqueria;
            this.producto = producto;
        }

        /// <summary>
        /// El evento load se encarga de centrar el form.
        /// Quitar el boton para maximizar y minimizar, ponerle nombre
        /// al frm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.Text = "Nueva venta.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.numericUpDownCantidad.Minimum = 1;

            this.lblDescripcion.Text = this.producto.Descripcion;
            lblPrecioFinal.Text = this.MostrarPrecio(this.producto.Precio);
        }

        #region BOTONES
        /// <summary>
        /// El boton close, me permite cerrar este formulario al
        /// presionarlo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Me permite vender si hay stock,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            if(this.producto.Stock < this.numericUpDownCantidad.Value)
            {
                MessageBox.Show("Stock superado, ingrese cantidad menor", "Stock superado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                comiqueria.Vender(this.producto, (int)this.numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
            }
        }
        #endregion

        #region METODO
        /// <summary>
        /// Este metodo privado actualiza el lblPrecioFinal
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        private string MostrarPrecio(double precio)
        {
            return $"Precio Final: ${precio:f}";
        }

        /// <summary>
        /// A medida que se va cambiando la cantidad se ira actualizando el label.
        /// Realiza un calculo entre la cantidad y el precio del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.lblPrecioFinal.Text = this.MostrarPrecio((double)this.numericUpDownCantidad.Value * this.producto.Precio);
        }
        #endregion



    }
}
