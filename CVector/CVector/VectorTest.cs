using NUnit.Framework;
using System;
namespace CVector
{
    [TestFixture]
    public class VectorTest
    {
        [Test]
        public void BinarySearch()
        {
            Assert.AreEqual(-1, Vector.BinarySearch(new int[] { }, 33));
            Assert.AreEqual(2, Vector.BinarySearch(new int[] {12,15,19,32,37 }, 19));
            Assert.AreEqual(0, Vector.BinarySearch(new int[] {12, 1}, 12));
            Assert.AreEqual(1, Vector.BinarySearch(new int[] {15, 12}, 12));
            Assert.AreEqual(3, Vector.BinarySearch(new int[] {6,10,11,32}, 32));
            Assert.AreEqual(0, Vector.BinarySearch(new int[] {37}, 37));
        }
    }
}
