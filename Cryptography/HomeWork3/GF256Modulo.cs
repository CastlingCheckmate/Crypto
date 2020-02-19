using System;

namespace Cryptography.HomeWork3
{

    public sealed class GF256Modulo : IEquatable<BinaryPolynomial>
    {

        #region Fields

        private BinaryPolynomial _value;

        #endregion

        #region Constructors

        public GF256Modulo(BinaryPolynomial value)
        {
            Value = value;
        }

        #endregion

        #region Properties

        public BinaryPolynomial Value
        {
            get => _value;

            private set => _value = value;
        }

        #endregion

        #region Operator methods

        public static bool operator ==(GF256Modulo modulo, BinaryPolynomial value)
        {
            if (ReferenceEquals(modulo, null))
            {
                return ReferenceEquals(value, null);
            }
            return modulo.Equals(value);
        }

        public static bool operator ==(BinaryPolynomial value, GF256Modulo modulo)
        {
            if (ReferenceEquals(value, null))
            {
                return ReferenceEquals(modulo, null);
            }
            return modulo.Equals(value);
        }

        public static bool operator !=(GF256Modulo modulo, BinaryPolynomial value)
        {
            if (ReferenceEquals(modulo, null))
            {
                return !ReferenceEquals(value, null);
            }
            return !modulo.Equals(value);
        }

        public static bool operator !=(BinaryPolynomial value, GF256Modulo modulo)
        {
            if (ReferenceEquals(value, null))
            {
                return !ReferenceEquals(modulo, null);
            }
            return !modulo.Equals(value);
        }

        #endregion

        #region Object class methods overriding

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return ToString(false);
        }

        public string ToString(bool isSuperscriptRepresentation = false)
        {
            return Value.ToString(isSuperscriptRepresentation);
        }

        #endregion

        #region IEquatable<BinaryPolynomial> interface implementation

        public bool Equals(BinaryPolynomial obj)
        {
            if ((object)obj == null)
            {
                return false;
            }
            return Value.Equals(obj);
        }

        #endregion

    }

}