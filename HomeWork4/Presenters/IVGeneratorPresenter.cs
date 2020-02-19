using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Extensions.ByteArrayExtensions;
using Extensions.StringExtensions;

using MVP.Presenter;

using HomeWork4.Models;

namespace HomeWork4.Presenters
{

    internal sealed class IVGeneratorPresenter : PresenterBase
    {

        #region Fields

        private BlockSizeSelectorModel _blockSizeSelectorModel;
        private IVLoaderModel _IVLoaderModel;

        #endregion

        #region Control fields

        private Label _generatedIVLabel;
        private Button _saveIVButton;
        private Button _clearIVButton;
        private ContextMenuStrip _showOrHideGeneratedIVContextMenuStrip;
        private ToolStripMenuItem _showOrHideGeneratedIVContextMenuStripItem;
        private Button _useGeneratedIVAsLoadedIVButton;

        #endregion

        #region Constructors

        public IVGeneratorPresenter(BlockSizeSelectorModel blockSizeSelectorModel)
            : base(new IVGeneratorModel()
                  , "HomeWork4.Presenters.IVGeneratorPresenter.")
        {
            BlockSizeSelectorModel = blockSizeSelectorModel;
        }

        #endregion

        #region Properties

        internal new IVGeneratorModel Model =>
            base.Model as IVGeneratorModel;

        private BlockSizeSelectorModel BlockSizeSelectorModel
        {
            get => _blockSizeSelectorModel ??
                throw new ArgumentNullException(Path + nameof(BlockSizeSelectorModel));

            set => _blockSizeSelectorModel = value;
        }

        public bool IsGeneratedIVEmpty =>
            Model.GeneratedIVBytes == null;

        #endregion

        #region Dependency injection properties

        public IVLoaderModel IVLoaderModel
        {
            private get => _IVLoaderModel ??
                throw new ArgumentNullException(Path + nameof(IVLoaderModel));

            set => _IVLoaderModel = value;
        }

        #endregion

        #region Control properties

        public Label GeneratedIVLabel
        {
            private get => _generatedIVLabel ??
                throw new ArgumentNullException(Path + nameof(GeneratedIVLabel));

            set => _generatedIVLabel = value;
        }

        public Button SaveIVButton
        {
            private get => _saveIVButton ??
                throw new ArgumentNullException(Path + nameof(SaveIVButton));

            set => _saveIVButton = value;
        }

        public Button ClearIVButton
        {
            private get => _clearIVButton ??
                throw new ArgumentNullException(Path + nameof(ClearIVButton));

            set => _clearIVButton = value;
        }

        public ContextMenuStrip ShowOrHideGeneratedIVContextMenuStrip
        {
            private get => _showOrHideGeneratedIVContextMenuStrip ??
                throw new ArgumentNullException(Path + nameof(ShowOrHideGeneratedIVContextMenuStrip));

            set => _showOrHideGeneratedIVContextMenuStrip = value;
        }

        public ToolStripMenuItem ShowOrHideGeneratedIVContextMenuStripItem
        {
            private get => _showOrHideGeneratedIVContextMenuStripItem ??
                throw new ArgumentNullException(Path + nameof(ShowOrHideGeneratedIVContextMenuStripItem));

            set => _showOrHideGeneratedIVContextMenuStripItem = value;
        }

        public Button UseGeneratedIVAsLoadedIVButton
        {
            private get => _useGeneratedIVAsLoadedIVButton ??
                throw new ArgumentNullException(Path + nameof(UseGeneratedIVAsLoadedIVButton));

            set => _useGeneratedIVAsLoadedIVButton = value;
        }

        #endregion

        #region Public methods

        public void GenerateIVBytes()
        {
            var generatedIVBytes = new byte[(int)BlockSizeSelectorModel.BlockSize];
            new Random().NextBytes(generatedIVBytes);
            Model.GeneratedIVBytes = generatedIVBytes;
        }

        public void SaveIV()
        {
            var saveFileDialog = new SaveFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory
                , OverwritePrompt = true
                , Title = "Browse for output file..."
                , Filter = "Rijndael IV file (*.rijniv)|*.rijniv"
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            using (var IVFileWriter = new BinaryWriter(File.OpenWrite(saveFileDialog.FileName)))
            {
                IVFileWriter.Write(Model.GeneratedIVBytes);
            }
            IVSavingSucceeded?.Invoke(saveFileDialog.FileName);
        }

        public void ClearIV()
        {
            Model.GeneratedIVBytes = null;
        }

        public void ShowOrHideIV()
        {
            Model.IsIVShown = !Model.IsIVShown;
        }

        public void UseIVAsLoaded()
        {
            IVLoaderModel.LoadedIVBytes = Model.GeneratedIVBytes;
        }

        public void OnUseGeneratedIVAsLoadedIVButtonMouseEnter()
        {
            UseGeneratedIVAsLoadedIVButton.Invoke((MethodInvoker)(() =>
            {
                UseGeneratedIVAsLoadedIVButton.Image = Properties.Resources.UseGeneratedKeyOrIVAsLoadedEntered;
            }));
        }

        public void OnUseGeneratedIVAsLoadedIVButtonMouseLeave()
        {
            UseGeneratedIVAsLoadedIVButton.Invoke((MethodInvoker)(() =>
            {
                UseGeneratedIVAsLoadedIVButton.Image = Properties.Resources.UseGeneratedKeyOrIVAsLoadedLeft;
            }));
        }

        #endregion

        #region Events

        public event Action<string> IVSavingSucceeded;

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.GeneratedIVBytesChanged += new Action<byte[]>(generatedIVBytes =>
            {
                Model.IsIVShown = false;
                SaveIVButton.Invoke((MethodInvoker)(() =>
                {
                    SaveIVButton.Enabled = generatedIVBytes != null;
                }));
                ClearIVButton.Invoke((MethodInvoker)(() =>
                {
                    ClearIVButton.Enabled = generatedIVBytes != null;
                }));
                UseGeneratedIVAsLoadedIVButton.Invoke((MethodInvoker)(() =>
                {
                    UseGeneratedIVAsLoadedIVButton.Enabled = generatedIVBytes != null;
                }));
            });
            Model.IsIVShownChanged += new Action<bool>(isIVShown =>
            {
                if (Model.GeneratedIVBytes == null)
                {
                    GeneratedIVLabel.Invoke((MethodInvoker)(() =>
                    {
                        GeneratedIVLabel.Text = string.Empty;
                    }));
                    return;
                }
                var generatedIVBytesString = default(string);
                if (isIVShown)
                {
                    generatedIVBytesString = string.Join(Environment.NewLine
                        , Model.GeneratedIVBytes.ToHexadecimalString().SplitByChunks(16));
                }
                else
                {
                    generatedIVBytesString = string.Join(Environment.NewLine
                        , string.Join(string.Empty, Enumerable.Repeat("**", (int)BlockSizeSelectorModel.BlockSize))
                        .SplitByChunks(16));
                }
                GeneratedIVLabel.Invoke((MethodInvoker)(() =>
                {
                    GeneratedIVLabel.Text = generatedIVBytesString;
                }));
                var itemText = isIVShown ? "Hide" : "Show";
                if (!ShowOrHideGeneratedIVContextMenuStrip.IsHandleCreated)
                {
                    return;
                }
                ShowOrHideGeneratedIVContextMenuStrip.Invoke((MethodInvoker)(() =>
                {
                    ShowOrHideGeneratedIVContextMenuStripItem.Text = itemText;
                }));
            });
            Model.Initialize();
        }

        #endregion

    }

}