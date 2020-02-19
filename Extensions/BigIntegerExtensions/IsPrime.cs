using System.Numerics;

namespace Extensions.BigIntegerExtensions
{

    public static partial class BigIntegerExtensions
    {

        public static bool IsPrime(this BigInteger value)
        {
            if (value <= BigInteger.One)
            {
                return false;
            }
            if (value == 2)
            {
                return true;
            }
            if (value % 2 == 0)
            {
                return false;
            }
            var bound = Sqrt(value) + 1;
            for (int i = 3; i <= bound; i += 2)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }

}