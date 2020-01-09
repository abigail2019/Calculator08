using System;
using BasicCalculator;

namespace StatisticsCalculator
{
    public class StatCalculator : Calculator
    {
        public dynamic Mean(dynamic values)
        {
            var sum = Sum(values);
            var valueCount = values.Length;
            result = Quotient(sum, valueCount);
            return result;
        }

    }
}
