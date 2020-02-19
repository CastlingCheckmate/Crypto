using System;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

using Cryptography.HomeWork3;

using HomeWork3.Models;

using MVP.Presenter;

namespace HomeWork3.Presenters
{

    internal sealed class GF256ElementToStringTaskPresenter : PresenterBase
    {

        #region Control fields

        private Label _elementLabel;

        #endregion

        #region Constructors

        public GF256ElementToStringTaskPresenter()
            : base(new GF256ElementToStringTaskModel(), "HomeWork3.Presenters.")
        {

        }

        #endregion

        #region Properties

        private new GF256ElementToStringTaskModel Model => base.Model as GF256ElementToStringTaskModel;

        #endregion

        #region Control properties

        public Label ElementLabel
        {
            private get => _elementLabel ?? throw new ArgumentNullException(Path + nameof(ElementLabel));

            set => _elementLabel = value;
        }

        #endregion

        #region Public methods

        public void ParseElement(string elementString)
        {
            if (!BigInteger.TryParse(elementString, out var element))
            {
                ElementLabel.Invoke((MethodInvoker)(() =>
                {
                    ElementLabel.Text = string.Empty;
                }));
                return;
            }
            try
            {
                Model.Element = new GF256Element(new BinaryPolynomial(element));
            }
            catch (ArgumentException)
            {
                ElementLabel.Invoke((MethodInvoker)(() =>
                {
                    ElementLabel.Text = string.Empty;
                }));
            }
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.ElementChanged += new Action<string>((elementString) =>
            {
                ElementLabel.Invoke((MethodInvoker)(() =>
                {
                    ElementLabel.Text = elementString;
                }));
            });
            Model.Initialize();
        }

        #endregion

    }

}