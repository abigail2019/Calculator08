using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class CbTests
    {
        private readonly int a = 15;
        private readonly double c = 7.5;
        private readonly double[] e = { 6.2, 1.5, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };

        [TestMethod()]
        public void CubedTest()
        {
            Assert.AreEqual(3375, Cb.Cubed(a));
        }

        [TestMethod()]
        public void CubedDoubleTest()
        {
            Assert.AreEqual(421.875, Cb.Cubed(c));
        }
    }
}