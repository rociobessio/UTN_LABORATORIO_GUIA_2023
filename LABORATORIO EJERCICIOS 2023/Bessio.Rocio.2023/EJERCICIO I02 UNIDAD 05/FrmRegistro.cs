using System.Runtime.CompilerServices;
using System.Text;
using UNIDAD_05_ENTIDADES;

namespace EJERCICIO_I02_UNIDAD_05
{
    public partial class FrmRegistro : Form
    {
        #region ATRIBUTO
        Ingresante ingresante;
        #endregion

        public FrmRegistro()
        {
            InitializeComponent();
            this.Text = "Registro";
            this.StartPosition = FormStartPosition.CenterScreen;//Lo centro
        }

        #region EVENTOS DEL FORM
        /// <summary>
        /// En el load cargo los items del listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            this.listBoxPaises.Items.Add("Argentina");
            this.listBoxPaises.Items.Add("Chile");
            this.listBoxPaises.Items.Add("Uruguay");
            //Lo que hago es que al iniciar me tome el item d la posicion 0 (Argentina)
            this.listBoxPaises.SelectedIndex = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] curso = { };//Inicializo un array vacio
            string genero = "";

            //for (int i = 0; i < curso.Length; i++)
            //{
            //    if (cbCursoC.Checked)
            //    {
            //        curso[i] = "C"; 
            //    }
            //    else if (cbCursosCSharp.Checked)
            //    {
            //        curso[i] = "C#"; 
            //    }
            //    else if (cbCursosJavaScript.Checked)
            //    {
            //        curso[i] = "JavaScript"; 
            //    }
            //} 

            if (this.rbGeneroFemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (this.rbGeneroMasc.Checked)
                genero = "Masculino";
            else if (this.rbGeneroNoBin.Checked)
                genero = "No Binario";

            if (ValidarIngresoDatos())//Si devuelve true
            {
                ingresante = new Ingresante(this.tbNombre.Text, this.tbDireccion.Text,genero,this.listBoxPaises.SelectedItem.ToString(),curso, (int)this.numericUpDownEdad.Value);
                MessageBox.Show(ingresante.Mostrar(),"INFORMACION INGRESANTE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Este metodo privado me permite validar los datos que ingrese el usuario.
        /// </summary>
        /// <returns></returns>
        private bool ValidarIngresoDatos()
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ERROR CON ");

            #region DETALLES DEL USUARIO
            if (string.IsNullOrEmpty(this.tbNombre.Text))
            {
                esValido = false;
                sb.AppendLine("NOMBRE.");
            }
            if (string.IsNullOrEmpty(this.tbDireccion.Text))
            {
                esValido = false;
                sb.AppendLine("DIRECCIÓN.");
            }

            if (this.numericUpDownEdad.Value < 17)
            {
                esValido = false;
                sb.AppendLine("EDAD (Debe ser mayor a 17).");
            }
            #endregion

            #region GENERO
            if (this.rbGeneroFemenino.Checked == false && this.rbGeneroMasc.Checked == false &&
                this.rbGeneroNoBin.Checked == false)
            {
                esValido = false;
                sb.AppendLine("GÉNERO (No se ha seleccionado el género).");
            }
            #endregion

            //Si no es true debo mostrar un MessageBox
            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return esValido;
        }
        #endregion


    }
}