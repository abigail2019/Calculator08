using System;
using Operations;

namespace Cube
{
    public interface ICube
    {
        public dynamic Cubed(dynamic a);

    }
    public class Cube : ICube
    {
        public dynamic result;

        public dynamic Cubed(dynamic a)
        {
            result = Cb.Cubed(a);
            return result;
        }
    }
}
