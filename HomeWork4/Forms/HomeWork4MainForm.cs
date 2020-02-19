using System;
using System.ComponentModel;
using System.Windows.Forms;

using Cryptography.HomeWork4;

using HomeWork4.Enumerations;
using HomeWork4.Forms.ProfessionalColorTables;
using HomeWork4.Presenters;

namespace HomeWork4.Forms
{

    public partial class HomeWork4MainForm : Form
    {

        #region Fields

        private HomeWork4MainFormCommonPresenter _presenter;

        #endregion

        #region Constructors

        public HomeWork4MainForm()
        {
            InitializeComponent();
            mainMenu.Renderer = new ToolStripProfessionalRenderer(new MainMenuColorTable());
            showOrHideGeneratedKeyContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(
                new MainMenuColorTable());
            showOrHideGeneratedIVContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(
                new MainMenuColorTable());
            Presenter = new HomeWork4MainFormCommonPresenter
            {
                HomeWork4MainForm = this
                , IrreduciblePolynomialComboBox = irreduciblePolynomialComboBox
                , LoseFocusFromIrreduciblePolynomialComboBox = inputFileNameLabel
                , InputFileNameTextBox = inputFileNameTextBox
                , OutputFileNameTextBox = outputFileNameTextBox
                , ExchangeNamesOfFilesButton = exchangeNamesOfFilesButton
                , BlockSizeSelectorGroupBox = blockSizeSelectorGroupBox
                , KeySizeSelectorGroupBox = keySizeSelectorGroupBox
                , CipherModeSelectorGroupBox = cipherModeSelectorGroupBox
                , GeneratedKeyLabel = generatedKeyLabel
                , KeyLoadingResultLabel = keyLoadingResultLabel
                , GeneratedIVLabel = generatedIVLabel
                , IVLoadingResultLabel = IVLoadingResultLabel
                , ClearGeneratedKeyButton = clearGeneratedKeyButton
                , UseGeneratedKeyAsLoadedKeyButton = useGeneratedKeyAsLoadedKeyButton
                , SaveKeyButton = saveKeyButton
                , ClearLoadedKeyButton = clearLoadedKeyButton
                , ClearGeneratedIVButton = clearGeneratedIVButton
                , SaveIVButton = saveIVButton
                , ClearLoadedIVButton = clearLoadedIVButton
                , UseGeneratedIVAsLoadedIVButton = useGeneratedIVAsLoadedIVButton
                , IVGeneratorGroupBox = IVGeneratorGroupBox
                , IVLoaderGroupBox = IVGroupBox
                , MainMenu = mainMenu
                , StartEncryptionOperationMainMenuItem = startEncryptionOperationMainMenuItem
                , StartDecryptionOperationMainMenuItem = startDecryptionOperationMainMenuItem
                , StatusBar = statusBar
                , CipherExecutionStatusProgressBar = cipherExecutionStatusProgressBar
                , CipherExecutionStatusLabel = cipherExecutionStatusLabel
                , StopCipherOperationExecutionButton = stopCipherOperationExecutionButton
                , ShowOrHideGeneratedKeyContextMenuStrip = showOrHideGeneratedKeyContextMenuStrip
                , ShowOrHideGeneratedKeyContextMenuStripItem = showOrHideGeneratedKeyContextMenuStripItem
                , ShowOrHideGeneratedIVContextMenuStrip = showOrHideGeneratedIVContextMenuStrip
                , ShowOrHideGeneratedIVContextMenuStripItem = showOrHideGeneratedIVContextMenuStripItem
            };
        }

        #endregion

        #region Properties

        private HomeWork4MainFormCommonPresenter Presenter
        {
            get => _presenter ??
                throw new ArgumentNullException("HomeWork4.Forms.HomeWork4MainForm." + nameof(Presenter));

            set => _presenter = value;
        }

        #endregion

        #region Event handlers

        private void HomeWork4MainForm_Load(object sender, EventArgs e)
        {
            Presenter.Initialize();
        }

        private void HomeWork4MainForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Presenter.ShowAboutAndInstructionsBox();
            e.Cancel = true;
        }

        private void irreduciblePolynomialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            irreduciblePolynomialComboBox.DropDownClosed -= irreduciblePolynomialComboBox_DropDownClosed;
            Presenter.SetSelectedIrreduciblePolynomialIndex((byte)(sender as ComboBox).SelectedIndex);
            irreduciblePolynomialComboBox.DropDownClosed += irreduciblePolynomialComboBox_DropDownClosed;
        }

        private void irreduciblePolynomialComboBox_DropDownClosed(object sender, EventArgs e)
        {
            Presenter.SetSelectedIrreduciblePolynomialIndex((byte)(sender as ComboBox).SelectedIndex);
            Presenter.CancelSettingSelectedIrreduciblePolynomial();
        }

        private void irreduciblePolynomialComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void browseForInputFileNameButton_Click(object sender, EventArgs e)
        {
            Presenter.BrowseForInputFileName();
        }

        private void browseForOutputFileNameButton_Click(object sender, EventArgs e)
        {
            Presenter.BrowseForOutputFileName();
        }

        private void exchangeNamesOfFilesButton_Click(object sender, EventArgs e)
        {
            Presenter.ExchangeNamesOfFiles();
        }

        private void exchangeNamesOfFilesButton_MouseEnter(object sender, EventArgs e)
        {
            Presenter.ExchangeNamesOfFilesButtonMouseEnter();
        }

        private void exchangeNamesOfFilesButton_MouseLeave(object sender, EventArgs e)
        {
            Presenter.ExchangeNamesOfFilesButtonMouseLeave();
        }

        private void anyKeySizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var keySizeRadioButton = sender as RadioButton;
            if (!keySizeRadioButton.Checked)
            {
                return;
            }
            Presenter.SetKeySize((RijndaelKeySizes)keySizeRadioButton.Tag);
        }

        private void anyBlockSizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var blockSizeRadioButton = sender as RadioButton;
            if (!blockSizeRadioButton.Checked)
            {
                return;
            }
            Presenter.SetBlockSize((RijndaelBlockSizes)blockSizeRadioButton.Tag);
        }

        private void anyCipherModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var cipherModeRadioButton = sender as RadioButton;
            if (!cipherModeRadioButton.Checked)
            {
                return;
            }
            Presenter.SetCipherMode((SymmetricCipherModes)cipherModeRadioButton.Tag);
        }

        private void generateKeyButton_Click(object sender, EventArgs e)
        {
            Presenter.GenerateKey();
        }

        private void saveKeyButton_Click(object sender, EventArgs e)
        {
            Presenter.SaveKey();
        }

        private void clearGeneratedKeyButton_Click(object sender, EventArgs e)
        {
            Presenter.ClearGeneratedKey();
        }

        private void useGeneratedKeyAsLoadedKeyButton_Click(object sender, EventArgs e)
        {
            Presenter.UseGeneratedKeyAsLoadedKey();
        }

        private void loadKeyButton_Click(object sender, EventArgs e)
        {
            Presenter.LoadKey();
        }

        private void clearLoadedKeyButton_Click(object sender, EventArgs e)
        {
            Presenter.ClearLoadedKey();
        }

        private void generateIVButton_Click(object sender, EventArgs e)
        {
            Presenter.GenerateIV();
        }

        private void saveIVButton_Click(object sender, EventArgs e)
        {
            Presenter.SaveIV();
        }

        private void clearGeneratedIVButton_Click(object sender, EventArgs e)
        {
            Presenter.ClearGeneratedIV();
        }

        private void useGeneratedIVAsLoadedIVButton_Click(object sender, EventArgs e)
        {
            Presenter.UseGeneratedIVAsLoadedIV();
        }

        private void loadIVButton_Click(object sender, EventArgs e)
        {
            Presenter.LoadIV();
        }

        private void clearLoadedIVButton_Click(object sender, EventArgs e)
        {
            Presenter.ClearLoadedIV();
        }

        private void anyCipherOperationMainMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.StartCipherOperationExecution((CipherOperations)(sender as ToolStripMenuItem).Tag);
        }

        private void stopCipherOperationExecutionButton_Click(object sender, EventArgs e)
        {
            Presenter.StopCipherOperationExecution();
        }

        private void showOrHideGeneratedKeyContextMenuStripItem_Click(object sender, EventArgs e)
        {
            Presenter.ShowOrHideGeneratedKey();
        }

        private void showOrHideGeneratedIVContextMenuStripItem_Click(object sender, EventArgs e)
        {
            Presenter.ShowOrHideGeneratedIV();
        }

        private void showOrHideGeneratedKeyContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = Presenter.IsGeneratedKeyEmpty;
        }

        private void showOrHideGeneratedIVContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = Presenter.IsGeneratedIVEmpty;
        }

        private void HomeWork4MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = Presenter.ClosingRequested();
        }
        
        private void useGeneratedKeyAsLoadedKeyButton_MouseEnter(object sender, EventArgs e)
        {
            Presenter.UseGeneratedKeyAsLoadedKeyButtonMouseEnter();
        }

        private void useGeneratedKeyAsLoadedKeyButton_MouseLeave(object sender, EventArgs e)
        {
            Presenter.UseGeneratedKeyAsLoadedKeyButtonMouseLeave();
        }

        private void useGeneratedIVAsLoadedIVButton_MouseEnter(object sender, EventArgs e)
        {
            Presenter.UseGeneratedIVAsLoadedIVButtonMouseEnter();
        }

        private void useGeneratedIVAsLoadedIVButton_MouseLeave(object sender, EventArgs e)
        {
            Presenter.UseGeneratedIVAsLoadedIVButtonMouseLeave();
        }

        #endregion

    }

}