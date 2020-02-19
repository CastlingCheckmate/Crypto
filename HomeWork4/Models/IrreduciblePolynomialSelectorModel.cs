using System;
using System.Linq;

using Cryptography.HomeWork4;

using MVP.Model;

namespace HomeWork4.Models
{

    internal sealed class IrreduciblePolynomialSelectorModel : ModelBase
    {

        #region Fields

        private byte[] _irreduciblePolynomials;
        private byte _selectedIrreduciblePolynomialIndex;

        #endregion

        #region Constructors

        public IrreduciblePolynomialSelectorModel()
            : base("HomeWork4.Models.GF256ModuloSelectorModel.")
        {

        }

        #endregion

        #region Properties

        private byte[] IrreduciblePolynomials
        {
            get => _irreduciblePolynomials;

            set
            {
                _irreduciblePolynomials = value;
                IrreduciblePolynomialsCreated?.Invoke(_irreduciblePolynomials);
            }
        }

        public byte SelectedIrreduciblePolynomialIndex
        {
            private get => _selectedIrreduciblePolynomialIndex;

            set
            {
                if (SelectedIrreduciblePolynomialIndex == value)
                {
                    return;
                }
                _selectedIrreduciblePolynomialIndex = value;
                SelectedIrreduciblePolynomialIndexChanged?.Invoke(SelectedIrreduciblePolynomialIndex);
            }
        }

        public byte SelectedIrreduciblePolynomial => IrreduciblePolynomials[SelectedIrreduciblePolynomialIndex];

        #endregion

        #region Public methods

        public void ResetSelectedIrreduciblePolynomialIndex()
        {
            SelectedIrreduciblePolynomialIndexChanged?.Invoke(SelectedIrreduciblePolynomialIndex);
        }

        #endregion

        #region Events

        public event Action<byte[]> IrreduciblePolynomialsCreated;
        public event Action<byte> SelectedIrreduciblePolynomialIndexChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            IrreduciblePolynomials = Enumerable.Range(0, 128)
                .Select(modulo => (byte)(modulo * 2 + 1))
                .Where(modulo =>
                {
                    var bits = 0;
                    for (var i = 0; i < 8; i++)
                    {
                        bits += modulo & 1;
                        modulo >>= 1;
                    }
                    return (bits & 1) == 0;
                })
                .Where(modulo =>
                {
                    var GaloisField = new GF256(modulo);
                    return Enumerable
                        .Range(0, 256)
                        .Select(element => (byte)element)
                        .All(element => element == GaloisField.Invert(GaloisField.Invert(element)));
                })
                .Select(modulo => modulo)
                .ToArray();
            SelectedIrreduciblePolynomialIndex = 1;
        }

        #endregion

    }

}