using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

using Cryptography.HomeWork1;

using MVP.Model;

namespace HomeWork1.Models
{

    internal sealed class DiscreteLogarithmTaskModel : ModelBase
    {

        #region Constructors

        public DiscreteLogarithmTaskModel()
            : base("HomeWork1.Models.Task4Model.")
        {

        }

        #endregion

        #region Properties

        private CancellationTokenSource DiscreteLogarithmTaskGrave
        {
            get;

            set;
        }

        private BigInteger G
        {
            get;

            set;
        }

        private BigInteger A
        {
            get;

            set;
        }

        private BigInteger B
        {
            get;

            set;
        }

        #endregion

        #region Public methods

        public void SetG(BigInteger g)
        {
            G = g;
            DiscreteLogarithm();
        }

        public void SetA(BigInteger a)
        {
            A = a;
            DiscreteLogarithm();
        }

        public void SetB(BigInteger b)
        {
            B = b;
            DiscreteLogarithm();
        }

        #endregion

        #region Private methods

        private async void DiscreteLogarithm()
        {
            if (G <= 0 || A <= 0 || B <= 0 || G >= B)
            {
                XValueChanged?.Invoke(BigInteger.MinusOne);
                return;
            }
            DiscreteLogarithmTaskGrave?.Cancel();
            XValueChanged?.Invoke(BigInteger.MinusOne);
            DiscreteLogarithmTaskGrave = new CancellationTokenSource();
            DiscreteLogarithmTaskGrave.Token.Register(() =>
            {
                DiscreteLogarithmTaskGrave.Dispose();
            });
            try
            {
                XValueChanged?.Invoke(await Task<BigInteger>.Factory.StartNew(() =>
                    HomeWork1MethodSet.DiscreteLogarithm(G, A, B, DiscreteLogarithmTaskGrave.Token)
                ));
            }
            catch (ArgumentException)
            {
                // TODO: invoke event
                //XValueChanged?.Invoke()
                XValueChanged?.Invoke(-1);
            }
            catch (OperationCanceledException)
            {

            }
        }

        #endregion

        #region Events
        // TODO: BigInteger -> string
        public Action<BigInteger> XValueChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            A = B = G = BigInteger.Zero;
        }

        #endregion

        #region IDisposable interface implementation

        public override void Dispose()
        {
            DiscreteLogarithmTaskGrave.Dispose();
        }

        #endregion

    }

}