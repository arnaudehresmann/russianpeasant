using Microsoft.VisualStudio.TestTools.UnitTesting;
using russianpeasant;

namespace russianpeasant.Tests
{
    [TestClass]
    public class MultiplicatorTests
    {
        private Multiplicator multiplicator;

        [TestInitialize]
        public void Initialize(){
            this.multiplicator = new Multiplicator();
        }


        [TestMethod]
        public void Multiply0With0Returns0()
        {
            int actual = multiplicator.Mul(0, 0);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Multiply1By1Returns1(){
            int actual = multiplicator.Mul(1, 1);
            Assert.AreEqual(1, actual);
        }

        [DataTestMethod]
        [DataRow(47, 42, 1974)]
        [DataRow(0, 42, 0)]
        [DataRow(2, 2, 4)]
        public void TestMultiply(int x, int y, int expected){
            int actual = multiplicator.Mul(x, y);
            Assert.AreEqual(expected, actual);
        }

    }
}
