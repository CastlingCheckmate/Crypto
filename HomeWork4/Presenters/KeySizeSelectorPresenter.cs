using System;
using System.Linq;
using System.Windows.Forms;

using Cryptography.HomeWork4;

using MVP.Presenter;

using HomeWork4.Models;

namespace HomeWork4.Presenters
{

    internal sealed class KeySizeSelectorPresenter : PresenterBase
    {

        #region Fields

        private KeyGeneratorModel _keyGeneratorModel;
        private KeyLoaderModel _keyLoaderModel;

        #endregion

        #region Control fields

        private GroupBox _keySizeSelectorGroupBox;

        #endregion

        #region Constructors

        public KeySizeSelectorPresenter()
            : base(new KeySizeSelectorModel(), "HomeWork4.Presenters.KeySizeSelectorPresenter.")
        {

        }

        #endregion

        #region Properties

        internal new KeySizeSelectorModel Model =>
            base.Model as KeySizeSelectorModel;

        #endregion

        #region Dependency injection properties

        public KeyGeneratorModel KeyGeneratorModel
        {
            private get => _keyGeneratorModel ??
                throw new ArgumentNullException(Path + nameof(KeyGeneratorModel));

            set => _keyGeneratorModel = value;
        }

        public KeyLoaderModel KeyLoaderModel
        {
            private get => _keyLoaderModel ??
                throw new ArgumentNullException(Path + nameof(KeyLoaderModel));

            set => _keyLoaderModel = value;
        }

        #endregion

        #region Control properties

        public GroupBox KeySizeSelectorGroupBox
        {
            private get => _keySizeSelectorGroupBox ??
                throw new ArgumentNullException(Path + nameof(KeySizeSelectorGroupBox));

            set => _keySizeSelectorGroupBox = value;
        }

        #endregion

        #region Public methods

        public void SetKeySize(RijndaelKeySizes keySize)
        {
            Model.KeySize = keySize;
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.KeySizeChanged += new Action<RijndaelKeySizes>(keySize =>
            {
                foreach (var keySizeRadioButton in KeySizeSelectorGroupBox.Controls.OfType<RadioButton>())
                {
                    if ((RijndaelKeySizes)keySizeRadioButton.Tag == keySize)
                    {
                        keySizeRadioButton.Invoke((MethodInvoker)(() =>
                        {
                            keySizeRadioButton.Checked = true;
                        }));
                    }
                    else
                    {
                        keySizeRadioButton.Invoke((MethodInvoker)(() =>
                        {
                            keySizeRadioButton.Checked = false;
                        }));
                    }
                }
                KeyGeneratorModel.GeneratedKeyBytes = null;
                KeyLoaderModel.LoadedKeyBytes = null;
            });
            Model.Initialize();
        }

        #endregion

    }

}