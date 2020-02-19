using System;

using MVP.Model;

using HomeWork4.Enumerations;

namespace HomeWork4.Models
{

    internal sealed class IVLoaderModel : ModelBase
    {

        #region Fields

        private BlockSizeSelectorModel _blockSizeSelectorModel;
        private byte[] _loadedIVBytes;

        #endregion

        #region Constructors

        public IVLoaderModel(BlockSizeSelectorModel blockSizeSelectorModel)
            : base("HomeWork4.Models.IVLoaderModel.")
        {
            BlockSizeSelectorModel = blockSizeSelectorModel;
        }

        #endregion

        #region Properties

        private BlockSizeSelectorModel BlockSizeSelectorModel
        {
            get => _blockSizeSelectorModel ??
                throw new ArgumentNullException(Path + nameof(BlockSizeSelectorModel));

            set => _blockSizeSelectorModel = value;
        }

        public byte[] LoadedIVBytes
        {
            get => _loadedIVBytes;

            set
            {
                _loadedIVBytes = value;
                if (LoadedIVBytes == null)
                {
                    LoadedIVBytesChanged?.Invoke(
                        IVLoaderExitStatus.EmptyIV);
                    return;
                }
                if (LoadedIVBytes.Length != (int)BlockSizeSelectorModel.BlockSize)
                {
                    _loadedIVBytes = null;
                    LoadedIVBytesChanged?.Invoke(
                        IVLoaderExitStatus.InvalidIV);
                    return;
                }
                LoadedIVBytesChanged?.Invoke(
                    IVLoaderExitStatus.ValidIV);
            }
        }

        #endregion

        #region Events

        public event Action<IVLoaderExitStatus> LoadedIVBytesChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            LoadedIVBytes = null;
        }

        #endregion

    }

}