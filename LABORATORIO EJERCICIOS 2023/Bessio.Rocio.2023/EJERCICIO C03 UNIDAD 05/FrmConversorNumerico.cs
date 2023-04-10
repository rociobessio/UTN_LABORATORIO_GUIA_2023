using System.Runtime.Intrinsics.X86;
using UNIDAD_03_ENTIDADES;
using UNIDAD_04__SOBRECARGA_;
using UNIDAD_04_ENTIDADES;

namespace EJERCICIO_C03_UNIDAD_05
{
    public partial class FrmConversorNumerico : Form
    {
        #region ATRIBUTOS
        NumeroBinario numeroBinario;
        NumeroDecimal numeroDecimal;
        double binADec;
        string decABin;
        #endregion

        public FrmConversorNumerico()
        {
            InitializeComponent();
            this.Text = "Conversor Numérico";
            this.StartPosition = FormStartPosition.CenterScreen;
            numeroBinario = new NumeroBinario("");
            numeroDecimal = new NumeroDecimal(0);
        }

        private void FrmConversorNumerico_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.tbConvertBinADec.Enabled = false;
            this.tbConvertDecABin.Enabled = false;
        }

        private void tbBin_TextChanged(object sender, EventArgs e)
        {
            string cadena = this.tbBin.Text;
            binADec = numeroBinario.BinarioADecimal(cadena);
        }

        private void btnBinADecimal_Click(object sender, EventArgs e)
        {
            this.tbConvertBinADec.Text = binADec.ToString();
        }

        private void tbDec_TextChanged(object sender, EventArgs e)
        {
            double result = 0;
            double.TryParse(this.tbDec.Text, out result);
            decABin = numeroDecimal.DecimalABinario(result);
        }

        private void btnDecABin_Click(object sender, EventArgs e)
        {
            this.tbConvertDecABin.Text = decABin.ToString();
        }
    }
}