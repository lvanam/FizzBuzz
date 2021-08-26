using FizzBuzz.Processor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
 
namespace TestBuzzBuzz
{
    [TestClass]
    public class UnitTestBuzz
    {
        [TestMethod]
        public void TestBuzzCharacter()
        {
            Mock<BuzzProcess> fp = new Mock<BuzzProcess>("A");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.InvalidItem);
        }

        [TestMethod]
        public void TestBuzzNull()
        {
            Mock<BuzzProcess> fp = new Mock<BuzzProcess>(null);
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.InvalidItem);
        }

        [TestMethod]
        public void TestBuzzEmpty()
        {
            Mock<BuzzProcess> fp = new Mock<BuzzProcess>("");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.InvalidItem);
        }

        [TestMethod]
        public void TestBuzzEmptySpace()
        {
            Mock<BuzzProcess> fp = new Mock<BuzzProcess>(" ");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.InvalidItem);
        }

        [TestMethod]
        public void TestBuzzZero()
        {
            Mock<BuzzProcess> fp = new Mock<BuzzProcess>("0");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.Buzz);
        }

        [TestMethod]
        public void TestBuzz()
        {
            Mock<BuzzProcess> fp = new Mock<BuzzProcess>("15");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.Buzz);
        }

        [TestMethod]
        public void TestBuzzNegative()
        {
            Mock<BuzzProcess> fp = new Mock<BuzzProcess>("-120");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.Buzz);
        }

        [TestMethod]
        public void TestBuzzFail()
        {
            string input = "11";
            Mock<BuzzProcess> fp = new Mock<BuzzProcess>(input);
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, string.Format(Constants.NotDivided,input, fp.Object.Divisor));
        }

        [TestMethod]
        public void TestBuzzLongFail()
        {
            string input = "112888877777788871";
            Mock<BuzzProcess> fp = new Mock<BuzzProcess>(input);
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, string.Format(Constants.NotDivided, input, fp.Object.Divisor));
        }


        [TestMethod]
        public void TestBuzzLong()
        {
            string input = "112888877777788875";
            Mock<BuzzProcess> fp = new Mock<BuzzProcess>(input);
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.Buzz);
        }

        [TestMethod]
        public void TestBuzzDecimal()
        {
            Mock<BuzzProcess> fp = new Mock<BuzzProcess>("15.10");
            Calculate c = new Calculate();
            var expectedResult = c.CalcualteNumber(fp.Object);

            Assert.AreEqual(expectedResult, Constants.InvalidItem);
        }

    }
}
