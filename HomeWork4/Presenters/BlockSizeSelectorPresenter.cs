using System;
using System.Linq;
using System.Windows.Forms;

using Cryptography.HomeWork4;

using MVP.Presenter;

using HomeWork4.Models;

namespace HomeWork4.Presenters
{

    internal sealed class BlockSizeSelectorPresenter : PresenterBase
    {

        #region Fields

        private IVGeneratorModel _IVGeneratorModel;
        private IVLoaderModel _IVLoaderModel;

        #endregion

        #region Control fields

        private GroupBox _blockSizeSelectorGroupBox;

        #endregion

        #region Constructors

        public BlockSizeSelectorPresenter()
            : base(new BlockSizeSelectorModel(), "HomeWork4.Presenters.BlockSizeSelectorPresenter.")
        {

        }

        #endregion

        #region Properties

        internal new BlockSizeSelectorModel Model =>
            base.Model as BlockSizeSelectorModel;

        #endregion

        #region Dependency injection properties

        public IVGeneratorModel IVGeneratorModel
        {
            private get => _IVGeneratorModel ??
                throw new ArgumentNullException(Path + nameof(IVGeneratorModel));

            set => _IVGeneratorModel = value;
        }

        public IVLoaderModel IVLoaderModel
        {
            private get => _IVLoaderModel ??
                throw new ArgumentNullException(Path + nameof(IVLoaderModel));

            set => _IVLoaderModel = value;
        }

        #endregion

        #region Control properties

        public GroupBox BlockSizeSelectorGroupBox
        {
            private get => _blockSizeSelectorGroupBox ??
                throw new ArgumentNullException(Path + nameof(BlockSizeSelectorGroupBox));

            set => _blockSizeSelectorGroupBox = value;
        }

        #endregion

        #region Public methods

        public void SetBlockSize(RijndaelBlockSizes blockSize)
        {
            Model.BlockSize = blockSize;
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.BlockSizeChanged += new Action<RijndaelBlockSizes>(blockSize =>
            {
                foreach (var blockSizeRadioButton in BlockSizeSelectorGroupBox.Controls.OfType<RadioButton>())
                {
                    if ((RijndaelBlockSizes)blockSizeRadioButton.Tag == blockSize)
                    {
                        blockSizeRadioButton.Invoke((MethodInvoker)(() =>
                        {
                            blockSizeRadioButton.Checked = true;
                        }));
                    }
                    else
                    {
                        blockSizeRadioButton.Invoke((MethodInvoker)(() =>
                        {
                            blockSizeRadioButton.Checked = false;
                        }));
                    }
                }
                IVGeneratorModel.GeneratedIVBytes = null;
                IVLoaderModel.LoadedIVBytes = null;
            });
            Model.Initialize();
        }

        #endregion

    }

}