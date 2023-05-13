using BIBLIOTECA_ENTIDADES_PP_COMIQUERIA;
using Microsoft.VisualBasic.Logging;
using System.Text;

namespace FORMS_PP_COMIQUERIA
{
    public partial class FrmLogin : Form
    {
        #region ATRIBUTOS
        List<Vendedor> listaVendedores;
        FrmComiqueria frmComiqueria;
        Vendedor vendedor;
        private bool pudoEjecutarMenu;
        #endregion

        #region CONSTRUCTOR FORM
        public FrmLogin()
        {
            InitializeComponent();
            #region INSTANCIO VENDEDORES
            listaVendedores = new List<Vendedor>();
            listaVendedores.Add(new Vendedor("Lucas", "123"));
            listaVendedores.Add(new Vendedor("Mauro", "123"));
            listaVendedores.Add(new Vendedor("Esteban", "123")); 
            #endregion
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Me permite iniciar sesion si, los campos estan completos y si el usuario existe.
        /// Luego me instancia un nuevo form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        { 
            if (ValidarCampos())
            {
                if (esValidoElUsuario(this.txtUsuario.Text, this.txtContraseña.Text, out vendedor))
                {
                    frmComiqueria = new FrmComiqueria();
                    frmComiqueria.ShowDialog();
                    this.pudoEjecutarMenu = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("EL VENDEDOR NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Me permite registrar un nuevo usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (ValidarRegistroUsuario(this.txtUsuario.Text, this.txtContraseña.Text, out vendedor))
                {
                    MessageBox.Show("USUARIO REGISTRADO!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("EL USUARIO YA EXISTIA!", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.LimpiarTextBoxes();
        }
        #endregion

        #region VALIDACIONES
        /// <summary>
        /// Valida si el usuario esta dentro de la lista de usuarios.
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasenia"></param>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        private bool esValidoElUsuario(string usuario, string contrasenia, out Vendedor vendedor)
        {
            vendedor = new Vendedor(usuario, contrasenia);
            bool retorno = false;

            foreach (Vendedor vendedorAux in listaVendedores)
            {
                if (vendedorAux == vendedor)
                {
                    vendedor = vendedorAux;
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Me permite registrar a un nuevo usuario si este no esta en la lista.
        /// </summary>
        /// <returns></returns>
        private bool ValidarRegistroUsuario(string usuario, string contrasenia, out Vendedor vendedor)
        { 
            bool puede = false; 
            //Si no es valido es porque no esta
            if (!(esValidoElUsuario(usuario,contrasenia,out vendedor)))
            {
                this.listaVendedores.Add(vendedor);
                puede = true;
            } 
            return puede;
        }

        /// <summary>
        /// Me permite validar los textboxes del formulario.
        /// Imprime un Message box con el msj de error.
        /// </summary>
        /// <returns>Retorna true si no hay error.</returns>
        private bool ValidarCampos()
        {
            bool puede = true;
            StringBuilder sb = new StringBuilder();
            //Chequeo que complete los campos
            if (string.IsNullOrEmpty(this.txtUsuario.Text) ||
                string.IsNullOrEmpty(this.txtContraseña.Text))
            {
                sb.Append("FALTO COMPLETAR ALGUN CAMPO.");
                puede = false;
            }

            //Si no es true debo mostrar un MessageBox
            if (!puede)
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return puede;
        }
        #endregion

        #region METODOS / EVENTOS DEL FORM
        /// <summary>
        /// El evento load le da nombre al frm, lo centra a la pantalla,
        /// quita los bordes y los botones de minimizar y maximizar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "LOGIN";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.pudoEjecutarMenu = false;
        }

        /// <summary>
        /// Le pregunta al usuario si desea cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.pudoEjecutarMenu)
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.No == respuesta)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Metodo privado que me permite limpiar los textboxes.
        /// </summary>
        private void LimpiarTextBoxes()
        {
            this.txtContraseña.Clear();
            this.txtUsuario.Clear();
        } 
        #endregion
    }
}