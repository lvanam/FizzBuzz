using FizzBuzz.Processor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
 
namespace TestFizzBuzz
{
    [TestClass]
    public class UnitTestFizz
    {
        [TestMethod]
        public void TestFizzCharacter()
        {
            Mock<FizzProcess> fp = new Mock<FizzProcess>("A");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.InvalidItem);
        }

        [TestMethod]
        public void TestFizzNull()
        {
            Mock<FizzProcess> fp = new Mock<FizzProcess>(null);
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.InvalidItem);
        }

        [TestMethod]
        public void TestFizzEmpty()
        {
            Mock<FizzProcess> fp = new Mock<FizzProcess>("");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.InvalidItem);
        }

        [TestMethod]
        public void TestFizzEmptySpace()
        {
            Mock<FizzProcess> fp = new Mock<FizzProcess>(" ");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.InvalidItem);
        }

        [TestMethod]
        public void TestFizzZero()
        {
            Mock<FizzProcess> fp = new Mock<FizzProcess>("0");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.Fizz);
        }

        [TestMethod]
        public void TestFizz()
        {
            Mock<FizzProcess> fp = new Mock<FizzProcess>("12");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.Fizz);
        }

        [TestMethod]
        public void TestFizzNegative()
        {
            Mock<FizzProcess> fp = new Mock<FizzProcess>("-108");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.Fizz);
        }

        [TestMethod]
        public void TestFizzFail()
        {
            string input = "11";
            Mock<FizzProcess> fp = new Mock<FizzProcess>(input);
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, string.Format(Constants.NotDivided,input, fp.Object.Divisor));
        }

        [TestMethod]
        public void TestFizzLongFail()
        {
            string input = "112888877777788871";
            Mock<FizzProcess> fp = new Mock<FizzProcess>(input);
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, string.Format(Constants.NotDivided, input, fp.Object.Divisor));
        }


        [TestMethod]
        public void TestFizzLong()
        {
            string input = "112888877777788836";
            Mock<FizzProcess> fp = new Mock<FizzProcess>(input);
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.Fizz);
        }

       
        [TestMethod]
        public void TestFizzDecimal()
        {
            string input = "12.15";
            Mock<FizzProcess> fp = new Mock<FizzProcess>(input);
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.InvalidItem);
        }

    }
}
