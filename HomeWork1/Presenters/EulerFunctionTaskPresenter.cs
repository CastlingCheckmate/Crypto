using System;
using System.Numerics;
using System.Windows.Forms;

using MVP.Presenter;

using HomeWork1.Models;

namespace HomeWork1.Presenters
{

    internal sealed class EulerFunctionTaskPresenter : PresenterBase
    {

        #region Control fields

        private Label _task3EulerFunctionValueLabel;

        #endregion

        #region Constructors

        public EulerFunctionTaskPresenter()
            : base(new EulerFunctionTaskModel(), "HomeWork1.Presenters.Task3Presenter.")
        {

        }

        #endregion

        #region Properties

        private new EulerFunctionTaskModel Model => base.Model as EulerFunctionTaskModel;

        #endregion

        #region Control properties

        public Label Task3EulerFunctionValueLabel
        {
            private get => _task3EulerFunctionValueLabel ??
                throw new ArgumentNullException(Path + "Task3EulerFunctionValueLabel");

            set => _task3EulerFunctionValueLabel = value;
        }

        #endregion

        #region Public methods

        public void ParseM(string text)
        {
            if (!BigInteger.TryParse(text, out var m))
            {
                Task3EulerFunctionValueLabel.Invoke((MethodInvoker)(() =>
                {
                    Task3EulerFunctionValueLabel.Text = string.Empty;
                }));
                return;
            }
            Model.SetM(m);
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.EulerFunctionChanged += (EulerFunctionValue) =>
            {
                Task3EulerFunctionValueLabel.Invoke((MethodInvoker)(() =>
                {
                    Task3EulerFunctionValueLabel.Text =
                        EulerFunctionValue == BigInteger.MinusOne ? string.Empty : EulerFunctionValue.ToString();
                }));
            };
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