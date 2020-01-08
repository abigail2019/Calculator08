using System;
using Operations;

namespace Square
{
    public interface ISquare
    {
        public dynamic Squared(dynamic a);

    }
    public class Square : ISquare
    {
        public dynamic result;
    
        public dynamic Squared(dynamic a)
        {
            result = Sq.Squared(a);
            return result;
        }
    }
}
