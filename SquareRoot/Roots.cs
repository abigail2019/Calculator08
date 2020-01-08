using System;
using Operations;

namespace SquareRoot
{
    public interface IRoots
    {
        public dynamic Root(dynamic a);

    }
    public class Roots : IRoots
    {
        public dynamic result;

        public dynamic Root(dynamic a)
        {
            result = SqRt.Root(a);
            return result;
        }
    }
}
