using System;
using Operations;

namespace Cube
{
    public interface ICubes
    {
        public dynamic Cubed(dynamic a);

    }
    public class Cubes : ICubes
    {
        public dynamic result;

        public dynamic Cubed(dynamic a)
        {
            result = Cb.Cubed(a);
            return result;
        }
    }
}
