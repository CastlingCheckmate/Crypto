using System;
using System.Windows.Forms;

using HomeWork4.Presenters;

namespace HomeWork4.Forms
{

    public partial class AboutAndInstructionsForm : Form
    {

        #region Fields

        private AboutAndInstructionsFormPresenter _presenter;

        #endregion

        #region Constructors

        public AboutAndInstructionsForm()
        {
            InitializeComponent();
            Presenter = new AboutAndInstructionsFormPresenter
            {
                AboutLabel = aboutLabel
                , InstructionsLabel = instructionsLabel
            };
        }

        #endregion

        #region Properties

        private AboutAndInstructionsFormPresenter Presenter
        {
            get => _presenter ??
                throw new ArgumentNullException("HomeWork4.Forms.AboutAndInstructionsForm.Presenter");

            set => _presenter = value;
        }

        #endregion

        #region Event handlers

        private void AboutAndInstructionsForm_Load(object sender, EventArgs e)
        {
            Presenter.Initialize();
        }

        #endregion

    }

}