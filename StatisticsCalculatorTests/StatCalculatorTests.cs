using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatCalculatorTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            StatCalculator statsCal = new StatCalculator(); //StatCalculator is a class name
            int[] values = { 1, 2,3,4};
            var mean = statsCal.Mean(values);
            Assert.AreEqual(2,mean);
        }
    }
}