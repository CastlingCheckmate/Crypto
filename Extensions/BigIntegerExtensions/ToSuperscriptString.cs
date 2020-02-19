using System.Linq;
using System.Numerics;

namespace Extensions.BigIntegerExtensions
{

    public static partial class BigIntegerExtensions
    {

        public static string ToSuperscriptString(this BigInteger value)
        {
            if (value < BigInteger.Zero)
            {
                return $"{(char)0x207b}{ToSuperscriptString(BigInteger.Abs(value))}";
            }
            return string.Concat(value.ToString().Select(c =>
            {
                switch (c)
                {
                    case '1':
                        return (char)0x00b9;
                    case '2':
                        return (char)0x00b2;
                    case '3':
                        return (char)0x00b3;
                    default:
                        return (char)(c - '0' + 0x2070);
                }
            }));
        }

    }

}