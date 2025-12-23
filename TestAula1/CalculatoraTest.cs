using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aula_1_1;

namespace TestAula1
{
    [TestClass]
    public class CalculatoraTest
    {
        [TestMethod]
        public void SomaTest()
        {
            //Arrange
            int x = 3;
            int y = 2;
            int expected = 6;
            //Calculadora cs = new Calculadora();

            //Act
            int a = Calculadora.Soma(x, y);

            //Assert

            Assert.AreEqual(expected, a, 0.001, "Calculadora dos Xineses");
        }

        [TestMethod]
        public void SubTest()
        {
            //Arrange
            int x = 12;
            int y = 23;
            int expected = 10;

            //Act

            int res = Calculadora.Sub(x, y);

            //Assert
            Assert.AreEqual(expected, res, 0.001, "Calculadora dos Xineses");
        }

        [TestMethod]
        [DataRow(1, 2, 2)]
        [DataRow(2, 3, 5)]
        [DataRow(3, 5, 8)]
        public void SomaTestAll(int x, int y, int res)
        {
            Assert.AreEqual(res, x + y);
        }
    }
}
