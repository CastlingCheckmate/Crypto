using System.Collections.Generic;
using System.Numerics;
using System.Threading;

namespace Cryptography.HomeWork1
{

    public sealed partial class HomeWork1MethodSet
    {

        public static BigInteger[] GetReducedResidueSystem(BigInteger value, CancellationToken token)
        {
            if (value <= 0)
            {
                return new BigInteger[0];
            }
            var reducedResidueSystem = new List<BigInteger>(new BigInteger[] { BigInteger.One });
            if (value % 2 == 0)
            {
                for (var counter = new BigInteger(3); counter < value; counter += 2)
                {
                    token.ThrowIfCancellationRequested();
                    if (BigInteger.GreatestCommonDivisor(counter, value) == BigInteger.One)
                    {
                        reducedResidueSystem.Add(counter);
                    }
                }
            }
            else
            {
                for (var counter = new BigInteger(2); counter < value; counter++)
                {
                    token.ThrowIfCancellationRequested();
                    if (BigInteger.GreatestCommonDivisor(counter, value) == BigInteger.One)
                    {
                        reducedResidueSystem.Add(counter);
                    }
                }
            }
            return reducedResidueSystem.ToArray();
        }

    }

}