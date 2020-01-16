using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fizzbuzz
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestFizzbuzzOne()
        {
            Assert.AreEqual(1, Fizzbuzz.Result(1));
        }

        [TestMethod]
        public void TestFizzbuzzTwo()
        {
            Assert.AreEqual(2, Fizzbuzz.Result(2));
        }
    }
}
