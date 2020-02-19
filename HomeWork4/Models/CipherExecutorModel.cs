using System;
using System.Threading;

using MVP.Model;

namespace HomeWork4.Models
{

    internal sealed class CipherExecutorModel : ModelBase
    {

        #region Fields

        private CancellationTokenSource _cipherExecutionCanceller;
        private bool _isExecuting = true;
        private byte _completed = 1;

        #endregion

        #region Constructors

        public CipherExecutorModel()
            : base("HomeWork4.Models.CipherExecutorModel.")
        {

        }

        #endregion

        #region Properties

        public CancellationTokenSource CipherExecutionCanceller
        {
            get => _cipherExecutionCanceller ??
                throw new ArgumentNullException(Path + nameof(CipherExecutionCanceller));

            set
            {
                _cipherExecutionCanceller?.Dispose();
                _cipherExecutionCanceller = value;
            }
        }

        public bool IsExecuting
        {
            get => _isExecuting;

            set
            {
                if (IsExecuting == value)
                {
                    return;
                }
                _isExecuting = value;
                IsExecutingChanged?.Invoke(IsExecuting);
            }
        }

        public byte Completed
        {
            get => _completed;

            set
            {
                if (Completed == value)
                {
                    return;
                }
                _completed = value;
                CompletedChanged?.Invoke(Completed);
            }
        }

        #endregion

        #region Events

        public event Action<bool> IsExecutingChanged;
        public event Action<byte> CompletedChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            CipherExecutionCanceller = new CancellationTokenSource();
            IsExecuting = false;
            Completed = 0;
        }

        #endregion

        #region IDisposable interface implementation

        public override void Dispose()
        {
            CipherExecutionCanceller.Dispose();
        }

        #endregion

    }

}