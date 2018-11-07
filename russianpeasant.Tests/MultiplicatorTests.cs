using Microsoft.VisualStudio.TestTools.UnitTesting;
using russianpeasant;

namespace russianpeasant.Tests
{
    [TestClass]
    public class MultiplicatorTests
    {
        private readonly Multiplicator multiplicator = new Multiplicator();
        [TestMethod]
        public void Multiply0With0Returns0()
        {
            int actual = multiplicator.Mul(0, 0);
            Assert.AreEqual(0, actual);
        }
    }
}
