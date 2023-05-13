using ENTIDADES_LA_CENTRALITA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ENTIDADES_LA_CENTRALITA.Provincial;

namespace EJERCICIO_C01_UNIDAD_09
{
    public partial class FrmLlamador : Form
    {
        #region ATRIBUTOS
        Centralita centralita1;
        Random duracionRandom;
        #endregion 

        #region PROPIEDAD
        /// <summary>
        /// FrmLlamador tendrá una propiedad de sólo lectura que expondrá dicha Centralita,
        /// a fin de volver a ser leída por el formulario de menú una vez terminada la acción.
        /// </summary>
        public Centralita Centralita { get { return this.centralita1; } }
        #endregion

        #region CONSTRUCTOR
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.centralita1 = centralita;
            this.duracionRandom = new Random();
        }
        #endregion

        #region METODOS/EVENTOS
        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Llamador";
            //Quito que pueda escribir en los textboxes
            this.txtNroDestino.Text ="";
            this.txtNroDestino.Enabled = false;
            ///this.txtNroOrigen.ReadOnly = true;

            ////Si la llamada es provincial cb pasa a ser disabled
            this.cbFranja.Enabled = false;
            this.cbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));// Lectura
            //Desabilito los botones
            this.btnLlamar.Enabled = false;
            this.btnLimpiar.Enabled = false;
        }

        /// <summary>
        /// Chequeo que si el nro de destino inicia con #
        /// entonces muestro las franjas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.StartsWith("#"))
            {
                this.cbFranja.Enabled = true;
            }
            else
            {
                this.cbFranja.Enabled = false;
            }
        }

        private void txtNroOrigen_TextChanged(object sender, EventArgs e)
        {
            this.HabilitarBtns();
        }

        /// <summary>
        /// Habilito los botones Llamar y limpiar mediante un Metodo del Frm
        /// </summary>
        private void HabilitarBtns()
        {
            if (this.txtNroDestino.Text != "" && this.txtNroOrigen.Text != "")
            {
                btnLlamar.Enabled = true;
            }

            if (string.IsNullOrEmpty(this.txtNroDestino.Text) || string.IsNullOrEmpty(this.txtNroOrigen.Text))
            {
                btnLimpiar.Enabled = true;
            }
        }
        #endregion

        #region BOTONES NUMEROS
        /// <summary>
        /// Concateno el num 1 al txt de destino
        /// y habilito el boton de llamar  y limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNumUno_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "1";
            this.HabilitarBtns();
        }

        private void btnNumDos_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "2";
            this.HabilitarBtns();
        }

        private void btnNumTres_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "3";
            this.HabilitarBtns();
        }

        private void btnNumCuatro_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "4";
            this.HabilitarBtns();
        }

        private void btnNumCinco_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "5";
            this.HabilitarBtns();
        }

        private void btnNumSeis_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "6";
            this.HabilitarBtns();
        }

        private void btnNumSiete_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "7";
            this.HabilitarBtns();
        }

        private void btnNumOcho_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "8";
            this.HabilitarBtns();
        }

        private void btnNumNueve_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "9";
            this.HabilitarBtns();
        }

        private void btnNumCero_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "0";
            this.HabilitarBtns();
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "#";
            this.HabilitarBtns();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "*";
            this.HabilitarBtns();
        }
        #endregion

        #region BOTONES
        /// <summary>
        /// Limpio el textbox de numero de origen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Clear();
        }

        /// <summary>
        /// Al presionarlo me permite cerrar este form y volver al menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        private void btnLlamar_Click(object sender, EventArgs e)
        {
            float duracion = (float)duracionRandom.Next(1,50);
            if (this.cbFranja.Enabled)
            {
                Provincial.Franja franja;
                Enum.TryParse<Provincial.Franja>(cbFranja.SelectedValue.ToString(), out franja);
                Provincial llamadaProvincial = new Provincial(txtNroOrigen.Text,franja,duracion,this.txtNroDestino.Text);
                centralita1 = centralita1 + llamadaProvincial;//Lo agrego a la lista
            }
            else
            {
                float costo = (float)duracionRandom.Next(5,56)/10;
                Local llamadaLocal = new Local(this.txtNroOrigen.Text,duracion,this.txtNroDestino.Text,costo);
                centralita1 = centralita1 + llamadaLocal;
            }
            this.btnLimpiar_Click(sender, e);
        }
    }
}
