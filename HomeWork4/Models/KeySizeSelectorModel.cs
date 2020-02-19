using System;

using Cryptography.HomeWork4;

using MVP.Model;

namespace HomeWork4.Models
{

    internal sealed class KeySizeSelectorModel : ModelBase
    {

        #region Fields

        private RijndaelKeySizes _keySize;

        #endregion

        #region Constructors

        public KeySizeSelectorModel()
            : base("HomeWork4.Presenters.KeySizeSelectorModel.")
        {

        }

        #endregion

        #region Properties

        public RijndaelKeySizes KeySize
        {
            get => _keySize;

            set
            {
                _keySize = value;
                KeySizeChanged?.Invoke(KeySize);
            }
        }

        #endregion

        #region Events

        public event Action<RijndaelKeySizes> KeySizeChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            KeySize = RijndaelKeySizes.KeySize128;
        }

        #endregion

    }

}