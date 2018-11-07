using Microsoft.VisualStudio.TestTools.UnitTesting;
using russianpeasant;

namespace russianpeasant.Tests
{
    
    [TestClass]
    public class AccumulatorTests
    {
        private Accumulator accumulator;

        [TestInitialize]
        public void Initialize(){
            this.accumulator = new Accumulator();
        }
        
        [TestMethod]
        public void AccumulateAddsLeftVariable(){
            this.accumulator.Accumulate(5, 20);
            Assert.AreEqual(1, this.accumulator.LeftStack.Count);
        } 

        [TestMethod]
        public void AccumulateAddsRightVariable(){
            this.accumulator.Accumulate(5, 20);
            Assert.AreEqual(1, this.accumulator.RightStack.Count);
        } 

        [TestMethod]
        public void AccumulateAdds5ToLeft(){
            this.accumulator.Accumulate(5, 20);
            Assert.AreEqual(5, this.accumulator.LeftStack.Pop());
        } 

        [TestMethod]
        public void AccumulateAdds20ToRight(){
            this.accumulator.Accumulate(5, 20);
            Assert.AreEqual(20, this.accumulator.RightStack.Pop());
        } 

        [TestMethod]
        public void AccumulateLeftOddNumber(){
            this.accumulator.Accumulate(5, 10);
            Assert.AreEqual(1, this.accumulator.LeftStack.Count);
        }

        [TestMethod]
        public void AccumulateLeftEvenNumber(){
            this.accumulator.Accumulate(10, 20);
            Assert.AreEqual(0, this.accumulator.LeftStack.Count);
        }

        [TestMethod]
        public void AccumulateRightOddNumber(){
            this.accumulator.Accumulate(5, 15);
            Assert.AreEqual(1, this.accumulator.RightStack.Count);
        }

        [TestMethod]
        public void AccumulateRightEvenNumber(){
            this.accumulator.Accumulate(5, 20);
            Assert.AreEqual(1, this.accumulator.RightStack.Count);
        }
        
        [TestMethod]
        public void IsOdd(){
            bool actual = this.accumulator.IsOdd(5);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsEven(){
            bool actual = this.accumulator.IsOdd(10);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SumRightStackEmptyReturns0(){
            int actual = this.accumulator.SumRight();
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void SumRightStackReturnsSum(){
            this.accumulator.Accumulate(5, 20);
            this.accumulator.Accumulate(7, 40);

            int actual = this.accumulator.SumRight();
            Assert.AreEqual(60, actual);
        }

    }
}