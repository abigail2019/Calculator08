using System;
using Operations;

namespace Square
{
    public interface ISquares
    {
        public dynamic Squared(dynamic a);

    }
    public class Squares : ISquares
    {
        public dynamic result;
    
        public dynamic Squared(dynamic a)
        {
            result = Sq.Squared(a);
            return result;
        }
    }
}
