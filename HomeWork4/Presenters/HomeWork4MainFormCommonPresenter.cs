using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Cryptography.HomeWork4;

using MVP.CommonPresenter;
using MVP.Presenter;

using HomeWork4.Enumerations;
using HomeWork4.Exceptions;
using HomeWork4.Forms;
using HomeWork4.Models;

namespace HomeWork4.Presenters
{

    internal sealed class HomeWork4MainFormCommonPresenter : CommonPresenterBase
    {

        #region Control fields

        private HomeWork4MainForm _homeWork4MainForm;

        #endregion

        #region Constructors

        public HomeWork4MainFormCommonPresenter()
            : base("HomeWork4.Presenters.HomeWork4CommonPresenter.")
        {
            Presenters = new Dictionary<string, PresenterBase>();
            Presenters.Add(nameof(IrreduciblePolynomialSelectorPresenter)
                , new IrreduciblePolynomialSelectorPresenter());
            Presenters.Add(nameof(NamesOfFilesSelectorPresenter)
                , new NamesOfFilesSelectorPresenter());
            Presenters.Add(nameof(CipherModeSelectorPresenter)
                , new CipherModeSelectorPresenter());
            Presenters.Add(nameof(KeySizeSelectorPresenter)
                , new KeySizeSelectorPresenter());
            Presenters.Add(nameof(BlockSizeSelectorPresenter)
                , new BlockSizeSelectorPresenter());
            Presenters.Add(nameof(KeyGeneratorPresenter)
                , new KeyGeneratorPresenter(KeySizeSelectorPresenter.Model));
            Presenters.Add(nameof(KeyLoaderPresenter)
                , new KeyLoaderPresenter(KeySizeSelectorPresenter.Model));
            Presenters.Add(nameof(IVGeneratorPresenter)
                , new IVGeneratorPresenter(BlockSizeSelectorPresenter.Model));
            Presenters.Add(nameof(IVLoaderPresenter)
                , new IVLoaderPresenter(BlockSizeSelectorPresenter.Model));
            Presenters.Add(nameof(CipherExecutorPresenter)
                , new CipherExecutorPresenter());
            KeySizeSelectorPresenter.KeyGeneratorModel = KeyGeneratorPresenter.Model;
            KeySizeSelectorPresenter.KeyLoaderModel = KeyLoaderPresenter.Model;
            BlockSizeSelectorPresenter.IVGeneratorModel = IVGeneratorPresenter.Model;
            BlockSizeSelectorPresenter.IVLoaderModel = IVLoaderPresenter.Model;
            CipherModeSelectorPresenter.IVGeneratorModel = IVGeneratorPresenter.Model;
            CipherModeSelectorPresenter.IVLoaderModel = IVLoaderPresenter.Model;
            KeyGeneratorPresenter.KeyLoaderModel = KeyLoaderPresenter.Model;
            IVGeneratorPresenter.IVLoaderModel = IVLoaderPresenter.Model;
        }

        #endregion

        #region Properties

        public bool IsGeneratedKeyEmpty =>
            KeyGeneratorPresenter.IsGeneratedKeyEmpty;

        public bool IsGeneratedIVEmpty =>
            IVGeneratorPresenter.IsGeneratedIVEmpty;

        #endregion

        #region Presenter properties

        private IrreduciblePolynomialSelectorPresenter IrreduciblePolynomialSelectorPresenter =>
            Presenters[nameof(IrreduciblePolynomialSelectorPresenter)] as IrreduciblePolynomialSelectorPresenter;

        private NamesOfFilesSelectorPresenter NamesOfFilesSelectorPresenter =>
            Presenters[nameof(NamesOfFilesSelectorPresenter)] as NamesOfFilesSelectorPresenter;

        private CipherModeSelectorPresenter CipherModeSelectorPresenter =>
            Presenters[nameof(CipherModeSelectorPresenter)] as CipherModeSelectorPresenter;

        private KeySizeSelectorPresenter KeySizeSelectorPresenter =>
            Presenters[nameof(KeySizeSelectorPresenter)] as KeySizeSelectorPresenter;

        private BlockSizeSelectorPresenter BlockSizeSelectorPresenter =>
            Presenters[nameof(BlockSizeSelectorPresenter)] as BlockSizeSelectorPresenter;

        private KeyGeneratorPresenter KeyGeneratorPresenter =>
            Presenters[nameof(KeyGeneratorPresenter)] as KeyGeneratorPresenter;

        private KeyLoaderPresenter KeyLoaderPresenter =>
            Presenters[nameof(KeyLoaderPresenter)] as KeyLoaderPresenter;

        private IVGeneratorPresenter IVGeneratorPresenter =>
            Presenters[nameof(IVGeneratorPresenter)] as IVGeneratorPresenter;

        private IVLoaderPresenter IVLoaderPresenter =>
            Presenters[nameof(IVLoaderPresenter)] as IVLoaderPresenter;

        private CipherExecutorPresenter CipherExecutorPresenter =>
            Presenters[nameof(CipherExecutorPresenter)] as CipherExecutorPresenter;

        #endregion

        #region Control setters

        public HomeWork4MainForm HomeWork4MainForm
        {
            private get => _homeWork4MainForm ??
                throw new ArgumentNullException(Path + nameof(HomeWork4MainForm));

            set => _homeWork4MainForm = value;
        }

        public ComboBox IrreduciblePolynomialComboBox
        {
            set => IrreduciblePolynomialSelectorPresenter.IrreduciblePolynomialComboBox = value;
        }

        public Label LoseFocusFromIrreduciblePolynomialComboBox
        {
            set => IrreduciblePolynomialSelectorPresenter.LoseFocusFromIrreduciblePolynomialComboBoxLabel = value;
        }

        public TextBox InputFileNameTextBox
        {
            set => NamesOfFilesSelectorPresenter.InputFileNameTextBox = value;
        }

        public TextBox OutputFileNameTextBox
        {
            set => NamesOfFilesSelectorPresenter.OutputFileNameTextBox = value;
        }

        public Button ExchangeNamesOfFilesButton
        {
            set => NamesOfFilesSelectorPresenter.ExchangeNamesOfFilesButton = value;
        }

        public GroupBox BlockSizeSelectorGroupBox
        {
            set => BlockSizeSelectorPresenter.BlockSizeSelectorGroupBox = value;
        }

        public GroupBox KeySizeSelectorGroupBox
        {
            set => KeySizeSelectorPresenter.KeySizeSelectorGroupBox = value;
        }

        public GroupBox CipherModeSelectorGroupBox
        {
            set => CipherModeSelectorPresenter.CipherModeSelectorGroupBox = value;
        }

        public Label GeneratedKeyLabel
        {
            set => KeyGeneratorPresenter.GeneratedKeyLabel = value;
        }

        public ContextMenuStrip ShowOrHideGeneratedKeyContextMenuStrip
        {
            set => KeyGeneratorPresenter.ShowOrHideGeneratedKeyContextMenuStrip = value;
        }

        public ToolStripMenuItem ShowOrHideGeneratedKeyContextMenuStripItem
        {
            set => KeyGeneratorPresenter.ShowOrHideGeneratedKeyContextMenuStripItem = value;
        }

        public ContextMenuStrip ShowOrHideGeneratedIVContextMenuStrip
        {
            set => IVGeneratorPresenter.ShowOrHideGeneratedIVContextMenuStrip = value;
        }

        public ToolStripMenuItem ShowOrHideGeneratedIVContextMenuStripItem
        {
            set => IVGeneratorPresenter.ShowOrHideGeneratedIVContextMenuStripItem = value;
        }

        public Label KeyLoadingResultLabel
        {
            set => KeyLoaderPresenter.LoadedKeyLabel = value;
        }

        public Label GeneratedIVLabel
        {
            set => IVGeneratorPresenter.GeneratedIVLabel = value;
        }

        public Label IVLoadingResultLabel
        {
            set => IVLoaderPresenter.LoadedIVLabel = value;
        }

        public Button SaveKeyButton
        {
            set => KeyGeneratorPresenter.SaveKeyButton = value;
        }

        public Button ClearGeneratedKeyButton
        {
            set => KeyGeneratorPresenter.ClearKeyButton = value;
        }

        public Button UseGeneratedKeyAsLoadedKeyButton
        {
            set => KeyGeneratorPresenter.UseGeneratedKeyAsLoadedKeyButton = value;
        }

        public Button ClearLoadedKeyButton
        {
            set => KeyLoaderPresenter.ClearKeyButton = value;
        }

        public Button SaveIVButton
        {
            set => IVGeneratorPresenter.SaveIVButton = value;
        }

        public Button ClearGeneratedIVButton
        {
            set => IVGeneratorPresenter.ClearIVButton = value;
        }

        public Button UseGeneratedIVAsLoadedIVButton
        {
            set => IVGeneratorPresenter.UseGeneratedIVAsLoadedIVButton = value;
        }

        public Button ClearLoadedIVButton
        {
            set => IVLoaderPresenter.ClearIVButton = value;
        }

        public GroupBox IVGeneratorGroupBox
        {
            set => CipherModeSelectorPresenter.IVGeneratorGroupBox = value;
        }

        public GroupBox IVLoaderGroupBox
        {
            set => CipherModeSelectorPresenter.IVLoaderGroupBox = value;
        }

        public MenuStrip MainMenu
        {
            set => CipherExecutorPresenter.MainMenu = value;
        }

        public ToolStripMenuItem StartEncryptionOperationMainMenuItem
        {
            set => CipherExecutorPresenter.StartEncryptionOperationMainMenuItem = value;
        }

        public ToolStripMenuItem StartDecryptionOperationMainMenuItem
        {
            set => CipherExecutorPresenter.StartDecryptionOperationMainMenuItem = value;
        }

        public StatusStrip StatusBar
        {
            set => CipherExecutorPresenter.StatusBar = value;
        }

        public ToolStripProgressBar CipherExecutionStatusProgressBar
        {
            set => CipherExecutorPresenter.CipherExecutionStatusProgressBar = value;
        }

        public ToolStripStatusLabel CipherExecutionStatusLabel
        {
            set => CipherExecutorPresenter.CipherExecutionStatusLabel = value;
        }

        public ToolStripDropDownButton StopCipherOperationExecutionButton
        {
            set => CipherExecutorPresenter.StopCipherOperationExecutionButton = value;
        }

        #endregion

        #region Public methods

        public void ShowAboutAndInstructionsBox()
        {
            new AboutAndInstructionsForm().ShowDialog();
        }

        public void SetSelectedIrreduciblePolynomialIndex(byte selectedIrreduciblePolynomialIndex)
        {
            IrreduciblePolynomialSelectorPresenter.SetSelectedIrreduciblePolynomialIndex(selectedIrreduciblePolynomialIndex);
        }

        public void CancelSettingSelectedIrreduciblePolynomial()
        {
            IrreduciblePolynomialSelectorPresenter.CancelSettingSelectedIrreduciblePolynomial();
        }

        public void BrowseForInputFileName()
        {
            NamesOfFilesSelectorPresenter.BrowseForInputFileName();
        }

        public void BrowseForOutputFileName()
        {
            NamesOfFilesSelectorPresenter.BrowseForOutputFileName();
        }

        public void ExchangeNamesOfFiles()
        {
            NamesOfFilesSelectorPresenter.ExchangeNamesOfFiles();
        }

        public void ExchangeNamesOfFilesButtonMouseEnter()
        {
            NamesOfFilesSelectorPresenter.OnExchangeNamesOfFilesButtonMouseEnter();
        }

        public void ExchangeNamesOfFilesButtonMouseLeave()
        {
            NamesOfFilesSelectorPresenter.OnExchangeNamesOfFilesButtonMouseLeave();
        }

        public void SetBlockSize(RijndaelBlockSizes blockSize)
        {
            BlockSizeSelectorPresenter.SetBlockSize(blockSize);
        }

        public void SetKeySize(RijndaelKeySizes keySize)
        {
            KeySizeSelectorPresenter.SetKeySize(keySize);
        }

        public void SetCipherMode(SymmetricCipherModes cipherMode)
        {
            CipherModeSelectorPresenter.SetCipherMode(cipherMode);
        }

        public void GenerateKey()
        {
            KeyGeneratorPresenter.GenerateKeyBytes();
        }

        public void SaveKey()
        {
            KeyGeneratorPresenter.SaveKey();
        }

        public void ClearGeneratedKey()
        {
            KeyGeneratorPresenter.ClearKey();
        }

        public void ShowOrHideGeneratedKey()
        {
            KeyGeneratorPresenter.ShowOrHideKey();
        }

        public void UseGeneratedKeyAsLoadedKey()
        {
            KeyGeneratorPresenter.UseKeyAsLoaded();
        }

        public void UseGeneratedKeyAsLoadedKeyButtonMouseEnter()
        {
            KeyGeneratorPresenter.OnUseGeneratedKeyAsLoadedKeyButtonMouseEnter();
        }

        public void UseGeneratedKeyAsLoadedKeyButtonMouseLeave()
        {
            KeyGeneratorPresenter.OnUseGeneratedKeyAsLoadedKeyButtonMouseLeave();
        }

        public void LoadKey()
        {
            KeyLoaderPresenter.LoadKeyBytes();
        }

        public void ClearLoadedKey()
        {
            KeyLoaderPresenter.ClearKey();
        }

        public void GenerateIV()
        {
            IVGeneratorPresenter.GenerateIVBytes();
        }

        public void SaveIV()
        {
            IVGeneratorPresenter.SaveIV();
        }

        public void ClearGeneratedIV()
        {
            IVGeneratorPresenter.ClearIV();
        }

        public void ShowOrHideGeneratedIV()
        {
            IVGeneratorPresenter.ShowOrHideIV();
        }

        public void UseGeneratedIVAsLoadedIV()
        {
            IVGeneratorPresenter.UseIVAsLoaded();
        }

        public void UseGeneratedIVAsLoadedIVButtonMouseEnter()
        {
            IVGeneratorPresenter.OnUseGeneratedIVAsLoadedIVButtonMouseEnter();
        }

        public void UseGeneratedIVAsLoadedIVButtonMouseLeave()
        {
            IVGeneratorPresenter.OnUseGeneratedIVAsLoadedIVButtonMouseLeave();
        }

        public void LoadIV()
        {
            IVLoaderPresenter.LoadIVBytes();
        }

        public void ClearLoadedIV()
        {
            IVLoaderPresenter.ClearIV();
        }

        public async void StartCipherOperationExecution(CipherOperations cipherOperation)
        {
            var cipherOperationParameters = new CipherOperationParameters
            {
                CipherOperation = cipherOperation
                , InputFileName = NamesOfFilesSelectorPresenter.Model.InputFileName
                , OutputFileName = NamesOfFilesSelectorPresenter.Model.OutputFileName
                , BlockSize = BlockSizeSelectorPresenter.Model.BlockSize
                , KeySize = KeySizeSelectorPresenter.Model.KeySize
                , CipherMode = CipherModeSelectorPresenter.Model.SelectedCipherMode
                , Key = KeyLoaderPresenter.Model.LoadedKeyBytes
                , IV = IVLoaderPresenter.Model.LoadedIVBytes
                , IrreduciblePolynomial = IrreduciblePolynomialSelectorPresenter.Model.SelectedIrreduciblePolynomial
            };
            try
            {
                await CipherExecutorPresenter.Execute(cipherOperationParameters);
            }
            catch (InvalidCipherOperationParametersException ex)
            {
                MessageBox.Show(HomeWork4MainForm, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileFormatException ex)
            {
                MessageBox.Show(HomeWork4MainForm, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(HomeWork4MainForm, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show(HomeWork4MainForm, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StopCipherOperationExecution()
        {
            CipherExecutorPresenter.StopExecution();
        }

        public bool ClosingRequested()
        {
            if (!CipherExecutorPresenter.IsExecuting)
            {
                return false;
            }
            var messageBoxText = "Please wait for cipher operation completion or cancel it.";
            var messageBoxCaption = "Information";
            MessageBox.Show(HomeWork4MainForm, messageBoxText, messageBoxCaption, MessageBoxButtons.OK
                , MessageBoxIcon.Information);
            return true;
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            KeyGeneratorPresenter.KeySavingSucceeded += new Action<string>(fileName =>
            {
                var messageBoxText = $"Key successfully saved to file {fileName}.";
                var messageBoxCaption = "Information";
                MessageBox.Show(HomeWork4MainForm, messageBoxText, messageBoxCaption, MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            });
            IVGeneratorPresenter.IVSavingSucceeded += new Action<string>(fileName =>
            {
                var messageBoxText = $"IV successfully saved to file {fileName}.";
                var messageBoxCaption = "Information";
                MessageBox.Show(HomeWork4MainForm, messageBoxText, messageBoxCaption, MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            });
            CipherExecutorPresenter.CipherOperationCompleted += new Action<CipherOperations>((cipherOperation) =>
            {
                var messageBoxText = $"{Enum.GetName(typeof(CipherOperations), cipherOperation)} " +
                    $"operation completed successfully.";
                var messageBoxCaption = "Information";
                MessageBox.Show(HomeWork4MainForm, messageBoxText, messageBoxCaption, MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            });
            foreach (var presenter in Presenters.Values)
            {
                presenter.Initialize();
            }
        }

        #endregion

        #region IDisposable interface implementation

        public override void Dispose()
        {
            CipherExecutorPresenter.Dispose();
        }

        #endregion

    }

}