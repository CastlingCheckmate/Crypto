using System;

using MVP.Model;

namespace HomeWork4.Models
{

    internal sealed class KeyGeneratorModel : ModelBase
    {

        #region Fields

        private byte[] _generatedKeyBytes;
        private bool _isKeyShown;

        #endregion

        #region Constructors

        public KeyGeneratorModel()
            : base("HomeWork4.Models.KeyGeneratorModel.")
        {

        }

        #endregion

        #region Properties

        public byte[] GeneratedKeyBytes
        {
            get => _generatedKeyBytes;

            set
            {
                _generatedKeyBytes = value;
                GeneratedKeyBytesChanged?.Invoke(GeneratedKeyBytes);
            }
        }

        public bool IsKeyShown
        {
            get => _isKeyShown;

            set
            {
                _isKeyShown = value;
                IsKeyShownChanged?.Invoke(IsKeyShown);
            }
        }

        #endregion

        #region Events

        public event Action<byte[]> GeneratedKeyBytesChanged;
        public event Action<bool> IsKeyShownChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            GeneratedKeyBytes = null;
            IsKeyShown = false;
        }

        #endregion

    }
    
}