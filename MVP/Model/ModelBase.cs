using System;

namespace MVP.Model
{

    public abstract class ModelBase : IDisposable
    {

        #region Fields

        private string _path;

        #endregion

        #region Constructors

        protected ModelBase(string path)
        {
            Path = path;
        }

        #endregion

        #region Properties

        protected string Path
        {
            get => _path;

            private set => _path = value;
        }

        #endregion

        #region Methods

        public abstract void Initialize();

        #endregion

        #region IDisposable interface implementation

        public virtual void Dispose()
        {

        }

        #endregion

    }

}