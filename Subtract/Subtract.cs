using System;
using Operations;

namespace Subtract
{
    public interface ISubtract
    {
        public dynamic Difference(dynamic a, dynamic b);

        public dynamic Difference(dynamic a);
    }
    public class Subtract : ISubtract
    {
        public dynamic result;
        public dynamic Difference(dynamic a, dynamic b)
        {
            result = Subtraction.Difference(a, b);
            return result;
        }

        public dynamic Difference(dynamic a)
        {
            result = Subtraction.Difference(a);
            return result;
        }
    }
}
