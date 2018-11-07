using Microsoft.VisualStudio.TestTools.UnitTesting;
using russianpeasant;

namespace russianpeasant.Tests
{
    [TestClass]
    public class MultiplierTests
    {
        private Multiplier engine;

        [TestInitialize]
        public void Initialize(){
            this.engine = new Multiplier();
        }

        [DataTestMethod]
        [DataRow(-1, -2)]
        [DataRow(0, 0)]
        [DataRow(1, 2)]
        [DataRow(25, 50)]
        [DataRow(-30, -60)]
        public void MultiplyBy2ReturnMultipleOf2(int x, int expected){
            int actual = engine.MultiplyBy2(x);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(-1, 0)]
        [DataRow(0, 0)]
        [DataRow(1, 0)]
        [DataRow(47, 23)]
        [DataRow(23, 11)]
        [DataRow(-5, -2)]
        public void DivideBy2ReturnDivisionBy2(int x, int expected){
            int actual = engine.DivideBy2(x);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(47, 42, 23, 84)]
        public void ExecuteRow(int x, int y, int expectedLeft, int expectedRight){
            (int actualLeft, int actualRight) = engine.ExecuteRow(x, y);

            Assert.AreEqual(expectedLeft, actualLeft);
            Assert.AreEqual(expectedRight, actualRight);
        }
    }
}