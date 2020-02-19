using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using MVP.Presenter;

using HomeWork4.Enumerations;
using HomeWork4.Models;

namespace HomeWork4.Presenters
{

    internal sealed class IVLoaderPresenter : PresenterBase
    {

        #region Fields

        private BlockSizeSelectorModel _blockSizeSelectorModel;

        #endregion

        #region Control fields

        private Label _loadedIVLabel;
        private Button _clearIVButton;

        #endregion

        #region Constructors

        public IVLoaderPresenter(BlockSizeSelectorModel blockSizeSelectorModel)
            : base(new IVLoaderModel(blockSizeSelectorModel)
                  , "HomeWork4.Presenters.IVLoaderPresenter.")
        {
            BlockSizeSelectorModel = blockSizeSelectorModel;
        }

        #endregion

        #region Properties

        internal new IVLoaderModel Model =>
            base.Model as IVLoaderModel;

        private BlockSizeSelectorModel BlockSizeSelectorModel
        {
            get => _blockSizeSelectorModel ??
                throw new ArgumentNullException(Path + nameof(BlockSizeSelectorModel));

            set => _blockSizeSelectorModel = value;
        }

        #endregion

        #region Control properties

        public Label LoadedIVLabel
        {
            private get => _loadedIVLabel ??
                throw new ArgumentNullException(Path + nameof(LoadedIVLabel));

            set => _loadedIVLabel = value;
        }

        public Button ClearIVButton
        {
            private get => _clearIVButton ??
                throw new ArgumentNullException(Path + nameof(ClearIVButton));

            set => _clearIVButton = value;
        }

        #endregion

        #region Public methods

        public void LoadIVBytes()
        {
            var openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory
                , CheckFileExists = true
                , Title = "Browse for Rijndael IV file..."
                , Filter = "Rijndael IV file (*.rijniv)|*.rijniv"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            using (var IVFileReader = new BinaryReader(File.OpenRead(openFileDialog.FileName)))
            {
                if (IVFileReader.BaseStream.Length != (int)BlockSizeSelectorModel.BlockSize)
                {
                    Model.LoadedIVBytes = new byte[0];
                    return;
                }
                var readIVBytes = new byte[IVFileReader.BaseStream.Length];
                IVFileReader.Read(readIVBytes, 0
                    , readIVBytes.Length);
                Model.LoadedIVBytes = readIVBytes;
            }
        }

        public void ClearIV()
        {
            Model.LoadedIVBytes = null;
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.LoadedIVBytesChanged += new Action<IVLoaderExitStatus>(
                IVLoaderExitStatus =>
            {
                switch (IVLoaderExitStatus)
                {
                    case IVLoaderExitStatus.ValidIV:
                        LoadedIVLabel.Invoke((MethodInvoker)(() =>
                        {
                            LoadedIVLabel.ForeColor = Color.Green;
                            LoadedIVLabel.Text = "Valid IV";
                        }));
                        ClearIVButton.Invoke((MethodInvoker)(() =>
                        {
                            ClearIVButton.Enabled = true;
                        }));
                        break;
                    case IVLoaderExitStatus.EmptyIV:
                        LoadedIVLabel.Invoke((MethodInvoker)(() =>
                        {
                            LoadedIVLabel.ForeColor = Color.Red;
                            LoadedIVLabel.Text = "IV not set";
                        }));
                        ClearIVButton.Invoke((MethodInvoker)(() =>
                        {
                            ClearIVButton.Enabled = false;
                        }));
                        break;
                    case IVLoaderExitStatus.InvalidIV:
                        LoadedIVLabel.Invoke((MethodInvoker)(() =>
                        {
                            LoadedIVLabel.ForeColor = Color.Red;
                            LoadedIVLabel.Text = "Invalid IV";
                        }));
                        ClearIVButton.Invoke((MethodInvoker)(() =>
                        {
                            ClearIVButton.Enabled = false;
                        }));
                        break;
                }
            });
            Model.Initialize();
        }

        #endregion

    }

}