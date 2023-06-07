namespace EJERCICIO_DELEGADOS_I01
{
    public partial class FrmPrincipal : Form
    {
        FrmTestDelegados frmTestDelegados;
        FrmMostrar frmMostrar;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text = "Principal";
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;//-->Setteo como parent 

            //-->Le paso el metodo que esta en frmMostrar
            //-->Al instanciar FrmTestDelegados se deberá asociar el delegado al método ActualizarNombre de FrmMostrar.
            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);
            frmTestDelegados.MdiParent = this;

        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();//-->Lo muestro de forma no modal.
        }
    }
}