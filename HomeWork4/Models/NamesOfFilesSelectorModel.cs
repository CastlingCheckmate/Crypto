using System;

using MVP.Model;

namespace HomeWork4.Models
{
    internal sealed class NamesOfFilesSelectorModel : ModelBase
    {

        #region Fields

        private string _inputFileName;
        private string _outputFileName;

        #endregion

        #region Constructors

        public NamesOfFilesSelectorModel()
            : base("HomeWork4.Models.NamesOfFilesSelectorModel")
        {

        }

        #endregion

        #region Properties

        public string InputFileName
        {
            get => _inputFileName;

            set
            {
                _inputFileName = value;
                InputFileNameChanged?.Invoke(InputFileName);
            }
        }

        public string OutputFileName
        {
            get => _outputFileName;

            set
            {
                _outputFileName = value;
                OutputFileNameChanged?.Invoke(OutputFileName);
            }
        }

        #endregion

        #region Events

        public event Action<string> InputFileNameChanged;
        public event Action<string> OutputFileNameChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            InputFileName = string.Empty;
            OutputFileName = string.Empty;
        }

        #endregion

    }

}