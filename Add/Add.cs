using System;
using Operations;

namespace Add
{
    public interface IAdd
    {
        public dynamic Sum(dynamic a, dynamic b);

        public dynamic Sum(dynamic a);

    }
    public class Add : IAdd
    {
        public dynamic result;
        public dynamic Sum(dynamic a, dynamic b)
        {
            result = Addition.Sum(a, b);
            return result;
        }

        public dynamic Sum(dynamic a)
        {
            result = Addition.Sum(a);
            return result;
        }
    }
}
