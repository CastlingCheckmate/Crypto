using System;
using System.Windows.Forms;

using MVP.Presenter;

using HomeWork4.Models;

namespace HomeWork4.Presenters
{

    internal sealed class AboutAndInstructionsFormPresenter : PresenterBase
    {

        #region Control fields

        private Label _aboutLabel;
        private Label _instructionsLabel;

        #endregion

        #region Constructors

        public AboutAndInstructionsFormPresenter()
            : base(new AboutAndInstructionsFormModel(), "HomeWork4.Presenters.AboutAndInstructionsFormPresenter.")
        {

        }

        #endregion

        #region Properties

        private new AboutAndInstructionsFormModel Model =>
            base.Model as AboutAndInstructionsFormModel;

        #endregion

        #region Control properties

        public Label AboutLabel
        {
            private get => _aboutLabel ??
                throw new ArgumentNullException(Path + nameof(AboutLabel));

            set => _aboutLabel = value;
        }

        public Label InstructionsLabel
        {
            private get => _instructionsLabel ??
                throw new ArgumentNullException(Path + nameof(InstructionsLabel));

            set => _instructionsLabel = value;
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.AboutChanged += new Action<string>(about =>
            {
                AboutLabel.Invoke((MethodInvoker)(() =>
                {
                    AboutLabel.Text = about;
                }));
            });
            Model.InstructionsChanged += new Action<string[]>(instructions =>
            {
                InstructionsLabel.Invoke((MethodInvoker)(() =>
                {
                    InstructionsLabel.Text = string.Join(Environment.NewLine, instructions);
                }));
            });
            Model.Initialize();
        }

        #endregion

        #region IDisposable interface implementation

        public override void Dispose()
        {
            Model.Dispose();
        }

        #endregion

    }

}