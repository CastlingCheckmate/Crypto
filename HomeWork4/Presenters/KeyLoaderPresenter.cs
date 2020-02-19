using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using MVP.Presenter;

using HomeWork4.Enumerations;
using HomeWork4.Models;

namespace HomeWork4.Presenters
{

    internal sealed class KeyLoaderPresenter : PresenterBase
    {

        #region Fields

        private KeySizeSelectorModel _keySizeSelectorModel;

        #endregion

        #region Control fields

        private Label _loadedKeyLabel;
        private Button _clearKeyButton;

        #endregion

        #region Constructors

        public KeyLoaderPresenter(KeySizeSelectorModel keySizeSelectorModel)
            : base(new KeyLoaderModel(keySizeSelectorModel), "HomeWork4.Presenters.KeyLoaderPresenter.")
        {
            KeySizeSelectorModel = keySizeSelectorModel;
        }

        #endregion

        #region Properties

        internal new KeyLoaderModel Model =>
            base.Model as KeyLoaderModel;

        private KeySizeSelectorModel KeySizeSelectorModel
        {
            get => _keySizeSelectorModel ??
                throw new ArgumentNullException(Path + nameof(KeySizeSelectorModel));

            set => _keySizeSelectorModel = value;
        }

        #endregion

        #region Control properties

        public Label LoadedKeyLabel
        {
            private get => _loadedKeyLabel ??
                throw new ArgumentNullException(Path + nameof(LoadedKeyLabel));

            set => _loadedKeyLabel = value;
        }

        public Button ClearKeyButton
        {
            private get => _clearKeyButton ??
                throw new ArgumentNullException(Path + nameof(ClearKeyButton));

            set => _clearKeyButton = value;
        }

        #endregion

        #region Public methods

        public void LoadKeyBytes()
        {
            var openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory
                , CheckFileExists = true
                , Title = "Browse for Rijndael key file..."
                , Filter = "Rijndael key file (*.rijnkey)|*.rijnkey"
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            using (var keyFileReader = new BinaryReader(File.OpenRead(openFileDialog.FileName)))
            {
                if (keyFileReader.BaseStream.Length != (int)KeySizeSelectorModel.KeySize)
                {
                    Model.LoadedKeyBytes = new byte[0];
                    return;
                }
                var readKeyBytes = new byte[keyFileReader.BaseStream.Length];
                keyFileReader.Read(readKeyBytes, 0, readKeyBytes.Length);
                Model.LoadedKeyBytes = readKeyBytes;
            }
        }

        public void ClearKey()
        {
            Model.LoadedKeyBytes = null;
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.LoadedKeyBytesChanged += new Action<KeyLoaderExitStatus>(keyLoaderExitStatus =>
            {
                switch (keyLoaderExitStatus)
                {
                    case KeyLoaderExitStatus.ValidKey:
                        LoadedKeyLabel.Invoke((MethodInvoker)(() =>
                        {
                            LoadedKeyLabel.ForeColor = Color.Green;
                            LoadedKeyLabel.Text = "Valid key";
                        }));
                        ClearKeyButton.Invoke((MethodInvoker)(() =>
                        {
                            ClearKeyButton.Enabled = true;
                        }));
                        break;
                    case KeyLoaderExitStatus.EmptyKey:
                        LoadedKeyLabel.Invoke((MethodInvoker)(() =>
                        {
                            LoadedKeyLabel.ForeColor = Color.Red;
                            LoadedKeyLabel.Text = "Key not set";
                        }));
                        ClearKeyButton.Invoke((MethodInvoker)(() =>
                        {
                            ClearKeyButton.Enabled = false;
                        }));
                        break;
                    case KeyLoaderExitStatus.InvalidKey:
                        LoadedKeyLabel.Invoke((MethodInvoker)(() =>
                        {
                            LoadedKeyLabel.ForeColor = Color.Red;
                            LoadedKeyLabel.Text = "Invalid key";
                        }));
                        ClearKeyButton.Invoke((MethodInvoker)(() =>
                        {
                            ClearKeyButton.Enabled = false;
                        }));
                        break;
                }
            });
            Model.Initialize();
        }

        #endregion

    }

}