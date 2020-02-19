using System;

using MVP.Model;

namespace HomeWork4.Models
{

    internal sealed class IVGeneratorModel : ModelBase
    {

        #region Fields

        private byte[] _generatedIVBytes;
        private bool _isIVShown;

        #endregion

        #region Constructors

        public IVGeneratorModel()
            : base("HomeWork4.Models.IVGeneratorModel.")
        {

        }

        #endregion

        #region Properties

        public byte[] GeneratedIVBytes
        {
            get => _generatedIVBytes;

            set
            {
                _generatedIVBytes = value;
                GeneratedIVBytesChanged?.Invoke(GeneratedIVBytes);
            }
        }

        public bool IsIVShown
        {
            get => _isIVShown;

            set
            {
                _isIVShown = value;
                IsIVShownChanged?.Invoke(IsIVShown);
            }
        }

        #endregion

        #region Events

        public event Action<byte[]> GeneratedIVBytesChanged;
        public event Action<bool> IsIVShownChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            GeneratedIVBytes = null;
            IsIVShown = false;
        }

        #endregion

    }

}