using System;
using Operations;

namespace SquareRoot
{
    public interface ISquareRoot
    {
        public dynamic Root(dynamic a);

    }
    public class SquareRoot : ISquareRoot
    {
        public dynamic result;

        public dynamic Root(dynamic a)
        {
            result = SqRt.Root(a);
            return result;
        }
    }
}
