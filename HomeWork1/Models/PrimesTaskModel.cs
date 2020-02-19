using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

using Cryptography.HomeWork1;

using MVP.Model;

namespace HomeWork1.Models
{

    internal sealed class PrimesTaskModel : ModelBase
    {

        #region Constructors

        public PrimesTaskModel()
            : base("HomeWork1.Models.Task1Model.")
        {

        }

        #endregion

        #region Properties

        private CancellationTokenSource PrimesTaskGrave
        {
            get;

            set;
        }

        #endregion

        #region Public Methods

        public async void SetM(BigInteger m)
        {
            PrimesTaskGrave?.Cancel();
            PrimesChanged?.Invoke(new BigInteger[0]);
            PrimesTaskGrave = new CancellationTokenSource();
            PrimesTaskGrave.Token.Register(() =>
            {
                PrimesTaskGrave.Dispose();
            });
            try
            {
                PrimesChanged?.Invoke(await Task<BigInteger[]>.Factory.StartNew(() =>
                    HomeWork1MethodSet.GetPrimes(m, PrimesTaskGrave.Token)
                ));
            }
            catch (OperationCanceledException)
            {

            }
        }

        #endregion

        #region Events

        public event Action<BigInteger[]> PrimesChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            PrimesChanged?.Invoke(new BigInteger[0]);
        }

        #endregion

        #region IDisposable interface implementation

        public override void Dispose()
        {
            PrimesTaskGrave.Dispose();
        }

        #endregion

    }

}