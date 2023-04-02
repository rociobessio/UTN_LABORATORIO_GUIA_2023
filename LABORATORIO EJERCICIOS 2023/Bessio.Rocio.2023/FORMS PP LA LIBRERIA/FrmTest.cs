using BIBLIOTECA_DE_CLASES_PP__LA_LIBRERIA;

namespace FORMS_PP_LA_LIBRERIA
{
    public partial class FrmTest : Form
    {
        #region ATRBUTOS DEL FORM
        private Vendedor vendedor;
        #endregion

        #region CONTRUCTOR DEL FORM
        public FrmTest()
        {
            InitializeComponent();
            vendedor = new Vendedor("JULIO");
        }
        #endregion

        #region EVENTOS DEL FORM
        private void FrmTest_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";//// No debe poder vender, no tiene stock.
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);//// Debe poder venderse, 5 d stock 
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            //Agrego LOS ITEMS al listboxk
            this.lstStock.Items.Add(p1);
            this.lstStock.Items.Add(p2);
            this.lstStock.Items.Add(p3);
            this.lstStock.Items.Add(p4);
            this.lstStock.Items.Add(p5);
        }

        /// <summary>
        /// Me permite vender un libro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            Publicacion publicacion = lstStock.SelectedItem as Publicacion;
            if (publicacion is not null)
            {
                if (vendedor + publicacion)//Sobrecarga del +, si hay stock vende, si no, no lo hace
                {
                    MessageBox.Show("VENTA REALIZADA", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("NO HAY STOCK", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Me muestra la informacion de las ventas del vendedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.obtenerInformeVentas(vendedor);
        }

        /// <summary>
        /// Me permite preguntarle al usuario si desea cerrar el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿DESEA CERRAR EL FORMULARIO?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                e.Cancel = true;//No lo cierro si la respuesta es distitna de Yes
            }
        }

        /// <summary>
        /// Invoca al evento FormClosing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion



    }
}