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
    }
}
