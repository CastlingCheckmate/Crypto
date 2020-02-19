using System.Numerics;

namespace Extensions.BigIntegerExtensions
{

    public static partial class BigIntegerExtensions
    {

        public static int BitLength(this BigInteger value)
        {
            if (value == BigInteger.Zero)
            {
                return 1;
            }
            var bitLength = 0;
            while (value != BigInteger.Zero)
            {
                bitLength++;
                value >>= 1;
            }
            return bitLength;
        }

    }

}