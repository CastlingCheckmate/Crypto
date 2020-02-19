using System;
using System.Numerics;
using System.Windows.Forms;

using MVP.Presenter;

using HomeWork1.Models;

namespace HomeWork1.Presenters
{

    internal sealed class DiscreteLogarithmTaskPresenter : PresenterBase
    {

        #region Control fields

        private Label _task4XValueLabel;

        #endregion

        #region Constructors

        public DiscreteLogarithmTaskPresenter()
            : base(new DiscreteLogarithmTaskModel(), "HomeWork1.Presenters.Task4Presenter.")
        {

        }

        #endregion

        #region Properties

        private new DiscreteLogarithmTaskModel Model => base.Model as DiscreteLogarithmTaskModel;

        #endregion

        #region Control properties

        public Label Task4XValueLabel
        {
            private get => _task4XValueLabel ?? throw new ArgumentNullException(Path + "Task4XValueLabel");

            set => _task4XValueLabel = value;
        }

        #endregion

        #region Public methods

        public void ParseG(string text)
        {
            if (!BigInteger.TryParse(text, out var g))
            {
                Task4XValueLabel.Invoke((MethodInvoker)(() =>
                {
                    Task4XValueLabel.Text = string.Empty;
                }));
                return;
            }
            Model.SetG(g);
        }

        public void ParseA(string text)
        {
            if (!BigInteger.TryParse(text, out var a))
            {
                Task4XValueLabel.Invoke((MethodInvoker)(() =>
                {
                    Task4XValueLabel.Text = string.Empty;
                }));
                return;
            }
            Model.SetA(a);
        }

        public void ParseB(string text)
        {
            if (!BigInteger.TryParse(text, out var b))
            {
                Task4XValueLabel.Invoke((MethodInvoker)(() =>
                {
                    Task4XValueLabel.Text = string.Empty;
                }));
                return;
            }
            Model.SetB(b);
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.XValueChanged += (xValue) =>
            {
                if (xValue == BigInteger.MinusOne)
                {
                    Task4XValueLabel.Invoke((MethodInvoker)(() =>
                    {
                        Task4XValueLabel.Text = string.Empty;
                    }));
                    return;
                }
                Task4XValueLabel.Invoke((MethodInvoker)(() =>
                {
                    Task4XValueLabel.Text = xValue.ToString();
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