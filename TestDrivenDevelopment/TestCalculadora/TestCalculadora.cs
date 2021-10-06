using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
using Excepciones;

namespace TestCalculadora
{
    [TestClass]
    public class TestCalculadora
    {
        [TestMethod]
        public void Add_RecibeStringVacio_DeberiaDevolverCero()
        {
            //Arrange
            string numeros = string.Empty;
            int expected = 0;

            //Act
            int actual = Calculadora.Calculadora.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_RecibeUnUno_DeberiaDevolverUno()
        {
            //Arrange
            string numeros = "1";
            int expected = 1;

            //Act
            int actual = Calculadora.Calculadora.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_RecibeUnUnoComaDos_DeberiaDevolverDos()
        {
            //Arrange
            string numeros = "1,2";
            int expected = 3;

            //Act
            int actual = Calculadora.Calculadora.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_RecibeCincoComaTresComaOcho_DeberiaDevolverDieciseis()
        {
            //Arrange
            string numeros = "5,3,8";
            int expected = 16;

            //Act
            int actual = Calculadora.Calculadora.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_RecibeUnoBarraEneDosComaTres_DeberiaDevolverSeis()
        {
            //Arrange
            string numeros = "1\n2,3";
            int expected = 6;

            //Act
            int actual = Calculadora.Calculadora.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_RecibeDobleBarraPuntoYComaBarraEneDosPuntoYComaTres_DeberiaDevolverCinco()
        {
            //Arrange
            string numeros = "//;\n2;3";
            int expected = 5;

            //Act
            int actual = Calculadora.Calculadora.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //[ExpectedException(typeof(NegativoNoPermitidoException))]
        //[TestMethod]
        //public void Add_RecibeDobleBarraPuntoYComaBarraEneDosPuntoYComaMenosTres_DeberiaTirarNegativoNoPermitidoException()
        //{
        //    //Arrange
        //    string numeros = "//;\n2;-3";

        //    //Act
        //    int actual = Calculadora.Calculadora.Add(numeros);
        //}
    }
}
