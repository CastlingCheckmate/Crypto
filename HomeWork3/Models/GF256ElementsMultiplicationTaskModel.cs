using System;
using System.Threading;
using System.Threading.Tasks;

using Cryptography.HomeWork3;

using MVP.Model;

namespace HomeWork3.Models
{

    internal sealed class GF256ElementsMultiplicationTaskModel : ModelBase, IDisposable
    {

        #region Fields

        private GF256Element _firstFactor;
        private GF256Element _secondFactor;
        private GF256Modulo _modulo;

        #endregion

        #region Constructors

        public GF256ElementsMultiplicationTaskModel()
            : base("HomeWork3.Models.")
        {

        }

        #endregion

        #region Properties
        // TODO: not used yet
        private CancellationTokenSource GF256ElementsMultiplicationTaskGrave
        {
            get;

            set;
        }

        public GF256Element FirstFactor
        {
            private get => _firstFactor;

            set
            {
                _firstFactor = value;
                FirstFactorChanged?.Invoke(FirstFactor?.ToString(true) ?? string.Empty);
                Multiply();
            }
        }

        public GF256Element SecondFactor
        {
            private get => _secondFactor;

            set
            {
                _secondFactor = value;
                SecondFactorChanged?.Invoke(SecondFactor?.ToString(true) ?? string.Empty);
                Multiply();
            }
        }

        public GF256Modulo Modulo
        {
            private get => _modulo;

            set
            {
                _modulo = value;
                ModuloChanged?.Invoke(Modulo?.ToString(true) ?? string.Empty);
                Multiply();
            }
        }

        #endregion

        #region Private methods

        private async void Multiply()
        {
            if (FirstFactor == null || SecondFactor == null || Modulo == null)
            {
                MultiplicationResultChanged?.Invoke(string.Empty);
                return;
            }
            MultiplicationResultChanged?.Invoke((await Task<GF256Element>.Factory.StartNew(() =>
                GF256Element.Multiplication(FirstFactor, SecondFactor, Modulo)
            )).ToString(true));
        }

        #endregion

        #region Events

        public event Action<string> FirstFactorChanged;
        public event Action<string> SecondFactorChanged;
        public event Action<string> ModuloChanged;
        public event Action<string> MultiplicationResultChanged;

        #endregion

        #region ModelBase abstract methods implementation

        public override void Initialize()
        {
            FirstFactorChanged?.Invoke(string.Empty);
            SecondFactorChanged?.Invoke(string.Empty);
            ModuloChanged?.Invoke(string.Empty);
            MultiplicationResultChanged?.Invoke(string.Empty);
        }

        #endregion

        #region IDisposable interface implementation

        public override void Dispose()
        {
            GF256ElementsMultiplicationTaskGrave?.Dispose();
        }

        #endregion

    }

}