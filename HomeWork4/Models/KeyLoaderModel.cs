using System;

using MVP.Model;

using HomeWork4.Enumerations;

namespace HomeWork4.Models
{

    internal sealed class KeyLoaderModel : ModelBase
    {

        #region Fields

        private KeySizeSelectorModel _keySizeSelectorModel;
        private byte[] _loadedKeyBytes;

        #endregion

        #region Constructors

        public KeyLoaderModel(KeySizeSelectorModel keySizeSelectorModel)
            : base("HomeWork4.Models.KeyLoaderModel.")
        {
            KeySizeSelectorModel = keySizeSelectorModel;
        }

        #endregion

        #region Properties

        private KeySizeSelectorModel KeySizeSelectorModel
        {
            get => _keySizeSelectorModel ??
                throw new ArgumentNullException(Path + nameof(KeySizeSelectorModel));

            set => _keySizeSelectorModel = value;
        }

        public byte[] LoadedKeyBytes
        {
            get => _loadedKeyBytes;

            set
            {
                _loadedKeyBytes = value;
                if (LoadedKeyBytes == null)
                {
                    LoadedKeyBytesChanged?.Invoke(KeyLoaderExitStatus.EmptyKey);
                    return;
                }
                if (LoadedKeyBytes.Length != (int)KeySizeSelectorModel.KeySize)
                {
                    _loadedKeyBytes = null;
                    LoadedKeyBytesChanged?.Invoke(KeyLoaderExitStatus.InvalidKey);
                    return;
                }
                LoadedKeyBytesChanged?.Invoke(KeyLoaderExitStatus.ValidKey);
            }
        }

        #endregion

        #region Events

        public event Action<KeyLoaderExitStatus> LoadedKeyBytesChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            LoadedKeyBytes = null;
        }

        #endregion

    }

}