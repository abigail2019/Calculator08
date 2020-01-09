using System;
using Operations;

namespace StatOperations
{
    public class StatOperations
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = Addition.Sum(values);
            var valueCount = values.Length;
            var result = Division.Quotient(sum, valueCount);
            return result;
        }
    }
}
