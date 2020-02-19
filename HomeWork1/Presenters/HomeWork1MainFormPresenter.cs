using System.ComponentModel;
using System.Windows.Forms;

using HomeWork1.Forms;
using HomeWork1.Properties;

using MVP.Presenter;

namespace HomeWork1.Presenters
{

    internal sealed class HomeWork1MainFormPresenter : PresenterBase
    {

        #region Constructors

        public HomeWork1MainFormPresenter()
            : base(null, "HomeWork1.Presenters.")
        {

        }

        #endregion

        #region Public methods

        public void ShowAboutDialog(HomeWork1MainForm homeWork1MainForm, CancelEventArgs e)
        {
            MessageBox.Show(homeWork1MainForm, Resources.AboutDialogText, Resources.AboutDialogCaption);
            e.Cancel = true;
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {

        }

        #endregion

    }

}