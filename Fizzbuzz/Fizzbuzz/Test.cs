using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fizzbuzz
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestFizzbuzzOne()
        {
            Assert.AreEqual(1, Fizzbuzz.Result<int>(1));
        }

        [TestMethod]
        public void TestFizzbuzzTwo()
        {
            Assert.AreEqual(2, Fizzbuzz.Result<int>(2));
        }

        [TestMethod]
        public void TestFizzbuzzThree()
        {
            Assert.AreEqual("Fizz", Fizzbuzz.Result<string>(3));
        }

        [TestMethod]
        public void TestFizzbuzzFive()
        {
            Assert.AreEqual("Buzz", Fizzbuzz.Result<string>(5));
        }

        [TestMethod]
        public void TestFizzbuzzSix()
        {
            Assert.AreEqual("Fizz", Fizzbuzz.Result<string>(6));
        }

        [TestMethod]
        public void TestFizzbuzzTen()
        {
            Assert.AreEqual("Buzz", Fizzbuzz.Result<string>(10));
        }

        [TestMethod]
        public void TestFizzbuzzFifteen()
        {
            Assert.AreEqual("Fizzbuzz", Fizzbuzz.Result<string>(15));
        }
    }
}
