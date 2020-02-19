using System;
using System.Windows.Forms;

using MVP.Presenter;

using HomeWork4.Models;

namespace HomeWork4.Presenters
{

    internal sealed class NamesOfFilesSelectorPresenter : PresenterBase
    {

        #region Control fields

        private TextBox _inputFileNameTextBox;
        private TextBox _outputFileNameTextBox;
        private Button _exchangeNamesOfFilesButton;

        #endregion

        #region Constructors

        public NamesOfFilesSelectorPresenter()
            : base(new NamesOfFilesSelectorModel(), "HomeWork4.Presenters.NamesOfFilesSelectorPresenter.")
        {

        }

        #endregion

        #region Control properties

        public TextBox InputFileNameTextBox
        {
            private get => _inputFileNameTextBox ??
                throw new ArgumentNullException(Path + nameof(InputFileNameTextBox));

            set => _inputFileNameTextBox = value;
        }

        public TextBox OutputFileNameTextBox
        {
            private get => _outputFileNameTextBox ??
                throw new ArgumentNullException(Path + nameof(OutputFileNameTextBox));

            set => _outputFileNameTextBox = value;
        }

        public Button ExchangeNamesOfFilesButton
        {
            private get => _exchangeNamesOfFilesButton ??
                throw new ArgumentNullException(Path + nameof(ExchangeNamesOfFilesButton));

            set => _exchangeNamesOfFilesButton = value;
        }

        #endregion

        #region Properties

        internal new NamesOfFilesSelectorModel Model =>
            base.Model as NamesOfFilesSelectorModel;

        #endregion

        #region Public methods

        public void BrowseForInputFileName()
        {
            var openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory
                , CheckFileExists = true
                , Title = "Browse for input file..."
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Model.InputFileName = openFileDialog.FileName;
        }

        public void BrowseForOutputFileName()
        {
            var saveFileDialog = new SaveFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory
                , OverwritePrompt = true
                , Title = "Browse for output file..."
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Model.OutputFileName = saveFileDialog.FileName;
        }

        public void ExchangeNamesOfFiles()
        {
            var temporary = Model.InputFileName;
            Model.InputFileName = Model.OutputFileName;
            Model.OutputFileName = temporary;
        }

        public void OnExchangeNamesOfFilesButtonMouseEnter()
        {
            ExchangeNamesOfFilesButton.Invoke((MethodInvoker)(() =>
            {
                ExchangeNamesOfFilesButton.Image = Properties.Resources.ExchangeNamesOfFilesEntered;
            }));
        }

        public void OnExchangeNamesOfFilesButtonMouseLeave()
        {
            ExchangeNamesOfFilesButton.Invoke((MethodInvoker)(() =>
            {
                ExchangeNamesOfFilesButton.Image = Properties.Resources.ExchangeNamesOfFilesLeft;
            }));
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.InputFileNameChanged += new Action<string>(inputFileName =>
            {
                InputFileNameTextBox.Invoke((MethodInvoker)(() =>
                {
                    InputFileNameTextBox.Text = inputFileName;
                }));
            });
            Model.OutputFileNameChanged += new Action<string>(outputFileName =>
            {
                OutputFileNameTextBox.Invoke((MethodInvoker)(() =>
                {
                    OutputFileNameTextBox.Text = outputFileName;
                }));
            });
            Model.Initialize();
        }

        #endregion

    }

}