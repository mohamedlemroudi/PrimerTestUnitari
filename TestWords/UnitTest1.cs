using TestNunit;

namespace TestWords
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumaString()
        {
            var suma = Words.sumar("3", "4");
            Assert.AreEqual(suma, 7);
        }

        [Test]
        public void TestSumaInt()
        {
            var suma = Words.sumar(3, 4);
            Assert.AreEqual(suma, 7);
        }

        [Test]
        public void TestSumaWords()
        {
            Assert.Throws<FormatException>(() => Words.sumar("paraula1", "paraula2"));
        }

        [Test]
        public void TestSumaDecimals()
        {
            Assert.Throws<FormatException>(() => Words.sumar("3.4", "5"));
        }

        [Test]
        public void TestSumaMax()
        {
            Assert.Throws<Exception>(() => Words.sumar(int.MaxValue, 1));
        }
    }
}





