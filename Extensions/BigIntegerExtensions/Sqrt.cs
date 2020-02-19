using System;
using System.Numerics;

namespace Extensions.BigIntegerExtensions
{

    public static partial class BigIntegerExtensions
    {

        public static BigInteger Sqrt(this BigInteger value)
        {
            if (value < BigInteger.Zero)
            {
                throw new ArithmeticException("NaN");
            }
            if (value == BigInteger.Zero)
            {
                return 0;
            }
            var bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(value, 2)));
            var root = BigInteger.One << (value.BitLength() / 2);
            while (value < BigInteger.Pow(root, 2) || value > BigInteger.Pow(root + BigInteger.One, 2))
            {
                root += value / root;
                root /= 2;
            }
            return root;
        }

    }

}