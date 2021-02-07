using Microsoft.VisualStudio.TestTools.UnitTesting;
using elab;
using System;
using System.Collections.Generic;
using System.Text;

namespace elab.Tests
{
    [TestClass()]
    public class ArrayMethodTests
    {
        [TestMethod()]
        public void GetCountTest()
        {
            ArrayMethod arrayMethod = new ArrayMethod();
            Assert.AreEqual(10, arrayMethod.GetCount(new int[] { 4, 4, 5, 8, 5, 3, 6 }));
            Assert.AreEqual(12, arrayMethod.GetCount(new int[] { 1, 5, 9, 10, 5 }));
            Assert.AreEqual(6, arrayMethod.GetCount(new int[] { 2, 5, 2, 7 }));
            Assert.AreEqual(1, arrayMethod.GetCount(new int[] { 1, 2, 3 }));
            Assert.AreEqual(1, arrayMethod.GetCount(new int[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 2 }));
            Assert.AreEqual(-1, arrayMethod.GetCount(new int[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
            Assert.AreEqual(0, arrayMethod.GetCount(new int[] { 2 }));
            Assert.AreEqual(4, arrayMethod.GetCount(new int[] { 2,6 }));
            Assert.AreNotEqual(0, arrayMethod.GetCount(new int[] { 1,5 }));
            Assert.AreEqual(2, arrayMethod.GetCount(new int[] { 4, 7, 7 }));
        }
    }
}