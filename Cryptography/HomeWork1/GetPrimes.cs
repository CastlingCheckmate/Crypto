using System.Collections.Generic;
using System.Numerics;
using System.Threading;

using Extensions.BigIntegerExtensions;

namespace Cryptography.HomeWork1
{

    public sealed partial class HomeWork1MethodSet
    {

        public static BigInteger[] GetPrimes(BigInteger upperBound, CancellationToken token)
        {
            var result = new List<BigInteger>();
            if (upperBound > 2)
            {
                result.Add(2);
            }
            for (var counter = new BigInteger(3); counter < upperBound; counter += 2)
            {
                token.ThrowIfCancellationRequested();
                if (counter.IsPrime())
                {
                    result.Add(counter);
                }
            }
            return result.ToArray();
        }

    }

}