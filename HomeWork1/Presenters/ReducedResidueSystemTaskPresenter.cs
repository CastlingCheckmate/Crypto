using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;

using MVP.Presenter;

using HomeWork1.Models;

namespace HomeWork1.Presenters
{

    internal sealed class ReducedResidueSystemTaskPresenter : PresenterBase, IDisposable
    {

        #region Control fields

        private TextBox _task2ReducedResidueSystemTextBox;

        #endregion

        #region Constructors

        public ReducedResidueSystemTaskPresenter()
            : base(new ReducedResidueSystemTaskModel(), "HomeWork1.Presenters.Task2Presenter.")
        {

        }

        #endregion

        #region Properties

        private new ReducedResidueSystemTaskModel Model => base.Model as ReducedResidueSystemTaskModel;

        #endregion

        #region Control properties

        public TextBox Task2ReducedResidueSystemTextBox
        {
            private get => _task2ReducedResidueSystemTextBox ?? throw new ArgumentNullException(Path + "Task2ReducedResidueSystemTextBox");

            set => _task2ReducedResidueSystemTextBox = value;
        }

        #endregion

        #region Public methods

        public void ParseM(string text)
        {
            if (!BigInteger.TryParse(text, out var m))
            {
                Task2ReducedResidueSystemTextBox.Invoke((MethodInvoker)(() =>
                {
                    Task2ReducedResidueSystemTextBox.Clear();
                }));
                return;
            }
            Model.SetM(m);
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.ReducedResidueSystemChanged += (elements) =>
            {
                if (elements == null)
                {
                    Task2ReducedResidueSystemTextBox.Invoke((MethodInvoker)(() =>
                    {
                        Task2ReducedResidueSystemTextBox.Lines = new string[0];
                    }));
                    return;
                }
                Task2ReducedResidueSystemTextBox.Invoke((MethodInvoker)(async () =>
                {
                    Task2ReducedResidueSystemTextBox.Lines = (await Task.Factory.StartNew(new Func<IEnumerable<string>>(() =>
                    {
                        return elements.Select(element => element.ToString());
                    }))).ToArray();
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