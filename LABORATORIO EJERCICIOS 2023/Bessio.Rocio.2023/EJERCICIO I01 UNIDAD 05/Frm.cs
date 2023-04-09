using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_I01_UNIDAD_05
{
    public partial class Frm : Form
    {
        #region ATRIBUTO DEL FRM
        Frm2 frm2;
        #endregion

        public Frm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// El evento Load me centra el frm al iniciar el program
        /// y le añade el nombre a este.
        /// 
        /// Pongo en false las propiedades para maximizar y
        /// minimizar el form.
        /// 
        /// FormBorderStyle quita que pueda maximizarlas tambien.
        /// 
        /// Cargo las materias dentro del combo-box mediante un metodo
        /// que cree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();//Centro el Frm al medio de la pantalla
            this.Text = "¡Hola, Windows Forms!";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CargarMateriasCB();
            // this.cbMateriaFav.Enabled = false;//No puede escribir nada dentro del combo-box
        }

        /// <summary>
        /// Al presionar el boton Saludar se debera de abrir el 2do formulario
        /// de forma MODAL.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string mensaje = $"Soy {this.tbNombre.Text} {this.tbApellido.Text} y mi materia favorita es {this.cbMateriaFav.SelectedItem.ToString()}";

            if (this.ValidarDator())//Si devuelve true, muestra 2do form sino no y muestra el msb de error.
            {
                frm2 = new Frm2("Saludo", mensaje);
                frm2.ShowDialog();
            }
        }

        #region METODOS
        /// <summary>
        /// Metodo que me permite cargar al Combo Box los items.
        /// </summary>
        private void CargarMateriasCB()
        {
            this.cbMateriaFav.Items.Add("PROGRAMACION I");
            this.cbMateriaFav.Items.Add("LABORATORIO I");
            this.cbMateriaFav.Items.Add("INGLES I");
            this.cbMateriaFav.Items.Add("MATEMATICAS");
            this.cbMateriaFav.Items.Add("SISTEMA DE PROCESAMIENTO DE DATOS");
            this.cbMateriaFav.Items.Add("ESTADISTICA");
            this.cbMateriaFav.Items.Add("INGLES II");
            this.cbMateriaFav.Items.Add("ARQUITECTURA Y SISTEMAS OPERATIVOS");
            this.cbMateriaFav.Items.Add("METODOLOGIA DE LA INVESTIGACION");
            this.cbMateriaFav.Items.Add("PROGRAMACION II");
            this.cbMateriaFav.Items.Add("LABORATORIO II");
            this.cbMateriaFav.SelectedIndex = 0;//Para que al iniciarse no aparezca en blanco sino que con un valor ya precargado.
        }

        /// <summary>
        /// Metodo que me permite validar si el usuario ingreso algo en los
        /// textbox.
        /// </summary>
        /// <returns></returns>
        private bool ValidarDator()
        {
            bool ingresoValido = true;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ERROR FALTA COMPLETAR EL CAMPO ");
            if (string.IsNullOrEmpty(this.tbNombre.Text))//Me fijo que no se null o vacio el tb de nombre
            {
                ingresoValido = false;
                sb.AppendLine("NOMBRE.");
            }

            if (string.IsNullOrEmpty(this.tbApellido.Text))
            {
                ingresoValido = false;
                sb.AppendLine("APELLIDO.");
            }

            //Si no es true debo mostrar un MessageBox
            if (!ingresoValido)
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ingresoValido;
        }
        #endregion
    }


}