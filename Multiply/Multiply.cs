using System;
using Operations;

namespace Multiply
{
    public interface IMultiply
    {
        public dynamic Times(dynamic a, dynamic b);

        public dynamic Times(dynamic a);

    }
    public class Multiply : IMultiply
    {
        public dynamic result;
        public dynamic Times(dynamic a, dynamic b)
        {
            result = Multiplication.Times(a, b);
            return result;
        }

        public dynamic Times(dynamic a)
        {
            result = Multiplication.Times(a);
            return result;
        }
    }
}
