using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SqTests
    {
        private readonly int a = 15;
        private readonly double c = 7.6;
        private readonly double[] e = { 6.2, 1.5, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };

        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(225, Sq.Squared(a));
        }

        [TestMethod()]
        public void SquaredDoubleTest()
        {
            Assert.AreEqual(57.76, Sq.Squared(c));
        }

        [TestMethod()]
        public void SquaredDoubleArrayTest()
        {
            double[] x = new double[e.Length];
            int i = 0;
            foreach(double a in e){
                x[i] = Sq.Squared(a);
                i++;
            }
            Assert.AreEqual(x, Sq.Squared(e));
        }

        [TestMethod()]
        public void SquaredIntArrayTest()
        {
            int[] y = new int[f.Length];
            int i = 0;
            foreach (int a in f)
            {
                y[i] = Sq.Squared(a);
                i++;
            }
            Assert.AreEqual(y, Sq.Squared(f));
        }
    }
}