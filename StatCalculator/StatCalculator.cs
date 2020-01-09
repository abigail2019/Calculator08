using BasicCalculator;
using System;
using StatOperations2;


namespace StatCalculator
{
    public class StatCalculator : Calculator
    {
        public dynamic Mean(dynamic values)
        {

            return StatOperations2.StatOperations.Mean(values);
        }

    }
}
