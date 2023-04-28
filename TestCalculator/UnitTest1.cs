using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TestCalculator
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void TestSumC()
        {
            int resultante = Calculadora.Operacion("+", 4, 5);
            Assert.AreEqual(resultante, 9);
        }

        [TestMethod]
        public void TestSumI()
        {
            int resultante = Calculadora.Operacion("+", 4, 5);
            Assert.AreNotEqual(resultante, 8);
        }

        [TestMethod]
        public void TestRestC()
        {
            int resultante = Calculadora.Operacion("-", 5, 4);
            Assert.AreEqual(resultante, 1);
        }

        [TestMethod]
        public void TestRestI()
        {
            int resultante = Calculadora.Operacion("-", 50, 5);
            Assert.AreNotEqual(resultante, 20);
        }

        [TestMethod]
        public void TestMultC()
        {
            int resultante = Calculadora.Operacion("*", 5, 5);
            Assert.AreEqual(resultante, 25);
        }

        [TestMethod]
        public void TestMulttI()
        {
            int resultante = Calculadora.Operacion("*", 4, 4);
            Assert.AreNotEqual(resultante, 20);

        }

        [TestMethod]
        public void TestDivC()
        {
            int resultante = Calculadora.Operacion("/", 5, 5);
            Assert.AreEqual(resultante, 1);
        }

        [TestMethod]
        public void TestDivI()
        {
            int resultante = Calculadora.Operacion("/", 5, 5);
            Assert.AreNotEqual(resultante, 2);

        }

    }
}
