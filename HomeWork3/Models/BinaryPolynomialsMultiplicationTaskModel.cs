using System;
using System.Threading;
using System.Threading.Tasks;

using Cryptography.HomeWork3;

using MVP.Model;

namespace HomeWork3.Models
{

    internal sealed class BinaryPolynomialsMultiplicationTaskModel : ModelBase, IDisposable
    {

        #region Fields

        private BinaryPolynomial _firstFactor;
        private BinaryPolynomial _secondFactor;

        #endregion

        #region Constructors

        public BinaryPolynomialsMultiplicationTaskModel()
            : base("HomeWork3.Models.")
        {

        }

        #endregion

        #region Properties
        // TODO: not used yet
        private CancellationTokenSource BinaryPolynomialsMultiplicationTaskGrave
        {
            get;

            set;
        }

        public BinaryPolynomial FirstFactor
        {
            private get => _firstFactor;

            set
            {
                _firstFactor = value;
                FirstFactorChanged?.Invoke(FirstFactor?.ToString(true) ?? string.Empty);
                Multiply();
            }
        }

        public BinaryPolynomial SecondFactor
        {
            private get => _secondFactor;

            set
            {
                _secondFactor = value;
                SecondFactorChanged?.Invoke(SecondFactor?.ToString(true) ?? string.Empty);
                Multiply();
            }
        }

        #endregion

        #region Private methods

        private async void Multiply()
        {
            if (FirstFactor == null || SecondFactor == null)
            {
                MultiplicationResultChanged?.Invoke(string.Empty);
                return;
            }
            // TODO: add HomeWork3MethodSet class
            MultiplicationResultChanged?.Invoke((await Task<BinaryPolynomial>.Factory.StartNew(() =>
                FirstFactor * SecondFactor
            )).ToString(true));
        }

        #endregion

        #region Events

        public Action<string> FirstFactorChanged;
        public Action<string> SecondFactorChanged;
        public Action<string> MultiplicationResultChanged;

        #endregion

        #region ModelBase abstract methods implementation

        public override void Initialize()
        {
            FirstFactorChanged?.Invoke(string.Empty);
            SecondFactorChanged?.Invoke(string.Empty);
            MultiplicationResultChanged?.Invoke(string.Empty);
        }

        #endregion

        #region IDisposable interface implementation

        public override void Dispose()
        {
            BinaryPolynomialsMultiplicationTaskGrave?.Dispose();
        }

        #endregion

    }

}