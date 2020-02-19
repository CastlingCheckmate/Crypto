using System;
using System.Linq;
using System.Numerics;
using System.Text;

using Extensions.BigIntegerExtensions;

namespace Cryptography.HomeWork3
{

    public sealed class BinaryPolynomial : ICloneable, IComparable<BinaryPolynomial>, IEquatable<BinaryPolynomial>
    {

        #region Constants

        public static BinaryPolynomial Zero => new BinaryPolynomial(BigInteger.Zero);

        public static BinaryPolynomial One => new BinaryPolynomial(BigInteger.One);

        public static BinaryPolynomial X => new BinaryPolynomial(new BigInteger(2));

        #endregion

        #region Fields

        private BigInteger _value;

        #endregion

        #region Constructors

        public BinaryPolynomial(BigInteger value)
        {
            Value = value;
        }

        private BinaryPolynomial(BinaryPolynomial other)
        {
            if (other != null)
            {
                Value = other.Value;
            }
        }

        #endregion

        #region Properties

        private BigInteger Value
        {
            get => _value;

            set
            {
                if (value < BigInteger.Zero)
                {
                    throw new ArgumentException("Invalid value", nameof(Value));
                }
                _value = value;
            }
        }

        public int Degree => Value.BitLength() - 1;

        #endregion

        #region Private methods

        private BinaryPolynomial Add(BinaryPolynomial summand)
        {
            Value ^= summand.Value;
            return this;
        }

        private BinaryPolynomial Multiply(BinaryPolynomial factor)
        {
            var valueCopy = Value;
            Value = BigInteger.Zero;
            var bitLength = valueCopy.BitLength();
            for (var i = 0; i <= bitLength; i++)
            {
                if ((valueCopy & BigInteger.One) == BigInteger.One)
                {
                    Value ^= factor.Value << i;
                }
                valueCopy >>= 1;
            }
            return this;
        }

        private BinaryPolynomial Divide(BinaryPolynomial divider)
        {
            if (divider == Zero)
            {
                throw new ArgumentException("Divider is equal to zero", nameof(divider));
            }
            if (this == Zero)
            {
                return Zero;
            }
            if (divider == One)
            {
                return this;
            }
            if (this == One)
            {
                return Zero;
            }
            var divisionResult = Zero;
            while (Degree >= divider.Degree)
            {
                divisionResult.Add(One << (Degree - divider.Degree));
                Add(divider << (Degree - divider.Degree));
            }
            Value = divisionResult.Value;
            return this;
        }

        private BinaryPolynomial DivisionRemainder(BinaryPolynomial divider)
        {
            if (divider == Zero)
            {
                throw new ArgumentException("Divider is equal to zero", nameof(divider));
            }
            if (this == Zero)
            {
                return Zero;
            }
            if (this == One)
            {
                if (divider == One)
                {
                    return Zero;
                }
                return One;
            }
            while (Degree >= divider.Degree)
            {
                Add(divider << (Degree - divider.Degree));
            }
            return this;
        }

        #endregion

        #region Public static methods

        public static BinaryPolynomial Sum(BinaryPolynomial firstSummand, BinaryPolynomial secondSummand)
        {
            return new BinaryPolynomial(firstSummand).Add(secondSummand);
        }

        public static BinaryPolynomial Multiplication(BinaryPolynomial firstFactor, BinaryPolynomial secondFactor)
        {
            return new BinaryPolynomial(firstFactor).Multiply(secondFactor);
        }

        public static BinaryPolynomial Division(BinaryPolynomial dividend, BinaryPolynomial divider)
        {
            return new BinaryPolynomial(dividend).Divide(divider);
        }

        public static BinaryPolynomial DivisionRemainder(BinaryPolynomial dividend, BinaryPolynomial divider)
        {
            return new BinaryPolynomial(dividend).DivisionRemainder(divider);
        }

        #endregion

        #region Operator methods

        public static BinaryPolynomial operator +(BinaryPolynomial firstSummand, BinaryPolynomial secondSummand)
        {
            return Sum(firstSummand, secondSummand);
        }

        public static BinaryPolynomial operator *(BinaryPolynomial firstFactor, BinaryPolynomial secondFactor)
        {
            return Multiplication(firstFactor, secondFactor);
        }

        public static BinaryPolynomial operator /(BinaryPolynomial dividend, BinaryPolynomial divider)
        {
            return Division(dividend, divider);
        }

        public static BinaryPolynomial operator %(BinaryPolynomial dividend, BinaryPolynomial divider)
        {
            return DivisionRemainder(dividend, divider);
        }

        public static bool operator ==(BinaryPolynomial firstCompared, BinaryPolynomial secondCompared)
        {
            if (ReferenceEquals(firstCompared, null))
            {
                return ReferenceEquals(secondCompared, null);
            }
            return firstCompared.Equals(secondCompared);
        }

        public static bool operator !=(BinaryPolynomial firstCompared, BinaryPolynomial secondCompared)
        {
            if (ReferenceEquals(firstCompared, null))
            {
                return !ReferenceEquals(secondCompared, null);
            }
            return !firstCompared.Equals(secondCompared);
        }

        public static bool operator <(BinaryPolynomial firstCompared, BinaryPolynomial secondCompared)
        {
            return firstCompared.CompareTo(secondCompared) == -1;
        }

        public static bool operator >(BinaryPolynomial firstCompared, BinaryPolynomial secondCompared)
        {
            return firstCompared.CompareTo(secondCompared) == 1;
        }

        public static bool operator <=(BinaryPolynomial firstCompared, BinaryPolynomial secondCompared)
        {
            return firstCompared.CompareTo(secondCompared) <= 0;
        }

        public static bool operator >=(BinaryPolynomial firstCompared, BinaryPolynomial secondCompared)
        {
            return firstCompared.CompareTo(secondCompared) >= 0;
        }

        public static BinaryPolynomial operator >>(BinaryPolynomial value, int shift)
        {
            return new BinaryPolynomial(value.Value >> shift);
        }

        public static BinaryPolynomial operator <<(BinaryPolynomial value, int shift)
        {
            return new BinaryPolynomial(value.Value << shift);
        }

        #endregion

        #region Object class methods overriding

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is BinaryPolynomial))
            {
                return false;
            }
            return Equals((BinaryPolynomial)obj);
        }

        public override string ToString()
        {
            return ToString(false);
        }

        public string ToString(bool isSuperscriptRepresentation = false)
        {
            var result = new StringBuilder();
            for (var i = 0; i <= Value.BitLength(); i++)
            {
                if (((Value >> i) & 1) == 0)
                {
                    continue;
                }
                switch (i)
                {
                    case 0:
                        result.Append("1 ");
                        break;
                    case 1:
                        result.Append("x ");
                        break;
                    default:
                        if (isSuperscriptRepresentation)
                        {
                            result.Append($"x{((BigInteger)i).ToSuperscriptString()} ");
                        }
                        else
                        {
                            result.Append($"x^{i} ");
                        }
                        break;
                }
            }
            if (result.Length == 0)
            {
                result.Append("0");
            }
            return "< " + string.Join(" + ", result.ToString()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Reverse()) + " >";
        }

        #endregion

        #region ICloneable interface implementation

        public object Clone()
        {
            return new BinaryPolynomial(this);
        }

        #endregion

        #region IComparable interface implementation

        public int CompareTo(BinaryPolynomial other)
        {
            if (other is null)
            {
                throw new ArgumentNullException(nameof(other));
            }
            return Value.CompareTo(other.Value);
        }

        #endregion

        #region IEquatable<BinaryPolynomial> interface implementation

        public bool Equals(BinaryPolynomial other)
        {
            if (other is null)
            {
                return false;
            }
            return Value.Equals(other.Value);
        }

        #endregion

    }

}