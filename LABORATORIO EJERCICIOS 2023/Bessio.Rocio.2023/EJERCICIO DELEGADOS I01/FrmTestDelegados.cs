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
    public partial class FrmTestDelegados : Form
    {
        #region ATRIBUTOS - DELEGADOS
        //Se deberá utilizar un delegado dentro de FrmTestDelegados, convenientemente diseñado,
        //a fin de cumplir este punto.
        public delegate void ActualizarNombreDelegado(string nombre);
        private ActualizarNombreDelegado delegados;//-->Delegado
        #endregion

        /// <summary>
        /// Recibe el delegado, el cual es el metodo en Mostrar
        /// </summary>
        /// <param name="actualizarNombreDelegado"></param>
        public FrmTestDelegados(ActualizarNombreDelegado actualizarNombreDelegado)
        {
            this.delegados = actualizarNombreDelegado;
            InitializeComponent();
            this.Text = "Test Delegados";
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Se pide que el usuario ingrese un nombre por el TextBox de FrmTestDelegados
        /// y que al pulsar el botón btnActualizar, se cambie el valor del Label de la 
        /// instancia de FrmMostrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //-->El delegado deberá ser invocado (método Invoke) al presionar el btnActualizar.
            delegados.Invoke(txtNombre.Text);//-->Invoco al delegado
        }
    }
}
