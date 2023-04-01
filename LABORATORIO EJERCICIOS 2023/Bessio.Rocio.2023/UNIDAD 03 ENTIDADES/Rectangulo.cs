using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIDAD_03_ENTIDADES
{
    public class Rectangulo
    {
        #region ATRIBUTOS
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        #endregion

        #region CONSTRUCTOR
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            //this.vertice2 = Math.Abs((decimal)this.vertice1);
        }
        #endregion
    }
}
