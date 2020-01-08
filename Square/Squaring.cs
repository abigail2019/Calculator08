using System;
using Operations;

namespace Square
{
    public interface ISquaring
    {
        public dynamic Squared(dynamic a);

    }
    public class Squaring : ISquaring
    {
        public dynamic result;
    
        public dynamic Squared(dynamic a)
        {
            result = Sq.Squared(a);
            return result;
        }
    }
}
