using ENTIDADES_LA_CENTRALITA;

namespace EJERCICIO_C01_UNIDAD_09
{
    public partial class FrmCentral : Form
    {
        #region ATRIBUTOS
        FrmMostrar frmMostrar;
        FrmLlamador frmLlamador;
        Centralita centralita;
        #endregion

        public FrmCentral()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            centralita = new Centralita("CENTRALITA CALL CENTER");

            Local l1 = new Local("3452345", 30, "23452345", (float)2.65);
            Local l1b = l1;
            Provincial l2 = new Provincial("53452345", Provincial.Franja.Franja_1, 15, "#546745634");
            Local l3 = new Local("6785678", 40, "6345346", (float)2.65);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            this.centralita = centralita + l1;
            this.centralita = centralita + l1b;
            this.centralita = centralita + l2;
            this.centralita = centralita + l3;
            this.centralita = centralita + l4;

            frmMostrar = new FrmMostrar(centralita);
        }

        private void FrmCentral_Load(object sender, EventArgs e)
        {
            this.Text = "Central Telefónica";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Me permite cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea finalizar el programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Si se presiona el botón btnGenerarLlamada abrir un nuevo formulario de forma modal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            frmLlamador = new FrmLlamador(centralita);
            frmLlamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Local;//El tipo de llamada asigo todas
            frmMostrar.ShowDialog();//Lo muestro de forma modal
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        { 
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;//El tipo de llamada asigo todas
            frmMostrar.ShowDialog();//Lo muestro de forma modal
        }
    }
}