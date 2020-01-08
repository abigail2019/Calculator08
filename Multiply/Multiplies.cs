using System;
using Operations;

namespace Multiply
{
    public interface IMultiplies
    {
        public dynamic Times(dynamic a, dynamic b);

        public dynamic Times(dynamic a);

    }
    public class Multiplies : IMultiplies
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
