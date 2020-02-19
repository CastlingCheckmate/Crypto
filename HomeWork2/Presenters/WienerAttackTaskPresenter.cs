using HomeWork2.Models;

using MVP.Presenter;

namespace HomeWork2.Presenters
{

    internal sealed class WienerAttackTaskPresenter : PresenterBase
    {

        #region Constructors

        public WienerAttackTaskPresenter()
            : base(new WienerAttackModel(), "HomeWork2.Presenters.")
        {

        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {

        }

        #endregion

    }

}
