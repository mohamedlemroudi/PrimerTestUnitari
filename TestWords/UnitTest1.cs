using TestNunit;

namespace TestWords
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Sumar dos numeros tipo string
        [Test]
        public void TestSumaString()
        {
            var suma = Words.sumar("3", "4");
            Assert.AreEqual(suma, 7);
        }

        // Sumar dos numeros tipo int
        [Test]
        public void TestSumaInt()
        {
            var suma = Words.sumar(3, 4);
            Assert.AreEqual(suma, 7);
        }

        // Sumar dos palabras 
        [Test]
        public void TestSumaWords()
        {
            Assert.Throws<FormatException>(() => Words.sumar("paraula1", "paraula2"));
        }

        // Sumar dos decimales tipo string
        [Test]
        public void TestSumaDecimals()
        {
            Assert.Throws<FormatException>(() => Words.sumar("3.4", "5"));
        }

        // Suma de numeros negatius
        [Test]
        public void TestSumaNegatiuInt()
        {
            var suma = Words.sumar(-3, -4);
            Assert.AreEqual(suma, -7);
        }

        [Test]
        public void TestSumaNegatiuString()
        {
            var suma = Words.sumar("-3", "-4");
            Assert.AreEqual(suma, -7);
        }

        // Suma cadenes buides o nuls
        [Test]
        public void TestSumaCadenasBuides()
        {
            Assert.Throws<FormatException>(() => Words.sumar("", "4"));
        }

        //[Test]
        public void TestSumaCadenasAmbNulls()
        {
            Assert.Throws<FormatException>(() => Words.sumar(null, "4"));
        }

        // Sumar cadenes que contenen espais
        [Test]
        public void TestSumaCadenasAmbEspais()
        {
            var suma = Words.sumar("3 ", "4");
            Assert.AreEqual(suma, 7);
        }

        // Sumar el valor més alt posible per un "int"
        [Test]
        public void TestSumaOverflowInt()
        {
            Assert.Throws<OverflowException>(() => Words.sumar(int.MaxValue, 2));
        }

        // Sumar el valor minim posible per un "int" més -1
        [Test]
        public void TestSumaUnderflowInt()
        {
            Assert.Throws<OverflowException>(() => Words.sumar(int.MinValue, -1));
        }
    }
}





