using System.Runtime;
using UNIDAD_04__SOBRECARGA_;
using UNIDAD_04_ENTIDADES;
using System.Media;

namespace EJERCICIO_C01_UNIDAD_05
{
    public partial class FrmMonedas : Form
    {
        #region ATRIBUTOS
        private bool lockedImage;
        Dolar dolar;
        Euro euro;
        Pesos pesos;
        //SoundPlayer soundPlayer;
        #endregion

        /// <summary>
        /// En el constructor:
        /// Le cambio el texto a este, lo centro a la pantalla.
        /// Instacio Dolar,Pesos,Euro y la imagen (comienza desbloqueada)
        /// </summary>
        public FrmMonedas()
        {
            InitializeComponent();
            this.Text = "Conversor";
            this.StartPosition = FormStartPosition.CenterScreen;
            dolar = new Dolar(0);
            euro = new Euro(0);
            pesos = new Pesos(0);

            lockedImage = true;
            //soundPlayer = new SoundPlayer();
//  this.btnImageLock.ImageList. = "C:\\Users\\Rocio\\Desktop\\C#\\EJERCICIOS 2023\\UTN_LABORATORIO_GUIA_2023\\LABORATORIO EJERCICIOS 2023\\Bessio.Rocio.2023\\Imagenes-Iconos";
        }

        /// <summary> 
        /// Quito el boton d maximixar y minimizar, y que pueda agrandarlo.
        /// Tambien desactvo el ingreso por los textbox de cotizacion, ya que seran solo
        /// para mostrar los datos y no ingresarlos.
        /// 
        /// Obtengo la cantidad de las monedas (las casillas de arriba del todo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMonedas_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.tbCotDolarADolar.Enabled = false;
            this.tbCotDolarAEuro.Enabled = false;
            this.tbCotDolarAPeso.Enabled = false;
            this.tbCotEuroADolar.Enabled = false;
            this.tbCotEuroAPesos.Enabled = false;
            this.tbCotizarEuroaEuro.Enabled = false;
            this.tbCotPesoADolar.Enabled = false;
            this.tbCotPesoAEuro.Enabled = false;
            this.tbCotPesoAPeso.Enabled = false;

            this.tbCotizacionDolar.Text = dolar.GetCantidad().ToString();
            this.tbCotizacionEuro.Text = euro.GetCantidad().ToString();
            this.tbCotizacionPeso.Text = pesos.GetCantidad().ToString();

            this.tbDolar.Text = Dolar.GetCotizacion().ToString();
            this.tbEuro.Text = Euro.GetCotizacion().ToString();
            this.tbPeso.Text = Pesos.GetCotizacion().ToString();
        }

        /// <summary>
        /// Al presionar el boton la imagen se bloquea o desbloquea,
        /// habilitando los tb de cotizaciones para su modificacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImageLock_Click(object sender, EventArgs e)
        {
            if (lockedImage == true)
            {
                this.tbDolar.ReadOnly = true;
                this.tbEuro.ReadOnly = true;
                this.tbPeso.ReadOnly = true;
                lockedImage = false;
                this.btnImageLock.Text = "LOCKED";
            }
            else
            {
                this.tbDolar.ReadOnly = false;
                this.tbEuro.ReadOnly = false;
                this.tbPeso.ReadOnly = false;
                lockedImage = true;
                this.btnImageLock.Text = "UNLOCKED";
            }
        }

        /// <summary>
        /// Evento d cambio de foco.
        /// Obtengo la cantidad ingresada por el usuario y se lo paso a euro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCotizacionEuro_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            double.TryParse(this.tbCotizacionEuro.Text, out aux);
            euro = new Euro(aux);
        }

        /// <summary>
        /// Me permite mostrar en los textbox las cotizaciones del Euro 
        /// gracias a la sobrecarga de operadores explicitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCotizarEuro_Click(object sender, EventArgs e)
        {
            this.tbCotizarEuroaEuro.Text = euro.GetCantidad().ToString();
            this.tbCotEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString();
            this.tbCotEuroAPesos.Text = ((Pesos)euro).GetCantidad().ToString();
        }

        /// <summary>
        /// Evento d cambio de foco.
        /// Obtengo la cantidad ingresada por el usuario y se lo paso a dolar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCotizacionDolar_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            double.TryParse(this.tbCotizacionDolar.Text, out aux);
            dolar = new Dolar(aux);
        }

        /// <summary>
        /// Me permite mostrar en los textboxes las cotizaciones respecto al dolar
        /// gracias a la sobrecarga de operadores explicitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCotizarDolar_Click(object sender, EventArgs e)
        {
            this.tbCotDolarADolar.Text = dolar.GetCantidad().ToString();
            this.tbCotDolarAEuro.Text = ((Euro)dolar).GetCantidad().ToString();
            this.tbCotDolarAPeso.Text = ((Pesos)dolar).GetCantidad().ToString();
        }

        /// Evento d cambio de foco.
        /// Obtengo la cantidad ingresada por el usuario y se lo paso a pesos.
        private void tbCotizacionPeso_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            double.TryParse(this.tbPeso.Text, out aux);
            pesos = new Pesos(aux);
        }

        /// <summary>
        /// Me permite mostrar en los textboxes las cotizaciones respecto al dolar
        /// gracias a la sobrecarga de operadores explicitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCotizarPesos_Click(object sender, EventArgs e)
        {
            this.tbCotPesoAPeso.Text = pesos.GetCantidad().ToString();
            this.tbCotPesoAEuro.Text = ((Euro)pesos).GetCantidad().ToString();
            this.tbCotPesoADolar.Text = ((Dolar)pesos).GetCantidad().ToString(); 
            //soundPlayer.SoundLocation = "C:/Users/Rocio/Desktop/C#/EJERCICIOS 2023/UTN_LABORATORIO_GUIA_2023/LABORATORIO EJERCICIOS 2023/Bessio.Rocio.2023/Imagenes-Iconos-Sonidos/CoinSound.wav";
            //soundPlayer.PlayLooping();
        } 
    }
}