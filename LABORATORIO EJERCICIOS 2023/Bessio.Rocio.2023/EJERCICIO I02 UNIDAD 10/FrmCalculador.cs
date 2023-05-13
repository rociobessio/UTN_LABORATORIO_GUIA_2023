using UNIDAD_10_ENTIDADES___EXCEPCIONES;

namespace EJERCICIO_I02_UNIDAD_10
{
    public partial class FrmCalculador : Form
    {
        public FrmCalculador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Calculador";
        }

        private void FrmCalculador_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.richTextBox1.ReadOnly = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try//Utilizo bloque try - catch para atrapar la excepcion.
            {
                if (string.IsNullOrEmpty(this.txtKilometros.Text) ||
                    string.IsNullOrEmpty(this.txtLitros.Text))
                {
                    //-->Si hubo error lanzo la excepcion de mi clase.
                    throw new ParametrosVaciosException("Alguno de los parametros es incorrecto");
                }

                //-->Si puede, sigue ejecutando...int.parse lanza excepcion si no puede
                this.richTextBox1.Text = $"KM/HS: {Calculador.Calcular(int.Parse(this.txtKilometros.Text),int.Parse(this.txtLitros.Text))}";
            }
            catch(ParametrosVaciosException ex)//-->No puse nada,La atrapo, sino lanzo la generica
            {
                MessageBox.Show(ex.Message);//-->Lanzo el mensaje
            }
            catch(FormatException)//-->Puse letras y no numeros, error de formato.
            {
                MessageBox.Show("No puede ingresar letras, solo números.");//-->Lanzo el mensaje
            }
            catch(DivideByZeroException)//-->Dividi por 0, no se puede
            {
                MessageBox.Show("No se puede dividir por 0.");//-->Lanzo el mensaje
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}