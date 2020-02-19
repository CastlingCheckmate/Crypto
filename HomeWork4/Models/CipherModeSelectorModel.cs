using System;

using Cryptography.HomeWork4;

using MVP.Model;

namespace HomeWork4.Models
{

    internal sealed class CipherModeSelectorModel : ModelBase
    {

        #region Fields

        private SymmetricCipherModes _selectedCipherMode;

        #endregion

        #region Constructors

        public CipherModeSelectorModel()
            : base("HomeWork4.Models.SymmetricCipherModeSelectorModel.")
        {

        }

        #endregion

        #region Properties

        public SymmetricCipherModes SelectedCipherMode
        {
            get => _selectedCipherMode;

            set
            {
                _selectedCipherMode = value;
                SelectedCipherModeChanged?.Invoke(SelectedCipherMode);
            }
        }

        #endregion

        #region Events

        public event Action<SymmetricCipherModes> SelectedCipherModeChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            SelectedCipherMode = SymmetricCipherModes.ElectronicCodeBook;
        }

        #endregion

    }

}