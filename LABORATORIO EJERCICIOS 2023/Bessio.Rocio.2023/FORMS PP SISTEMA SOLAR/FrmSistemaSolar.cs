using BIBLIOTECA_DE_CLASES_PP__SISTEMA_SOLAR_;
using System.Text;

namespace FORMS_PP_SISTEMA_SOLAR
{
    public partial class FrmSistemaSolar : Form
    {
        #region ATRIBUTOS
        static List<Astro> _planetas;
        SistemaSolar sistemaSolar;
        #endregion

        public FrmSistemaSolar()
        {
            InitializeComponent();
            this.Text = "Bessio Rocio";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.sistemaSolar = new SistemaSolar();
            _planetas = this.sistemaSolar.Planetas;
        }

        private void FrmSistemaSolar_Load(object sender, EventArgs e)
        {
            this.cbTipo.DataSource = Enum.GetValues(typeof(Tipo));
            this.cbTipo.SelectedIndex = 0;

            this.cbPlanetas.Items.Clear();
            foreach (Satelite item in _planetas)
            {
                this.cbPlanetas.Items.Add(item.Nombre);
            }
            //this.cbPlanetas.SelectedIndex = 0;
        }

        #region BOTONES
        /// <summary>
        /// 26. Se debe validar que no se ingresen campos vacíos al agregar un planeta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if (ValidarPlaneta())
            {
                Planeta planeta = new Planeta(int.Parse(this.numRotacion.Text), int.Parse(this.numRotacion.Text), this.txtNombrePlaneta.Text);
                _planetas.Add(planeta);
                sistemaSolar.Planetas = _planetas;

                //Al agregarlo q se actualice
                this.listPlanetas.DataSource = new BindingSource(this.sistemaSolar.ListarPlanetas(), null);
            }

            this.FrmSistemaSolar_Load(sender,e);
        }

        #endregion

        #region VALIDACIONES
        private bool ValidarPlaneta()
        {
            bool ingresoValido = true;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ERROR AL INGRESAR ");
            if (string.IsNullOrEmpty(this.txtNombrePlaneta.Text))
            {
                ingresoValido = false;
                sb.AppendLine("NOMBRE PLANETA. ");
            }
            if (string.IsNullOrEmpty(this.txtOrbitaPlaneta.Text) || (int.Parse(this.txtOrbitaPlaneta.Text) < 0))
            {
                ingresoValido = false;
                sb.AppendLine("VALOR TIEMPO EN COMPLETAR ORBITA. ");
            }

            if (!ingresoValido)
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

            return ingresoValido;
        }


        private bool ValidacionesAstro()
        {
            bool ingresoValido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ERROR AL INGRESAR ");
            if (string.IsNullOrEmpty(this.txtNombreAstro.Text))
            {
                ingresoValido = false;
                sb.AppendLine("NOMBRE ASTRO. ");
            } 
            if (this.numOrbita.Value < 0 || this.numRotacionSatelite.Value < 0)
            {
                ingresoValido = false;
                sb.AppendLine("VALORES NUMERICOS. ");
            }

            if (!ingresoValido)
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ingresoValido;
        }
        #endregion
    }
}