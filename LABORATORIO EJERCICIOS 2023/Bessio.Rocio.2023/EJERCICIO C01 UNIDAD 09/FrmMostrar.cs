using ENTIDADES_LA_CENTRALITA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_C01_UNIDAD_09
{
    public partial class FrmMostrar : Form
    {
        #region ATRIBUTOS
        private Llamada.TipoLlamada tipo;
        Centralita centralita1;
        #endregion

        #region PROPIEDAD
        public Llamada.TipoLlamada TipoLlamada { set { this.tipo = value; } }
        #endregion

        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita1 = centralita;
            this.tipo = Llamada.TipoLlamada.Todas;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Mostrar info llamadas";
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.richTextBoxLlamadas.Text = "\n\t :::::::::::::::::::::::::::: FACTURACION ::::::::::::::::::::::::::::\t";
            this.richTextBoxLlamadas.Text += this.centralita1.Mostrar(tipo);
            this.richTextBoxLlamadas.Enabled = false;

        }
    }
}
