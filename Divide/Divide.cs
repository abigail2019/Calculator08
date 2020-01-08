﻿using System;
using Operations;

namespace Divide
{
    public interface IDivide
    {
        public dynamic Quotient(dynamic a, dynamic b);

        public dynamic Quotient(dynamic a);
    }
    public class Divide : IDivide
    {
        public dynamic result;
        public dynamic Quotient(dynamic a, dynamic b)
        {
            result = Division.Quotient(a, b);
            return result;
        }

        public dynamic Quotient(dynamic a)
        {
            result = Division.Quotient(a);
            return result;
        }
    }
}