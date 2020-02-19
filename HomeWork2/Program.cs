using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

using Extensions.BigIntegerExtensions;

namespace HomeWork2
{

    internal static class Program
    {
        
        static void Main()
        {
            var pArray = new BigInteger[5]
            {
                970147, 678413, 712717, 973057, 187441
            };
            var qArray = new BigInteger[5]
            {
                679297, 710009, 794203, 488407, 997949
            };
            var nArray = pArray.Zip(qArray, (p, q) => p * q).ToArray();
            var phiArray = pArray.Zip(qArray, (p, q) => (p - 1) * (q - 1)).ToArray();
            var dArray = new BigInteger[5];
            for (var i = 0; i < 5; i++)
            {
                var upperBound = nArray[i].Sqrt().Sqrt() / 3;
                dArray[i] = BigIntegerExtensions.Random(upperBound - 3) + 3;
                while (BigInteger.GreatestCommonDivisor(dArray[i], phiArray[i]) != 1)
                {
                    dArray[i] = BigIntegerExtensions.Random(upperBound - 3) + 3;
                }
            }
            var eArray = new BigInteger[5];
            for (var i = 0; i < 5; i++)
            {
                eArray[i] = dArray[i].ModInverted(phiArray[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input:{0}\tN = {1}{0}\te = {2}{0}", Environment.NewLine, nArray[i], eArray[i]);
                Console.WriteLine("Fractions: ");
                foreach (var fraction in Fractions(eArray[i], nArray[i]))
                {
                    Console.WriteLine("\tGot: <{0}/{1}>", fraction.Item1, fraction.Item2);
                    var message = BigIntegerExtensions.Random(nArray[i]);
                    if (BigInteger.ModPow(BigInteger.ModPow(message, eArray[i], nArray[i]), fraction.Item2, nArray[i])
                        == message)
                    {
                        Console.WriteLine("\t\tFound d = {0}", fraction.Item2);
                        break;
                    }
                }
            }
        }

        static IEnumerable<Tuple<BigInteger, BigInteger>> Fractions(BigInteger e, BigInteger N)
        {
            var p1 = BigInteger.One;
            var q1 = BigInteger.Zero;
            var p2 = BigInteger.Zero;
            var q2 = BigInteger.One;
            while (N > BigInteger.Zero)
            {
                var n = e / N;
                var NCopy = N;
                N = e - n * N;
                e = NCopy;
                var k = n * p1 + p2;
                var d = n * q1 + q2;
                p2 = p1;
                q2 = q1;
                p1 = k;
                q1 = d;
                yield return new Tuple<BigInteger, BigInteger>(k, d);
            }
        }

    }

}