using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_DELEGADOS_I01
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
            this.Text = "Mostrar";
        }

        /// <summary>
        /// Expondrá un método público llamado ActualizarNombre,
        /// que recibirá por parámetro un valor de tipo string y no 
        /// retornará ningún valor. Dicho método deberá cambiar el valor
        /// de la propiedad Text del control Label con el string sumistrado 
        /// como argumento.
        /// </summary>
        /// <param name="nombre"></param>
        public void ActualizarNombre(string nombre)//-->Podria ser metodo de extension
        {
            if (!string.IsNullOrEmpty(nombre))
                this.lblNombre.Text = nombre;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
