using BinaryGapComputation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryGapTests
{
    [TestClass]
    public class ComputeGapTests
    {
        private IComputeMaxZeros _computeMaxZerosAction;

        [TestInitialize]
        public void Init()
        {
            _computeMaxZerosAction = new ComputeMaxZeros();
        }
        [TestMethod]
        public void ComputeGapForNumberContainingOneBinaryGap()
        {
            var n = 9;
            var binaryGap = ComputeBinaryGap(n);
            Assert.AreEqual(2, binaryGap);

        }
        [TestMethod]
        public void ComputeGapForNumberContainingTwoBinaryGaps()
        {
            var n = 529;
            var binaryGap = ComputeBinaryGap(n);
            Assert.AreEqual(4, binaryGap);
        }

        [TestMethod]
        public void ComputeGapForNumberContainingNoBinaryGapSinceBinaryRepresentationsContainsOnlyOnes()
        {
            var n = 15;
            var binaryGap = ComputeBinaryGap(n);
            Assert.AreEqual(0, binaryGap);
        }

        [TestMethod]
        public void ComputeGapForNumberContainingNoBinaryGapSinceBinaryRepresentationsContainsOnlySingleOne()
        {
            var n = 32;
            var binaryGap = ComputeBinaryGap(n);
            Assert.AreEqual(0, binaryGap);
        }
        private int ComputeBinaryGap(int n)
        {
            var binaryGap = _computeMaxZerosAction.MaxZeros(n);
            return binaryGap;
        }

    }
}
