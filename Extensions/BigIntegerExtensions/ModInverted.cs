using System;
using System.Numerics;

namespace Extensions.BigIntegerExtensions
{

    public static partial class BigIntegerExtensions
    {

        public static BigInteger ModInverted(this BigInteger value, BigInteger modulo)
        {
            if (modulo == BigInteger.One)
            {
                return BigInteger.Zero;
            }
            var moduloCopy = modulo;
            var x = BigInteger.One;
            var y = BigInteger.Zero;
            while (value > 1)
            {
                var q = value / modulo;
                var tempModulo = modulo;
                modulo = value % modulo;
                value = tempModulo;
                var tempX = x;
                x = y;
                y = tempX - q * y;
            }
            return x < 0 ? x + moduloCopy : x;
        }

    }

}