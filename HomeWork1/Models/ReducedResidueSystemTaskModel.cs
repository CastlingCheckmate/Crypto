using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

using Cryptography.HomeWork1;

using MVP.Model;

namespace HomeWork1.Models
{

    internal sealed class ReducedResidueSystemTaskModel : ModelBase
    {

        #region Constructors

        public ReducedResidueSystemTaskModel()
            : base("HomeWork1.Models.Task2Model.")
        {

        }

        #endregion

        #region Properties

        private CancellationTokenSource ReducedResidueSystemTaskGrave
        {
            get;

            set;
        }

        #endregion

        #region Public Methods

        public async void SetM(BigInteger m)
        {
            ReducedResidueSystemTaskGrave?.Cancel();
            ReducedResidueSystemChanged?.Invoke(new BigInteger[0]);
            ReducedResidueSystemTaskGrave = new CancellationTokenSource();
            ReducedResidueSystemTaskGrave.Token.Register(() =>
            {
                ReducedResidueSystemTaskGrave.Dispose();
            });
            try
            {
                ReducedResidueSystemChanged?.Invoke(await Task<BigInteger[]>.Factory.StartNew(() =>
                    HomeWork1MethodSet.GetReducedResidueSystem(m, ReducedResidueSystemTaskGrave.Token)
                ));
            }
            catch (OperationCanceledException)
            {

            }
        }

        #endregion

        #region Events

        public event Action<BigInteger[]> ReducedResidueSystemChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            ReducedResidueSystemChanged?.Invoke(new BigInteger[0]);
        }

        #endregion

        #region IDisposable interface implementation

        public override void Dispose()
        {
            ReducedResidueSystemTaskGrave.Dispose();
        }

        #endregion

    }

}