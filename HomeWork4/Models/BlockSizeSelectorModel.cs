using System;

using Cryptography.HomeWork4;

using MVP.Model;

namespace HomeWork4.Models
{

    internal sealed class BlockSizeSelectorModel : ModelBase
    {

        #region Fields

        private RijndaelBlockSizes _blockSize;

        #endregion

        #region Constructors

        public BlockSizeSelectorModel()
            : base("HomeWork4.Presenters.BlockSizeSelectorModel.")
        {

        }

        #endregion

        #region Properties

        public RijndaelBlockSizes BlockSize
        {
            get => _blockSize;

            set
            {
                _blockSize = value;
                BlockSizeChanged?.Invoke(BlockSize);
            }
        }

        #endregion

        #region Events

        public event Action<RijndaelBlockSizes> BlockSizeChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            BlockSize = RijndaelBlockSizes.BlockSize128;
        }

        #endregion

    }

}