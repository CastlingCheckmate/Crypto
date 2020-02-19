using System;
using System.Collections.Generic;

using MVP.Presenter;

namespace MVP.CommonPresenter
{

    public abstract class CommonPresenterBase : IDisposable
    {

        #region Fields

        private string _path;
        private Dictionary<string, PresenterBase> _presenters;

        #endregion

        #region Constructors

        public CommonPresenterBase(string path)
        {

        }

        #endregion

        #region Properties

        protected string Path
        {
            get => _path ??
                throw new ArgumentNullException("MVP.CommonPresenterBase.Path");

            private set => _path = value;
        }

        protected Dictionary<string, PresenterBase> Presenters
        {
            get => _presenters;

            set => _presenters = value ??
                throw new ArgumentNullException(nameof(value));
        }

        protected PresenterBase this[string name] => _presenters[name];

        #endregion

        #region Abstract methods

        public abstract void Initialize();

        #endregion

        #region IDisposable interface implementation

        public virtual void Dispose()
        {

        }

        #endregion

    }

}