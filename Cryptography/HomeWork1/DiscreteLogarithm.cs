using System;
using System.Numerics;
using System.Threading;

namespace Cryptography.HomeWork1
{

    public sealed partial class HomeWork1MethodSet
    {

        public static BigInteger DiscreteLogarithm(BigInteger g, BigInteger a, BigInteger b, CancellationToken token)
        {
            for (BigInteger x = 0; x < b; x++)
            {
                token.ThrowIfCancellationRequested();
                if (BigInteger.ModPow(a, x, b) == g)
                {
                    return x;
                }
            }
            throw new ArgumentException();
        }

    }

}