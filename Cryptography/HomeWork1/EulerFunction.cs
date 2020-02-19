using System;
using System.Numerics;
using System.Threading;

namespace Cryptography.HomeWork1
{

    public sealed partial class HomeWork1MethodSet
    {

        public static BigInteger EulerFunction(BigInteger value, CancellationToken token)
        {
            var reducedResidueSystem = default(BigInteger[]);
            try
            {
                reducedResidueSystem = GetReducedResidueSystem(value, token);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            if (reducedResidueSystem == null)
            {
                return BigInteger.MinusOne;
            }
            return reducedResidueSystem.Length;
        }

    }

}