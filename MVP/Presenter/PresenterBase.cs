using System;

using MVP.Model;

namespace MVP.Presenter
{

    public abstract class PresenterBase : IDisposable
    {

        #region Fields

        private ModelBase _model;
        private string _path;

        #endregion

        #region Constructors

        protected PresenterBase(ModelBase model, string path)
        {
            Model = model;
            Path = path;
        }

        #endregion

        #region Properties

        protected ModelBase Model
        {
            get => _model ??
                throw new ArgumentNullException("MVP.PresenterBase.Model");

            private set => _model = value;
        }

        protected string Path
        {
            get => _path ??
                throw new ArgumentNullException("MVP.PresenterBase.Path");

            private set => _path = value;
        }

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