using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

using Cryptography.HomeWork1;

using MVP.Model;

namespace HomeWork1.Models
{

    internal sealed class EulerFunctionTaskModel : ModelBase
    {

        #region Constructors

        public EulerFunctionTaskModel()
            : base("HomeWork1.Models.Task3Model.")
        {

        }

        #endregion

        #region Properties

        private CancellationTokenSource EulerFunctionTaskGrave
        {
            get;

            set;
        }

        #endregion

        #region Public Methods

        public async void SetM(BigInteger m)
        {
            EulerFunctionTaskGrave?.Cancel();
            EulerFunctionChanged?.Invoke(BigInteger.MinusOne);
            EulerFunctionTaskGrave = new CancellationTokenSource();
            EulerFunctionTaskGrave.Token.Register(() =>
            {
                EulerFunctionTaskGrave.Dispose();
            });
            try
            {
                EulerFunctionChanged?.Invoke(await Task<BigInteger>.Factory.StartNew(() =>
                    HomeWork1MethodSet.EulerFunction(m, EulerFunctionTaskGrave.Token)
                ));
            }
            catch (OperationCanceledException)
            {

            }
        }

        #endregion

        #region Events

        public event Action<BigInteger> EulerFunctionChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            EulerFunctionChanged?.Invoke(BigInteger.MinusOne);
        }

        #endregion

        #region IDisposable interface implementation

        public override void Dispose()
        {
            EulerFunctionTaskGrave.Dispose();
        }

        #endregion

    }

}