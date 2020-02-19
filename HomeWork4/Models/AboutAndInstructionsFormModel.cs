using System;

using MVP.Model;

namespace HomeWork4.Models
{

    internal sealed class AboutAndInstructionsFormModel : ModelBase
    {

        #region Fields

        private string _about;
        private string[] _instructions;

        #endregion

        #region Constructors

        public AboutAndInstructionsFormModel()
            : base("HomeWork4.Models.AboutAndInstructionsFormModel.")
        {

        }

        #endregion

        #region Properties

        public string About
        {
            get => _about ??
                throw new ArgumentNullException(Path + nameof(About));

            private set
            {
                _about = value;
                AboutChanged?.Invoke(About);
            }
        }

        public string[] Instructions
        {
            get => _instructions ??
                throw new ArgumentNullException(Path + nameof(Instructions));

            private set
            {
                _instructions = value;
                InstructionsChanged?.Invoke(Instructions);
            }
        }

        #endregion

        #region Events

        public event Action<string> AboutChanged;
        public event Action<string[]> InstructionsChanged;

        #endregion

        #region ModelBase class abstract methods implementation

        public override void Initialize()
        {
            About = "Shitcoded by Ilya Irbitskiy (=";
            Instructions = new string[]
            {
                "Some instructions from shitcoder:"
                , "This software can be used to cipher files with Rijndael algorithm."
                , "You can select input and output files names"
                , "    [and exchange them by pushing square button with awful arrows (= ]."
                , "You can choose block size, key size, generate random keys and IV's then saving it to file."
                , "Also You can select cipher mode"
                , "    [ECB is not so cool, don't use it (= ]"
                , "And, finally, You can change Rijndael algorithm irreducible polynomial."
                , "I have nothing more to say. Just enjoy this software (="
                , "Maybe just I wanted You not to decompile this, so as not to become blind (=      I warned."
            };
        }

        #endregion

    }

}