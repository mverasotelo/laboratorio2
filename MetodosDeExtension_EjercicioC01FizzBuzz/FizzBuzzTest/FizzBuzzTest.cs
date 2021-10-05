using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void FizzBuzz_RecibeNumeroDivisiblePor3y5_DeberiaDevolverFizzBuzz()
        {
            //Arrange
            int numero = 15;
            string expected = "FizzBuzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_RecibeNumeroDivisiblePor3_DeberiaDevolverFizz()
        {
            //Arrange
            int numero = 6;
            string expected = "Fizz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_RecibeNumeroDivisiblePor5_DeberiaDevolverBuzz()
        {
            //Arrange
            int numero = 5;
            string expected = "Buzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_RecibeNumeroNoDivisiblePor3ni5_DeberiaDevolverElNumero()
        {
            //Arrange
            int numero = 2;
            string expected = "2";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
