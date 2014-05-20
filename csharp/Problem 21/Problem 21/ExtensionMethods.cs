using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Extension
{
    public static class ExtensionMethods
    {
        public static BigInteger Sum(this List<BigInteger> bigInts)
        {
            BigInteger sum = 0;

            foreach (BigInteger b in bigInts)
                sum += b;

            return sum;
        }
    }
}
