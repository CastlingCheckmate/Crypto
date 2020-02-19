using System;
using System.Linq;
using System.Windows.Forms;

using Cryptography.HomeWork4;

using MVP.Presenter;

using HomeWork4.Models;

namespace HomeWork4.Presenters
{

    internal sealed class CipherModeSelectorPresenter : PresenterBase
    {

        #region Fields

        private IVGeneratorModel _IVGeneratorModel;
        private IVLoaderModel _IVLoaderModel;

        #endregion

        #region Control fields

        private GroupBox _cipherModeSelectorGroupBox;
        private GroupBox _IVGeneratorGroupBox;
        private GroupBox _IVLoaderGroupBox;

        #endregion

        #region Constructors

        public CipherModeSelectorPresenter()
            : base(new CipherModeSelectorModel(), "HomeWork4.Presenters.CipherModeSelectorPresenter.")
        {

        }

        #endregion

        #region Properties

        internal new CipherModeSelectorModel Model =>
            base.Model as CipherModeSelectorModel;

        #endregion

        #region Dependency injection properties

        public IVGeneratorModel IVGeneratorModel
        {
            get => _IVGeneratorModel ??
                throw new ArgumentNullException(Path + nameof(IVGeneratorModel));

            set => _IVGeneratorModel = value;
        }

        public IVLoaderModel IVLoaderModel
        {
            get => _IVLoaderModel ??
                throw new ArgumentNullException(Path + nameof(IVLoaderModel));

            set => _IVLoaderModel = value;
        }

        #endregion

        #region Control properties

        public GroupBox CipherModeSelectorGroupBox
        {
            private get => _cipherModeSelectorGroupBox ??
                throw new ArgumentNullException(Path + nameof(CipherModeSelectorGroupBox));

            set => _cipherModeSelectorGroupBox = value;
        }

        public GroupBox IVGeneratorGroupBox
        {
            private get => _IVGeneratorGroupBox ??
                throw new ArgumentNullException(Path + nameof(IVGeneratorGroupBox));

            set => _IVGeneratorGroupBox = value;
        }

        public GroupBox IVLoaderGroupBox
        {
            private get => _IVLoaderGroupBox ??
                throw new ArgumentNullException(Path + nameof(IVLoaderGroupBox));

            set => _IVLoaderGroupBox = value;
        }

        #endregion

        #region Public methods

        public void SetCipherMode(SymmetricCipherModes cipherMode)
        {
            Model.SelectedCipherMode = cipherMode;
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.SelectedCipherModeChanged += new Action<SymmetricCipherModes>(cipherMode =>
            {
                foreach (var cipherModeRadioButton in CipherModeSelectorGroupBox.Controls.OfType<RadioButton>())
                {
                    IVGeneratorGroupBox.Invoke((MethodInvoker)(() =>
                    {
                        IVGeneratorGroupBox.Enabled =
                            cipherMode != SymmetricCipherModes.ElectronicCodeBook;
                    }));
                    IVLoaderGroupBox.Invoke((MethodInvoker)(() =>
                    {
                        IVLoaderGroupBox.Enabled =
                            cipherMode != SymmetricCipherModes.ElectronicCodeBook;
                    }));
                    if ((SymmetricCipherModes)cipherModeRadioButton.Tag == cipherMode)
                    {
                        cipherModeRadioButton.Invoke((MethodInvoker)(() =>
                        {
                            cipherModeRadioButton.Checked = true;
                        }));
                    }
                    else
                    {
                        cipherModeRadioButton.Invoke((MethodInvoker)(() =>
                        {
                            cipherModeRadioButton.Checked = false;
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