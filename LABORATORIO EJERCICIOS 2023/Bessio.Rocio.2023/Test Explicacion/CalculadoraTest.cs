using UNIDAD_11_ENTIDADES_UNIT_TEST;

namespace Test_Explicacion
{
    [TestClass]//-->Indica que es clase de test
    public class CalculadoraTest//-->Que se llame igual que la clase que voy testear.
    {
        [TestMethod]//-->Indica que testeo metodo
        //nombreMetodo_CuandoTesteo_QueDeberiaDevolver
        public void Dividir_CuandoElDivisorEsCero_DeberiaRetornarDoubleMinValue()
        {
            //-->Patron AAA 
            //Arrange --> Prepara el caso de prueba
            double divisor = 2;
            Calculadora calculadora = new Calculadora();//-->Instancio la clase.
            double resultadoEsperado = 1;

            //Act --> Invocar al metodo que pruebo.
            double resultado =  calculadora.Dividir(2,divisor);

            //Assert --> Verifico que el resultado sea el esperado
            Assert.AreEqual(resultadoEsperado,resultado);//-->Si son iguales no falla, si falla lanza excepcion.  
        }

        [TestMethod]//-->Indica que testeo metodo
        //nombreMetodo_CuandoTesteo_QueDeberiaDevolver
        public void Dividir_CuandoElDivisorNoEsCero_DeberiaRetornarResultadoDivision()
        {
            //-->Patron AAA 
            //Arrange --> Prepara el caso de prueba
            double divisor = 2;
            Calculadora calculadora = new Calculadora();//-->Instancio la clase.
            double resultadoEsperado = 1.5;

            //Act --> Invocar al metodo que pruebo.
            double resultado = calculadora.Dividir(3, divisor);

            //Assert --> Verifico que el resultado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultado);//-->Si son iguales no falla, si falla lanza excepcion.  
        }
    }
}