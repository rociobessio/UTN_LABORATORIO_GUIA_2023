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
    public partial class Frm2 : Form
    {
        /// <summary>
        /// Le pongo el nombre al Frm.
        /// Le paso el mensaje que imprimira en el label.
        /// </summary>
        /// <param name="cadenaNombre"></param>
        /// <param name="cadenaApellido"></param>
        public Frm2(string titulo, string mensaje)
        {
            InitializeComponent();
            this.lblCadena.Text = mensaje;
            this.Text = titulo;
        }

        /// <summary> 
        /// 
        /// Pongo en false las propiedades para maximizar y
        /// minimizar el form.
        /// 
        /// FormBorderStyle quita que pueda maximizarlas tambien.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
