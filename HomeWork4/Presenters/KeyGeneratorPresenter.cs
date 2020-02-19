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

    internal sealed class KeyGeneratorPresenter : PresenterBase
    {

        #region Fields

        private KeySizeSelectorModel _keySizeSelectorModel;
        private KeyLoaderModel _keyLoaderModel;

        #endregion

        #region Control fields

        private Label _generatedKeyLabel;
        private Button _saveKeyButton;
        private Button _clearKeyButton;
        private ContextMenuStrip _showOrHideGeneratedKeyContextMenuStrip;
        private ToolStripMenuItem _showOrHideGeneratedKeyContextMenuStripItem;
        private Button _useGeneratedKeyAsLoadedKeyButton;

        #endregion

        #region Constructors

        public KeyGeneratorPresenter(KeySizeSelectorModel keySizeSelectorModel)
            : base(new KeyGeneratorModel(), "HomeWork4.Presenters.KeyGeneratorPresenter.")
        {
            KeySizeSelectorModel = keySizeSelectorModel;
        }

        #endregion

        #region Properties

        internal new KeyGeneratorModel Model =>
            base.Model as KeyGeneratorModel;

        private KeySizeSelectorModel KeySizeSelectorModel
        {
            get => _keySizeSelectorModel ??
                throw new ArgumentNullException(Path + nameof(KeySizeSelectorModel));

            set => _keySizeSelectorModel = value;
        }

        public bool IsGeneratedKeyEmpty =>
            Model.GeneratedKeyBytes == null;

        #endregion

        #region Dependency injection properties

        public KeyLoaderModel KeyLoaderModel
        {
            private get => _keyLoaderModel ??
                throw new ArgumentNullException(Path + nameof(KeyLoaderModel));

            set => _keyLoaderModel = value;
        }

        #endregion

        #region Control properties

        public Label GeneratedKeyLabel
        {
            private get => _generatedKeyLabel ??
                throw new ArgumentNullException(Path + nameof(GeneratedKeyLabel));

            set => _generatedKeyLabel = value;
        }

        public Button SaveKeyButton
        {
            private get => _saveKeyButton ??
                throw new ArgumentNullException(Path + nameof(SaveKeyButton));

            set => _saveKeyButton = value;
        }

        public Button ClearKeyButton
        {
            private get => _clearKeyButton ??
                throw new ArgumentNullException(Path + nameof(ClearKeyButton));

            set => _clearKeyButton = value;
        }

        public ContextMenuStrip ShowOrHideGeneratedKeyContextMenuStrip
        {
            private get => _showOrHideGeneratedKeyContextMenuStrip ??
                throw new ArgumentNullException(Path + nameof(ShowOrHideGeneratedKeyContextMenuStrip));

            set => _showOrHideGeneratedKeyContextMenuStrip = value;
        }

        public ToolStripMenuItem ShowOrHideGeneratedKeyContextMenuStripItem
        {
            private get => _showOrHideGeneratedKeyContextMenuStripItem ??
                throw new ArgumentNullException(Path + nameof(ShowOrHideGeneratedKeyContextMenuStripItem));

            set => _showOrHideGeneratedKeyContextMenuStripItem = value;
        }

        public Button UseGeneratedKeyAsLoadedKeyButton
        {
            private get => _useGeneratedKeyAsLoadedKeyButton ??
                throw new ArgumentNullException(Path + nameof(UseGeneratedKeyAsLoadedKeyButton));

            set => _useGeneratedKeyAsLoadedKeyButton = value;
        }

        #endregion

        #region Public methods

        public void GenerateKeyBytes()
        {
            var generatedKeyBytes = new byte[(int)KeySizeSelectorModel.KeySize];
            new Random().NextBytes(generatedKeyBytes);
            Model.GeneratedKeyBytes = generatedKeyBytes;
        }

        public void SaveKey()
        {
            var saveFileDialog = new SaveFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory
                , OverwritePrompt = true
                , Title = "Browse for output file..."
                , Filter = "Rijndael key file (*.rijnkey)|*.rijnkey"
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            using (var keyFileWriter = new BinaryWriter(File.OpenWrite(saveFileDialog.FileName)))
            {
                keyFileWriter.Write(Model.GeneratedKeyBytes);
            }
            KeySavingSucceeded?.Invoke(saveFileDialog.FileName);
        }

        public void ClearKey()
        {
            Model.GeneratedKeyBytes = null;
        }

        public void ShowOrHideKey()
        {
            Model.IsKeyShown = !Model.IsKeyShown;
        }

        public void UseKeyAsLoaded()
        {
            KeyLoaderModel.LoadedKeyBytes = Model.GeneratedKeyBytes;
        }

        public void OnUseGeneratedKeyAsLoadedKeyButtonMouseEnter()
        {
            UseGeneratedKeyAsLoadedKeyButton.Invoke((MethodInvoker)(() =>
            {
                UseGeneratedKeyAsLoadedKeyButton.Image = Properties.Resources.UseGeneratedKeyOrIVAsLoadedEntered;
            }));
        }

        public void OnUseGeneratedKeyAsLoadedKeyButtonMouseLeave()
        {
            UseGeneratedKeyAsLoadedKeyButton.Invoke((MethodInvoker)(() =>
            {
                UseGeneratedKeyAsLoadedKeyButton.Image = Properties.Resources.UseGeneratedKeyOrIVAsLoadedLeft;
            }));
        }

        #endregion

        #region Events

        public event Action<string> KeySavingSucceeded;

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.GeneratedKeyBytesChanged += new Action<byte[]>(generatedKeyBytes =>
            {
                Model.IsKeyShown = false;
                SaveKeyButton.Invoke((MethodInvoker)(() =>
                {
                    SaveKeyButton.Enabled = generatedKeyBytes != null;
                }));
                ClearKeyButton.Invoke((MethodInvoker)(() =>
                {
                    ClearKeyButton.Enabled = generatedKeyBytes != null;
                }));
                UseGeneratedKeyAsLoadedKeyButton.Invoke((MethodInvoker)(() =>
                {
                    UseGeneratedKeyAsLoadedKeyButton.Enabled = generatedKeyBytes != null;
                }));
            });
            Model.IsKeyShownChanged += new Action<bool>(isKeyShown =>
            {
                if (Model.GeneratedKeyBytes == null)
                {
                    GeneratedKeyLabel.Invoke((MethodInvoker)(() =>
                    {
                        GeneratedKeyLabel.Text = string.Empty;
                    }));
                    return;
                }
                var generatedKeyBytesString = default(string);
                if (isKeyShown)
                {
                    generatedKeyBytesString = string.Join(Environment.NewLine
                        , Model.GeneratedKeyBytes.ToHexadecimalString().SplitByChunks(16));
                }
                else
                {
                    generatedKeyBytesString = string.Join(Environment.NewLine
                        , string.Join(string.Empty, Enumerable.Repeat("**", (int)KeySizeSelectorModel.KeySize))
                        .SplitByChunks(16));
                }
                GeneratedKeyLabel.Invoke((MethodInvoker)(() =>
                {
                    GeneratedKeyLabel.Text = generatedKeyBytesString;
                }));
                var itemText = isKeyShown ? "Hide" : "Show";
                if (!ShowOrHideGeneratedKeyContextMenuStrip.IsHandleCreated)
                {
                    return;
                }
                ShowOrHideGeneratedKeyContextMenuStrip.Invoke((MethodInvoker)(() =>
                {
                    ShowOrHideGeneratedKeyContextMenuStripItem.Text = itemText;
                }));
            });
            Model.Initialize();
        }

        #endregion

    }

}