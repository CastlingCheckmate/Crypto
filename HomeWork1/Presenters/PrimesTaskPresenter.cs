using System;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;

using MVP.Presenter;

using HomeWork1.Models;

namespace HomeWork1.Presenters
{

    internal sealed class PrimesTaskPresenter : PresenterBase, IDisposable
    {

        #region Control fields

        private TextBox _task1PrimesTextBox;

        #endregion

        #region Constructors

        public PrimesTaskPresenter()
            : base(new PrimesTaskModel(), "HomeWork1.Presenters.Task1Presenter.")
        {

        }

        #endregion

        #region Properties

        private new PrimesTaskModel Model => base.Model as PrimesTaskModel;

        #endregion

        #region Control properties

        public TextBox Task1PrimesTextBox
        {
            private get => _task1PrimesTextBox ?? throw new ArgumentNullException(Path + "Task1PrimesTextBox");

            set => _task1PrimesTextBox = value;
        }

        #endregion

        #region Public methods

        public void ParseM(string text)
        {
            if (!BigInteger.TryParse(text, out var m))
            {
                Task1PrimesTextBox.Invoke((MethodInvoker)(() =>
                {
                    Task1PrimesTextBox.Clear();
                }));
                return;
            }
            Model.SetM(m);
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.PrimesChanged += (primes) =>
            {
                var primesString = string.Empty;
                var thread = new Thread(() =>
                {
                    if (primes != null)
                    {
                        primesString = string.Join($"{Environment.NewLine}", primes.Select(prime => prime.ToString()));
                    }
                });
                thread.Start();
                thread.Join();
                Task1PrimesTextBox.Invoke((MethodInvoker)(() =>
                {
                    Task1PrimesTextBox.Text = primesString;
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