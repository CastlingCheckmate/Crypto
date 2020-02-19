using System;
using System.Numerics;

namespace Extensions.BigIntegerExtensions
{

    public static partial class BigIntegerExtensions
    {

        private static Random _randomSource;

        static BigIntegerExtensions()
        {
            _randomSource = new Random();
        }

        public static BigInteger Random(BigInteger upperBound)
        {
            var bytes = upperBound.ToByteArray();
            var result = default(BigInteger);
            do
            {
                _randomSource.NextBytes(bytes);
                bytes[bytes.Length - 1] &= 0x7F;
                result = new BigInteger(bytes);
            }
            while (result >= upperBound);
            return result;
        }

    }

}