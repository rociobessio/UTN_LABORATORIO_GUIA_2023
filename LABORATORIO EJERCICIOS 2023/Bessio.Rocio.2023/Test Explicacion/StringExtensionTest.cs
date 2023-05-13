using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIDAD_11_ENTIDADES_UNIT_TEST;

namespace Test_Explicacion
{
    [TestClass]//-->Indica que es clase de test
    public class StringExtensionTest
    {
        [TestMethod]
        //nombreMetodo_CuandoTesteo_QueDeberiaDevolver
        public void ContarVocales_CuandoNoTieneVocales_DeberiaRetornarCero()
        {
            //Arrange --> Prepara el caso de prueba
            int expected = 0;//-->No espero vocales
            string text = "frtjkñ;";

            //Act --> Invocar al metodo que pruebo.
            int actual = StringExtension.ContarVocales(text);

            //Assert --> Verifico que el resultado sea el esperado
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        //nombreMetodo_CuandoTesteo_QueDeberiaDevolver
        public void ContarVocales_CuandoTieneDosVocalesEnMinuscula_DeberiaRetornarDos()
        {
            //Arrange --> Prepara el caso de prueba
            int expected = 2;//-->Espero 2 vocales
            string text = "casa;";

            //Act --> Invocar al metodo que pruebo.
            int actual = StringExtension.ContarVocales(text);

            //Assert --> Verifico que el resultado sea el esperado
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //nombreMetodo_CuandoTesteo_QueDeberiaDevolver
        public void ContarVocales_CuandoTieneTresVocalesEnMayuscula_DeberiaRetornarTres()
        {
            //Arrange --> Prepara el caso de prueba
            int expected = 3;//-->Espero 2 vocales
            string text = "LA COSA;";

            //Act --> Invocar al metodo que pruebo.
            int actual = text.ContarVocales();

            //Assert --> Verifico que el resultado sea el esperado
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //nombreMetodo_CuandoTesteo_QueDeberiaDevolver
        public void ContarVocales_CuandoElTextoEsNulo_DeberiaRetornarCero()
        {
            //Arrange --> Prepara el caso de prueba
            int expected = 0;//-->Espero 2 vocales
            string text = null;

            //Act --> Invocar al metodo que pruebo.
            int actual = StringExtension.ContarVocales(text);

            //Assert --> Verifico que el resultado sea el esperado
            Assert.AreEqual(expected, actual);
        }
    }
}
