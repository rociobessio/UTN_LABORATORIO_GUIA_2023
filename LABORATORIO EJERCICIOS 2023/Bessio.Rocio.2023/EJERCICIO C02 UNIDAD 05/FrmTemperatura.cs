using UNIDAD_04__SOBRECARGA_;
using UNIDAD_04_ENTIDADES;

namespace EJERCICIO_C02_UNIDAD_05
{
    public partial class FrmTemperatura : Form
    {
        #region ATRIBUTOS DEL FORM
        Fahrenheit fahrenheit;
        Kelvin kelvin;
        Celsius celsius;
        #endregion

        #region CONSTRUCTOR 
        /// <summary>
        /// Constructor del frm que le pone el nombre a este, lo centra
        /// e inicializa los atributos.
        /// </summary>
        public FrmTemperatura()
        {
            InitializeComponent();
            this.Text = "Vulcano";
            this.StartPosition = FormStartPosition.CenterScreen;

            fahrenheit = new Fahrenheit(0);
            kelvin = new Kelvin(0);
            celsius = new Celsius(0);
        }
        #endregion

        #region EVENTOS
        /// <summary>
        /// El evento load, me quita los botones de maximizar y minimizar,
        /// ademas quita los bordes del form.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTemperatura_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.tbCelsiusACelsius.Enabled = false;
            this.tbCelsiusAFahrenheit.Enabled = false;
            this.tbCelsiusAKelvin.Enabled = false;
            this.tbFahrenheitACelsius.Enabled = false;
            this.tbFahrenheitAFahrenheit.Enabled = false;
            this.tbFahrenheitAKelvin.Enabled = false;
            this.tbKelvinACelsius.Enabled = false;
            this.tbKelvinAFahrenheit.Enabled = false;
            this.tbKelvinAKelvin.Enabled = false;

            //Obtengo las temperaturas


        }

        /// <summary>
        /// Obtengo los valores del textbox y se lo paso al instancia
        /// del objeto fahrenheit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFahrenheit_TextChanged(object sender, EventArgs e)
        {
            int aux = 0;
            int.TryParse(this.tbFahrenheit.Text, out aux);
            fahrenheit = new Fahrenheit(aux);
        }

        /// <summary>
        /// Al presionar el boton realizo las conversiones de fahrenheit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCovertFahrenheit_Click(object sender, EventArgs e)
        {
            this.tbFahrenheitAFahrenheit.Text = fahrenheit.GetValor.ToString();
            this.tbFahrenheitACelsius.Text = fahrenheit.FahrenheitACelsius().ToString();
            this.tbFahrenheitAKelvin.Text = fahrenheit.FahrenheitAKelvin().ToString();
        }

        /// <summary>
        /// Obtengo de los textbox los valores para darselo a la instancia
        /// del objeto de Celsius.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCelsius_TextChanged(object sender, EventArgs e)
        {
            int aux = 0;
            int.TryParse(this.tbCelsius.Text, out aux);
            celsius = new Celsius(aux);
        }

        /// <summary>
        /// Al presionar el boton obtengo y muestro las conversiontes de Celsius.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            this.tbCelsiusACelsius.Text = celsius.GetValor.ToString();
            this.tbCelsiusAFahrenheit.Text = celsius.CelsiusAFahrenheit().ToString();
            this.tbCelsiusAKelvin.Text = celsius.CelsiusAKelvin().ToString();
        }

        /// <summary>
        /// Obtengo los bvalores del textbox de Kelvin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbKelvin_TextChanged(object sender, EventArgs e)
        {
            int aux = 0;
            int.TryParse(this.tbKelvin.Text, out aux);
            kelvin = new Kelvin(aux);
        }

        /// <summary>
        /// Convierto e imprimo en los demas textboxes los resultados de 
        /// las conversiones de Kelvin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            this.tbKelvinAKelvin.Text = kelvin.GetValor.ToString();
            this.tbKelvinACelsius.Text = kelvin.KelvinACelsius().ToString();
            this.tbKelvinAFahrenheit.Text = kelvin.KelvinAFahrenheit().ToString();
        }

        #endregion


    }
}