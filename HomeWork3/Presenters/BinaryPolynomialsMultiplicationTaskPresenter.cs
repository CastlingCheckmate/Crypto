using System;
using System.Numerics;
using System.Windows.Forms;

using Cryptography.HomeWork3;

using HomeWork3.Models;

using MVP.Presenter;

namespace HomeWork3.Presenters
{

    internal sealed class BinaryPolynomialsMultiplicationTaskPresenter : PresenterBase
    {

        #region Control fields

        private Label _firstFactorLabel;
        private Label _secondFactorLabel;
        private Label _multiplicationResultLabel;

        #endregion

        #region Constructors

        public BinaryPolynomialsMultiplicationTaskPresenter()
            : base(new BinaryPolynomialsMultiplicationTaskModel(), "HomeWork3.Presenters.")
        {

        }

        #endregion

        #region Properties

        private new BinaryPolynomialsMultiplicationTaskModel Model =>
            base.Model as BinaryPolynomialsMultiplicationTaskModel;

        #endregion

        #region Control properties

        public Label FirstFactorLabel
        {
            private get => _firstFactorLabel ??
                throw new ArgumentNullException(Path + nameof(FirstFactorLabel));

            set => _firstFactorLabel = value;
        }

        public Label SecondFactorLabel
        {
            private get => _secondFactorLabel ??
                throw new ArgumentNullException(Path + nameof(SecondFactorLabel));

            set => _secondFactorLabel = value;
        }

        public Label MultiplicationResultLabel
        {
            private get => _multiplicationResultLabel ??
                throw new ArgumentNullException(Path + nameof(MultiplicationResultLabel));

            set => _multiplicationResultLabel = value;
        }

        #endregion

        #region Public methods

        public void ParseFirstFactor(string firstFactorString)
        {
            if (!BigInteger.TryParse(firstFactorString, out var firstFactor))
            {
                Model.FirstFactor = null;
                return;
            }
            try
            {
                Model.FirstFactor = new BinaryPolynomial(firstFactor);
            }
            catch (ArgumentException)
            {
                Model.FirstFactor = null;
            }
        }

        public void ParseSecondFactor(string secondFactorString)
        {
            if (!BigInteger.TryParse(secondFactorString, out var secondFactor))
            {
                Model.SecondFactor = null;
                return;
            }
            try
            {
                Model.SecondFactor = new BinaryPolynomial(secondFactor);
            }
            catch (ArgumentException)
            {
                Model.SecondFactor = null;
            }
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.FirstFactorChanged += new Action<string>((firstFactorString) =>
            {
                FirstFactorLabel.Invoke((MethodInvoker)(() =>
                {
                    FirstFactorLabel.Text = firstFactorString;
                }));
            });
            Model.SecondFactorChanged += new Action<string>((secondFactorString) =>
            {
                SecondFactorLabel.Invoke((MethodInvoker)(() =>
                {
                    SecondFactorLabel.Text = secondFactorString;
                }));
            });
            Model.MultiplicationResultChanged += new Action<string>((multiplicationResultString) =>
            {
                MultiplicationResultLabel.Invoke((MethodInvoker)(() =>
                {
                    MultiplicationResultLabel.Text = multiplicationResultString;
                }));
            });
            Model.Initialize();
        }

        #endregion

    }

}