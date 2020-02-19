using System.Windows.Forms;

using HomeWork2.Presenters;

using MVP.Presenter;

namespace HomeWork2.Forms
{

    public partial class HomeWork2Form : Form
    {

        #region Fields

        private PresenterBase[] _presenters;

        #endregion

        #region Constructors

        public HomeWork2Form()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private PresenterBase[] Presenters
        {
            get => _presenters;

            set => _presenters = value;
        }

        private WienerAttackTaskPresenter WienerAttackTaskPresenter =>
            Presenters[0] as WienerAttackTaskPresenter;

        #endregion

        #region Event handlers



        #endregion

    }

}