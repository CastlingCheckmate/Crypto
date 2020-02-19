using System;
using System.Numerics;

namespace Cryptography.HomeWork3
{

    public sealed class GF256Element
    {

        #region Fields

        private BinaryPolynomial _value;

        #endregion

        #region Constructors

        public GF256Element(BinaryPolynomial value)
        {
            Value = value;
        }

        private GF256Element(GF256Element other)
        {
            Value = (BinaryPolynomial)other.Value.Clone();
        }

        #endregion

        #region Properties

        private BinaryPolynomial Value
        {
            get => _value;

            set
            {
                if (value.Degree > 7)
                {
                    throw new ArgumentException($"{nameof(Value)} is not an GF(2^8) element", nameof(Value));
                }
                _value = value;
            }
        }

        #endregion

        #region Private methods

        private GF256Element Add(GF256Element summand)
        {
            Value += summand.Value;
            return this;
        }

        private GF256Element Multiply(GF256Element factor, GF256Modulo modulo)
        {
            if (modulo == BinaryPolynomial.Zero)
            {
                throw new ArgumentException("Modulo is equal to zero", nameof(modulo));
            }
            Value = Value * factor.Value % modulo.Value;
            return this;
        }

        #endregion

        #region Public static methods

        public static GF256Element Sum(GF256Element firstSummand, GF256Element secondSummand)
        {
            return new GF256Element(firstSummand).Add(secondSummand);
        }

        public static GF256Element Multiplication(GF256Element firstFactor, GF256Element secondFactor, GF256Modulo modulo)
        {
            return new GF256Element(firstFactor).Multiply(secondFactor, modulo);
        }

        public static GF256Element MultiplicativeInvertedByPotentiation(GF256Element elementToInverse, GF256Modulo modulo)
        {
            if (elementToInverse.Value == BinaryPolynomial.Zero)
            {
                return new GF256Element(elementToInverse);
            }
            var result = new GF256Element(BinaryPolynomial.One);
            var degree = new BigInteger(254);
            while (degree != BigInteger.Zero)
            {
                if ((degree & BigInteger.One) == BigInteger.One)
                {
                    result.Multiply(elementToInverse, modulo);
                }
                result.Multiply(result, modulo);
                degree >>= 1;
            }
            return result;
        }

        public static GF256Element MultiplicativeInvertedByExtendedEuclideanAlgorithm(GF256Element elementToInverse, GF256Modulo modulo)
        {
            if (elementToInverse.Value == BinaryPolynomial.Zero)
            {
                return new GF256Element(elementToInverse);
            }
            var x = default(BinaryPolynomial);
            var x0 = BinaryPolynomial.One;
            var x1 = BinaryPolynomial.Zero;
            var y = default(BinaryPolynomial);
            var y0 = BinaryPolynomial.Zero;
            var y1 = BinaryPolynomial.One;
            var a = default(BinaryPolynomial);
            var a1 = (BinaryPolynomial)elementToInverse.Value.Clone();
            var a0 = (BinaryPolynomial)modulo.Value.Clone();
            var q = default(BinaryPolynomial);
            do
            {
                q = a0 / a1;
                a = a0 + q * a1;
                a0 = a1;
                a1 = a;
                x = x0 + q * x1;
                x0 = x1;
                x1 = x;
                y = y0 + q * y1;
                y0 = y1;
                y1 = y;
            } while (a > BinaryPolynomial.Zero);
            return new GF256Element(y0);
        }

        #endregion

        #region Operator methods

        public static GF256Element operator +(GF256Element first, GF256Element second)
        {
            return Sum(first, second);
        }

        #endregion

        #region Object class methods overriding

        public override string ToString()
        {
            return ToString(false);
        }

        public string ToString(bool isSuperscriptRepresentation = false)
        {
            return Value.ToString(isSuperscriptRepresentation);
        }

        #endregion

        #region ICloneable interface implementation

        public object Clone()
        {
            return new GF256Element(Value);
        }

        #endregion

    }

}