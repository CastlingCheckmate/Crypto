using System.ComponentModel;
using System.Windows.Forms;

using HomeWork3.Forms;
using HomeWork3.Properties;

using MVP.Presenter;

namespace HomeWork3.Presenters
{

    public sealed class HomeWork3MainFormPresenter : PresenterBase
    {

        #region Constructors

        public HomeWork3MainFormPresenter()
            : base(null, "HomeWork3.Presenters.")
        {

        }

        #endregion

        #region Public methods

        //public void ShowAboutDialog(HomeWork3MainForm homeWork3MainForm, CancelEventArgs e)
        //{
        //    MessageBox.Show(homeWork3MainForm, Resources.AboutDialogText, Resources.AboutDialogCaption);
        //    e.Cancel = true;
        //}

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {

        }

        #endregion

    }

}